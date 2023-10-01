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

        private string jsonBody;

        public BatchManagerForm()
        {
            InitializeComponent();
            refreshTable();
            comboBoxActivated.Items.Add("true");
            comboBoxActivated.Items.Add("false");
            comboBoxActivated.SelectedItem = "false";
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
            rows["Fecha de creacion"] = batch.DateOfCreation;
            rows["ID Destino"] = batch.IDShipp;
            rows["Fecha Envio"] = batch.ShippingDate;
            rows["Activado"] = batch.ActivedBatch;
            table.Rows.Add(rows);
        }

        private DataTable getDataTable()
        {
            RestResponse response = getBatchsFromApi();

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Fecha de creacion", typeof(DateTime));
            table.Columns.Add("ID Destino", typeof(int));
            table.Columns.Add("Fecha Envio", typeof(DateTime));
            table.Columns.Add("Activado", typeof(bool));

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
                    MessageBox.Show("La solicitud al servidor no se completó correctamente. Código de estado: " + response.StatusCode);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el lote: " + ex.Message);
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
                MessageBox.Show("Por favor, completa todos los campos y selecciona el estado del lote.");
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
                MessageBox.Show("Lote agregado exitosamente.");
                clearTxtBoxs();
            }
            else
            {
                MessageBox.Show("Error al agregar el lote. Por favor, verifica los datos ingresados.");
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
                    MessageBox.Show("La solicitud al servidor no se completó correctamente. Código de estado: " + response.StatusCode);
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el lote: " + ex.Message);
                return false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxIDBatch.Text))
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar un lote.");
                return;
            }

            int batchIdToDelete = Convert.ToInt32(txtBoxIDBatch.Text);

            if (deleteProductFromApi(batchIdToDelete))
            {
                refreshTable();
                MessageBox.Show("Lote eliminado exitosamente.");
                clearTxtBoxs();
            }
            else
            {
                MessageBox.Show("Error al eliminar el lote. Por favor, verifica los datos ingresados.");
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
