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
        public BatchManagerForm()
        {
            InitializeComponent();
            RefreshTable();
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

        private void RefreshTable()
        {
            DataTable table = getDataTable();
            dataGridViewBatch.DataSource = table;
        }
        #endregion getBatchsFromAPI
    }
}
