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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Almacen.Forms
{
    public partial class BatchManagerForm : Form
    {
        public event Action LanguageChanged;
        private string jsonBody;
        private ApiRequestBatch apiRequests;

        public BatchManagerForm()
        {
            InitializeComponent();
            refreshTable();
            comboBoxActivated.Items.Add("true");
            comboBoxActivated.Items.Add("false");
            comboBoxActivated.SelectedItem = "false";
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += UpdateLanguage;
            }
            apiRequests = new ApiRequestBatch("http://localhost:64191");
        }

        private void UpdateLanguage()
        {
            buttonAdd.Text = LanguageManager.GetString("Add");
            buttonDestinationList.Text = LanguageManager.GetString("ViewDestinations");
            buttonDelete.Text = LanguageManager.GetString("Delete");
            buttonRefresh.Text = LanguageManager.GetString("Refresh");
            buttonBackToMainMenu.Text = LanguageManager.GetString("Back");
            buttonSearcher.Text = LanguageManager.GetString("Searcher");
            buttonViewMap.Text = LanguageManager.GetString("ViewMap");

            labelEstatus.Text = LanguageManager.GetString("Status");
            labelEstimatedDate.Text = LanguageManager.GetString("EstimatedDate");
            labelLot.Text = LanguageManager.GetString("LotID");
            labelIDDestination.Text = LanguageManager.GetString("IDDestination");
          
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region getBatchsFromAPI
        private List<BatchInterface> deserializeBatch(string content)
        {
            if (content == null)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<BatchInterface>>(content);
        }

        private static void fillDataTable(DataTable table, BatchInterface batch)
        {
            DataRow rows = table.NewRow();
            rows["ID"] = batch.IDBatches;
            rows["Email"] = batch.Email;
            rows[LanguageManager.GetString("DateOfCreation")] = batch.DateOfCreation;
            rows[LanguageManager.GetString("IDDestination")] = batch.IDShipp;
            rows[LanguageManager.GetString("DateOfShipment")] = batch.ShippingDate;
            rows[LanguageManager.GetString("Activated")] = batch.ActivedBatch;
            table.Rows.Add(rows);
        }

        private DataTable getDataTable()
        {
            ApiRequestBatch apiRequest = new ApiRequestBatch("http://localhost:64191");
            List<BatchInterface> batchCreated = apiRequest.GetBatchs();

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Email", typeof(string));
            table.Columns.Add(LanguageManager.GetString("DateOfCreation"), typeof(DateTime));
            table.Columns.Add(LanguageManager.GetString("IDDestination"), typeof(int));
            table.Columns.Add(LanguageManager.GetString("DateOfShipment"), typeof(DateTime));
            table.Columns.Add(LanguageManager.GetString("Activated"), typeof(bool));

            foreach (BatchInterface batch in batchCreated)
            {
                DataRow row = table.NewRow();
                row["ID"] = batch.IDBatches;
                row["Email"] = batch.Email;
                row[LanguageManager.GetString("DateOfCreation")] = batch.DateOfCreation;
                row[LanguageManager.GetString("IDDestination")] = batch.IDShipp;
                row[LanguageManager.GetString("DateOfShipment")] = batch.ShippingDate;
                row[LanguageManager.GetString("Activated")] = batch.ActivedBatch;
                table.Rows.Add(row);
            }
            return table;
        }

        private void refreshTable()
        {
            DataTable table = getDataTable();
            dataGridViewBatch.DataSource = table;
        }
        #endregion getBatchsFromAPI

        #region postBatchsToAPI

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            jsonBody = "";

            string selectedStatus = comboBoxActivated.SelectedItem as string;
            int statusValue = selectedStatus == "true" ? 1 : 0;

            if (!validateInputsUser() && !string.IsNullOrWhiteSpace(selectedStatus))
            {
                MessageBox.Show(Messages.Error + " " + Messages.CompleteAllBoxAndStatus);
                return;
            }

            DateTime separateddate = dateTimePickerBatchShippingDate.Value.Date;
            DateTime separatedtime = dateTimePickerBatchManagementTime.Value;
            DateTime dateandtime = separateddate.Add(separatedtime.TimeOfDay);

            BatchInterface batch = new BatchInterface
            {
                IDShipp = Convert.ToInt32(txtBoxIDDestination.Text),
                Email = txtBoxEmail.Text,
                ShippingDate = Convert.ToDateTime(dateandtime),
                ActivedBatch = Convert.ToBoolean(statusValue)
            };

            jsonBody = JsonConvert.SerializeObject(batch);

            if (apiRequests.AddBatch(batch))
            {
                refreshTable();
                MessageBox.Show(Messages.Successful);
                clearTxtBoxs();
            }
            else
            {
                MessageBox.Show(Messages.Error + " " + Messages.CompleteAllBoxAndStatus);
            }
        }

        #endregion postBatchsToAPI

        #region deleteBatchFromAPI

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxIDBatch.Text))
            {
                MessageBox.Show(Messages.SelectAnIndex);
                return;
            }

            int batchIdToDelete = Convert.ToInt32(txtBoxIDBatch.Text);

            if (apiRequests.DeleteBatch(batchIdToDelete))
            {
                refreshTable();
                MessageBox.Show(Messages.Successful);
                clearTxtBoxs();
            }
            else
            {
                MessageBox.Show(Messages.Error + " " + Messages.CompleteAllBoxAndStatus);
            }
        }

        #endregion deleteBatchFromAPI

        #region validationsAndUtils

        private bool validateInputsUser()
        {

            if (string.IsNullOrWhiteSpace(txtBoxEmail.Text) ||
                string.IsNullOrWhiteSpace(txtBoxIDDestination.Text))
            {
                return false;
            }

            return true;
        }

        private void clearTxtBoxs()
        {
            txtBoxIDBatch.Clear();
            txtBoxIDDestination.Clear();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void dataGridViewBatch_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewBatch.SelectedRows.Count > 0)
            {

                int batchIdFromDataGrid = Convert.ToInt32(dataGridViewBatch.SelectedRows[0].Cells["ID"].Value);

                txtBoxIDBatch.Text = batchIdFromDataGrid.ToString();
            }
        }

        #endregion validationsAndUtils

        private void buttonSearcher_Click(object sender, EventArgs e)
        {
            BatchManagerSearcherForm searcherForm = new BatchManagerSearcherForm();
            searcherForm.Show();
        }

        private void BatchManagerForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonDestinationList_Click(object sender, EventArgs e)
        {
            DestinationListForm getAllDestinationsForm = new DestinationListForm();
            getAllDestinationsForm.Show();
        }

        private void buttonViewMap_Click(object sender, EventArgs e)
        {
            MapForm viewMap = new MapForm();
            viewMap.Show();
        }
    }
}
