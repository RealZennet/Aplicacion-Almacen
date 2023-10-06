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
    public partial class AssignProductsToBatchForm : Form
    {
        public event Action LanguageChanged;
        private string jsonBody;
        private ApiRequestAssignProductToBatch apiRequests;

        public AssignProductsToBatchForm()
        {
            InitializeComponent();
            refreshTable();
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += UpdateLanguage;
            }
            apiRequests = new ApiRequestAssignProductToBatch("http://localhost:64191");
        }

        private void UpdateLanguage()
        {
            buttonAdd.Text = LanguageManager.GetString("Add");
            buttonDelete.Text = LanguageManager.GetString("Delete");
            buttonRefresh.Text = LanguageManager.GetString("Refresh");
            buttonBackToMainMenu.Text = LanguageManager.GetString("Back");

            labelIDLotToAssign.Text = LanguageManager.GetString("LotIDToAssign");
            labelAssignProductToLot.Text = LanguageManager.GetString("ProductIDToAssign");

        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region getBatchsFromAPI
        private List<AssignProductsToBatchInterface> deserializeAssignedProductToBatch(string content)
        {
            if (content == null)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<List<AssignProductsToBatchInterface>>(content);
        }

        private static RestResponse getAssignedProductsToBatchsFromApi()
        {
            RestClient client = new RestClient("http://localhost:64191");
            RestRequest request = new RestRequest("/api/v1/integrarpaquetes", Method.Get);
            request.AddHeader("Accept", "application/json");
            RestResponse response = client.Execute(request);
            return response;
        }

        private static void fillDataTable(DataTable table, AssignProductsToBatchInterface assignedproduct)
        {
            DataRow rows = table.NewRow();
            rows[LanguageManager.GetString("LotID")] = assignedproduct.IDBatch;
            rows["ID Product"] = assignedproduct.IDProduct;
            table.Rows.Add(rows);
        }

        private DataTable getDataTable()
        {
            RestResponse response = getAssignedProductsToBatchsFromApi();

            DataTable table = new DataTable();
            table.Columns.Add(LanguageManager.GetString("LotID"), typeof(int));
            table.Columns.Add("ID Product", typeof(int));

            foreach (AssignProductsToBatchInterface batch in deserializeAssignedProductToBatch(response.Content))
            {
                fillDataTable(table, batch);
            }

            return table;
        }

        private void refreshTable()
        {
            DataTable table = getDataTable();
            dataGridViewAssignedProducts.DataSource = table;
        }
        #endregion getBatchsFromAPI

        #region postAssignedProductToAPI

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            jsonBody = "";

            if (!validateInputsUser())
            {
                MessageBox.Show(Messages.CompleteAllBoxAndStatus);
                return;
            }

            AssignProductsToBatchInterface batch = new AssignProductsToBatchInterface
            {
                IDProduct = Convert.ToInt32(txtBoxIDProduct.Text),
                IDBatch = Convert.ToInt32(txtBoxIDBatch.Text)
            };

            if (apiRequests.AddAssignedProduct(batch))
            {
                refreshTable();
                MessageBox.Show(Messages.Successful);
                clearTxtBoxs();
            }
            else
            {
                MessageBox.Show(Messages.Error + ", " + Messages.CompleteAllBoxAndStatus);
            }
        }

        #endregion postAssignedProductToAPI

        #region deleteAssignedProductToAPI

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAssignedProducts.SelectedRows.Count > 0)
            {
                int assignedProductIdToDelete = Convert.ToInt32(dataGridViewAssignedProducts.SelectedRows[0].Cells["ID Product"].Value);

                if (apiRequests.DeleteAssignedProductToBatch(assignedProductIdToDelete))
                {
                    refreshTable();
                    MessageBox.Show(Messages.Successful);
                    clearTxtBoxs();
                }
                else
                {
                    MessageBox.Show(Messages.Error + " " + Messages.VerifyData);
                }
            }
            else
            {
                MessageBox.Show(Messages.SelectAnIndex);
            }
        }


        #endregion deleteAssignedProductToAPI

        #region validationsAndUtils

        private bool validateInputsUser()
        {

            if (string.IsNullOrWhiteSpace(txtBoxIDBatch.Text) ||
                string.IsNullOrWhiteSpace(txtBoxIDProduct.Text))
            {
                return false;
            }

            return true;
        }

        private void clearTxtBoxs()
        {
            txtBoxIDBatch.Clear();
            txtBoxIDProduct.Clear();
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void dataGridViewAssignedProducts_SelectionChanged(object sender, EventArgs e)
        {

        }

        #endregion validationsAndUtils


    }
}
