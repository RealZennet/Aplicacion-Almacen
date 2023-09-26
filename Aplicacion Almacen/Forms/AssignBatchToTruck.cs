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
    public partial class AssignBatchToTruck : Form
    {
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
            rows["ID"] = assignedBatch.IDBatch;
            rows["ID Camion"] = assignedBatch.IDTruck;
            rows["Fecha Entrega"] = assignedBatch.ShippDate;
            table.Rows.Add(rows);
        }

        private DataTable getDataTable()
        {
            RestResponse response = getBatchsFromApi();

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("ID Camion", typeof(int));
            table.Columns.Add("Fecha Entrega", typeof(DateTime));

            foreach (AssignedBatchToTruckInterface batchAssigned in deserializeAssignedBatch(response.Content))
            {
                fillDataTable(table, batchAssigned);
            }

            return table;
        }

        #endregion getAssignedBatchFromAPi

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
        #endregion utils
    }
}
