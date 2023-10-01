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
    public partial class AssignBatchToTruck : Form
    {

        private string jsonBody;

        public AssignBatchToTruck()
        {
            InitializeComponent();
            refreshTable();
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

        private static RestResponse getBatchsFromApi()
        {
            RestClient client = new RestClient("http://localhost:64191");
            RestRequest request = new RestRequest("/api/v1/camionllevalotes", Method.Get);
            request.AddHeader("Accept", "application/json");
            RestResponse response = client.Execute(request);
            return response;
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
            RestResponse response = getBatchsFromApi();

            DataTable table = new DataTable();
            table.Columns.Add("ID Lote", typeof(int));
            table.Columns.Add("ID Camion", typeof(int));
            table.Columns.Add("Fecha Entrega", typeof(DateTime));

            foreach (AssignedBatchToTruckInterface batchAssigned in deserializeAssignedBatch(response.Content))
            {
                fillDataTable(table, batchAssigned);
            }

            return table;
        }

        #endregion getAssignedBatchFromAPi

        #region postAssignedBatchToAPI

        private bool sendAssignedBatchDataToApi(string jsonBody)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:64191");
                RestRequest request = new RestRequest("/api/v1/camionllevalotes", Method.Post);
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
                MessageBox.Show("Error al asignar el lote al camion, error - > " + ex.Message);
                return false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            jsonBody = "";

            if (!validateInputsUser())
            {
                MessageBox.Show("Por favor, completa todos los campos.");
                return;
            }

            DateTime shippDate = dateTimePickerBatchShippingDate.Value;

            AssignedBatchToTruckInterface batchAssigned = new AssignedBatchToTruckInterface
            {
                IDBatch = Convert.ToInt32(txtBoxIDBatch.Text),
                IDTruck = Convert.ToInt32(txtBoxIDTruck.Text),
                ShippDate = shippDate
            };

            jsonBody = JsonConvert.SerializeObject(batchAssigned);

            if (sendAssignedBatchDataToApi(jsonBody))
            {
                refreshTable();
                MessageBox.Show("Lote vinculado al camión exitosamente.");
                clearTxtsBoxes();
            }
            else
            {
                MessageBox.Show("Error al vincular el lote. Por favor, verifica los datos ingresados.");
            }
        }

        #endregion postAssignedBatchToAPI

        #region deleteAssignedBatchToAPI

        private bool deleteAssignedBatchFromApi(int batchId)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:64191");
                RestRequest request = new RestRequest($"/api/v1/camionllevalotes/{batchId}", Method.Delete);
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
                MessageBox.Show("Error al des-asignar el lote: " + ex.Message);
                return false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtBoxIDBatch.Text))
            {
                MessageBox.Show("Por favor, selecciona una fila para des-asignar un lote.");
                return;
            }

            int batchIdToDelete = Convert.ToInt32(txtBoxIDBatch.Text);

            if (deleteAssignedBatchFromApi(batchIdToDelete))
            {
                refreshTable();
                MessageBox.Show("Lote des-asignado exitosamente.");
                clearTxtsBoxes();
            }
            else
            {
                MessageBox.Show("Error al des-asignar el lote. Por favor, verifica los datos ingresados.");
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