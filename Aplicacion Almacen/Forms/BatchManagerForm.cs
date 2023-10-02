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
        }

        private void UpdateLanguage()
        {
            buttonAdd.Text = LanguageManager.GetString("Add");
            buttonDestinationList.Text = LanguageManager.GetString("ViewDestinations");
            buttonDelete.Text = LanguageManager.GetString("Delete");
            buttonRefresh.Text = LanguageManager.GetString("Refresh");
            buttonBackToMainMenu.Text = LanguageManager.GetString("Back");
            buttonSearcher.Text = LanguageManager.GetString("Searcher");

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

        private static RestResponse getBatchsFromApi()
        {
            RestClient client = new RestClient("http://localhost:64191");
            RestRequest request = new RestRequest("/api/v1/lotes", Method.Get);
            request.AddHeader("Accept", "application/json");
            RestResponse response = client.Execute(request);
            return response;
        }

        private static void fillDataTable(DataTable table, BatchInterface batch)
        {
            DataRow rows = table.NewRow();
            rows["ID"] = batch.IDBatches;
            rows[LanguageManager.GetString("DateOfCreation")] = batch.DateOfCreation;
            rows[LanguageManager.GetString("IDDestination")] = batch.IDShipp;
            rows[LanguageManager.GetString("DateOfShipment")] = batch.ShippingDate;
            rows[LanguageManager.GetString("Activated")] = batch.ActivedBatch;
            table.Rows.Add(rows);
        }

        private DataTable getDataTable()
        {
            RestResponse response = getBatchsFromApi();

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add(LanguageManager.GetString("DateOfCreation"), typeof(DateTime));
            table.Columns.Add(LanguageManager.GetString("IDDestination"), typeof(int));
            table.Columns.Add(LanguageManager.GetString("DateOfShipment"), typeof(DateTime));
            table.Columns.Add(LanguageManager.GetString("Activated"), typeof(bool));

            foreach (BatchInterface batch in deserializeBatch(response.Content))
            {
                fillDataTable(table, batch);
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

        private bool sendBatchDataToApi(string jsonBody)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:64191");
                RestRequest request = new RestRequest("/api/v1/lotes", Method.Post);
                request.AddHeader("Accept", "application/json");
                request.AddHeader("Content-Type", "application/json");
                request.AddParameter("application/json", jsonBody, ParameterType.RequestBody);

                RestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(Messages.Error + " : " + response.StatusCode);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Messages.Error + " : " + ex.Message);
                return false;
            }
        }

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

            BatchInterface batch = new BatchInterface
            {
                IDBatches = Convert.ToInt32(txtBoxIDBatch.Text),
                IDShipp = Convert.ToInt32(txtBoxIDDestination.Text),
                ShippingDate = (Convert.ToDateTime(dateTimePickerBatchShippingDate.Text)),
                ActivedBatch = Convert.ToBoolean(statusValue)
            };

            jsonBody = JsonConvert.SerializeObject(batch);

            if (sendBatchDataToApi(jsonBody))
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

        private bool deleteProductFromApi(int batchId)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:64191");
                RestRequest request = new RestRequest($"/api/v1/lotes/{batchId}", Method.Delete);
                request.AddHeader("Accept", "application/json");

                RestResponse response = client.Execute(request);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    MessageBox.Show(Messages.Error + " : " + response.StatusCode);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(Messages.Error + " : " + ex.Message);
                return false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxIDBatch.Text))
            {
                MessageBox.Show(Messages.SelectAnIndex);
                return;
            }

            int batchIdToDelete = Convert.ToInt32(txtBoxIDBatch.Text);

            if (deleteProductFromApi(batchIdToDelete))
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

            if (string.IsNullOrWhiteSpace(txtBoxIDBatch.Text) ||
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
            BatchManagerSearcher searcherForm = new BatchManagerSearcher();
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
    }
}
