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

        private string jsonBody;

        public AssignProductsToBatchForm()
        {
            InitializeComponent();
            refreshTable();
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
            rows["ID Lote"] = assignedproduct.IDBatch;
            rows["ID Producto"] = assignedproduct.IDProduct;
            table.Rows.Add(rows);
        }

        private DataTable getDataTable()
        {
            RestResponse response = getAssignedProductsToBatchsFromApi();

            DataTable table = new DataTable();
            table.Columns.Add("ID Lote", typeof(int));
            table.Columns.Add("ID Producto", typeof(int));

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

        private bool sendAssignedProductToBatchDataToApi(string jsonBody)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:64191");
                RestRequest request = new RestRequest("/api/v1/integrarpaquetes", Method.Post);
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
                MessageBox.Show("Error al asignar un producto: " + ex.Message);
                return false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            jsonBody = "";

            if (!validateInputsUser())
            {
                MessageBox.Show("Por favor, completa todos los campos");
                return;
            }

            AssignProductsToBatchInterface batch = new AssignProductsToBatchInterface
            {
                IDProduct = Convert.ToInt32(txtBoxIDProduct.Text),
                IDBatch = Convert.ToInt32(txtBoxIDBatch.Text)
            };

            jsonBody = JsonConvert.SerializeObject(batch);

            if (sendAssignedProductToBatchDataToApi(jsonBody))
            {
                refreshTable();
                MessageBox.Show($"Producto {this.txtBoxIDProduct.Text} asignado exitosamente al lote {this.txtBoxIDBatch.Text}.");
                clearTxtBoxs();
            }
            else
            {
                MessageBox.Show("Error al asignado el producto. Por favor, verifica los datos ingresados.");
            }
        }

        #endregion postAssignedProductToAPI

        #region deleteAssignedProductToAPI

        private bool deleteAssignedProductToBatchFromApi(int assignedProductId)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:64191");
                RestRequest request = new RestRequest($"/api/v1/integrarpaquetes/{assignedProductId}", Method.Delete);
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
                MessageBox.Show("Error al eliminar el producto: " + ex.Message);
                return false;
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewAssignedProducts.SelectedRows.Count > 0)
            {
                int assignedProductIdToDelete = Convert.ToInt32(dataGridViewAssignedProducts.SelectedRows[0].Cells["ID Producto"].Value);

                if (deleteAssignedProductToBatchFromApi(assignedProductIdToDelete))
                {
                    refreshTable();
                    MessageBox.Show($"Producto asignado con ID {assignedProductIdToDelete} eliminado exitosamente.");
                    clearTxtBoxs();
                }
                else
                {
                    MessageBox.Show("Error al eliminar el producto. Por favor, verifica los datos ingresados.");
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar un producto asignado.");
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
