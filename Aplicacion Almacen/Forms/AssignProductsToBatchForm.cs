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


    }
}
