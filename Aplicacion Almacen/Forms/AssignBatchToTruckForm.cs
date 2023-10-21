using Aplicacion_Almacen.ApiRequests;
using Aplicacion_Almacen.Languages;
using Aplicacion_Almacen.StoreHouseRequests;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Almacen.Forms
{
    public partial class AssignBatchToTruckForm : Form
    {
        public event Action LanguageChanged;
        private string jsonBody;
        private ApiRequestAssignBatchToTruck apiRequests;

        public AssignBatchToTruckForm()
        {
            InitializeComponent();
            refreshTable();
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += UpdateLanguage;
            }
            apiRequests = new ApiRequestAssignBatchToTruck("http://localhost:64191");
        }

        private void UpdateLanguage()
        {
            buttonAdd.Text = LanguageManager.GetString("Add");
            buttonDelete.Text = LanguageManager.GetString("Delete");
            buttonRefresh.Text = LanguageManager.GetString("Refresh");
            buttonBackToMainMenu.Text = LanguageManager.GetString("Back");

            labelTruckID.Text = LanguageManager.GetString("IDTruck");
            labelEstimatedDate.Text = LanguageManager.GetString("EstimatedDate");
            labelIDBatch.Text = LanguageManager.GetString("LotID");

        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #region getAssignedBatchFromAPI

        private List<AssignedBatchToTruckInterface> deserializeAssignedBatch(string content)
        {
            if (content == null)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<AssignedBatchToTruckInterface>>(content);
        }

        private static void fillDataTable(DataTable table, AssignedBatchToTruckInterface assignedBatch)
        {
            DataRow rows = table.NewRow();
            rows["ID Lote"] = assignedBatch.IDBatch;
            rows["ID Camion"] = assignedBatch.IDTruck;
            rows["Fecha Entrega"] = assignedBatch.ShippDate;
            table.Rows.Add(rows);
        }

        private DataTable getDataTable()
        {
            ApiRequestAssignBatchToTruck apiRequest = new ApiRequestAssignBatchToTruck("http://localhost:64191");

            List<AssignedBatchToTruckInterface> batchAssigned = apiRequest.GetAssignedBatchToTruck();
            DataTable table = new DataTable();
            table.Columns.Add("ID Lote", typeof(int));
            table.Columns.Add("ID Camion", typeof(int));
            table.Columns.Add("Fecha Entrega", typeof(DateTime));
            foreach (AssignedBatchToTruckInterface batch in batchAssigned)
            {
                DataRow row = table.NewRow();
                row["ID Lote"] = batch.IDBatch;
                row["ID Camion"] = batch.IDTruck;
                row["Fecha Entrega"] = batch.ShippDate;
                table.Rows.Add(row);
            }
            return table;
        }

        #endregion getAssignedBatchFromAPi

        #region postAssignedBatchToAPI

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            jsonBody = "";

            if (!validateInputsUser())
            {
                MessageBox.Show(Messages.CompleteAllBoxAndStatus);
                return;
            }

            DateTime separateddate = dateTimePickerBatchShippingDate.Value.Date;
            DateTime separatedtime = dateTimePickerAssignBatchToTruckManagementTime.Value;
            DateTime dateandtime = separateddate.Add(separatedtime.TimeOfDay);

            AssignedBatchToTruckInterface batchAssigned = new AssignedBatchToTruckInterface
            {
                IDBatch = Convert.ToInt32(txtBoxIDBatch.Text),
                IDTruck = Convert.ToInt32(txtBoxIDTruck.Text),
                ShippDate = dateandtime
            };

            if (apiRequests.AddAssignedBatchToTruck(batchAssigned))
            {
                refreshTable();
                MessageBox.Show(Messages.Successful);
                clearTxtsBoxes();
            }
            else
            {
                MessageBox.Show(Messages.Error + " " + Messages.CompleteAllBoxAndStatus);
            }
        }

        #endregion postAssignedBatchToAPI

        #region deleteAssignedBatchToAPI

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxIDBatch.Text))
            {
                MessageBox.Show(Messages.SelectAnIndex);
                return;
            }

            int batchIdToDelete = Convert.ToInt32(txtBoxIDBatch.Text);

            if (apiRequests.DeleteAssignedBatch(batchIdToDelete))
            {
                refreshTable();
                MessageBox.Show(Messages.Successful);
                clearTxtsBoxes();
            }
            else
            {
                MessageBox.Show(Messages.Error + " " + Messages.VerifyData);
            }
        }

        #endregion deleteAssignedBatchToAPI

        #region utils
        private void clearTxtsBoxes()
        {
            txtBoxIDBatch.Clear();
            txtBoxIDTruck.Clear();
        }

        private void refreshTable()
        {
            DataTable table = getDataTable();
            dataGridViewAssignedBatchToTruck.DataSource = table;
        }

        private bool validateInputsUser()
        {

            if (string.IsNullOrWhiteSpace(txtBoxIDBatch.Text) ||
                string.IsNullOrWhiteSpace(txtBoxIDTruck.Text))
            {
                return false;
            }

            return true;
        }

        private void dataGridViewAssignedBatchToTruck_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewAssignedBatchToTruck.SelectedRows.Count > 0)
            {

                int batchIdFromDataGrid = Convert.ToInt32(dataGridViewAssignedBatchToTruck.SelectedRows[0].Cells["ID Lote"].Value);

                txtBoxIDBatch.Text = batchIdFromDataGrid.ToString();
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        #endregion utils

    }
}