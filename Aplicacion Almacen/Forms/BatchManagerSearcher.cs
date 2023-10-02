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
    public partial class BatchManagerSearcher : Form
    {

        public event Action LanguageChanged;
        public int m, x, y;

        public BatchManagerSearcher()
        {
            InitializeComponent();
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += UpdateLanguage;
            }
        }

        private void UpdateLanguage()
        {
            buttonSearchBatchByID.Text = LanguageManager.GetString("Search");
        }

        private void panelSlide_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            x = e.X;
            y = e.Y;
        }

        private void panelSlide_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void panelSlide_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSearchBatchByID_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxID.Text, out int searchID))
            {
                RestResponse response = getBatchByIdFromApi(searchID);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID", typeof(int));
                    table.Columns.Add(LanguageManager.GetString("DateOfCreation"), typeof(DateTime));
                    table.Columns.Add(LanguageManager.GetString("IDDestination"), typeof(int));
                    table.Columns.Add(LanguageManager.GetString("DateOfShipment"), typeof(DateTime));
                    table.Columns.Add(LanguageManager.GetString("Activated"), typeof(bool));

                    BatchInterface batch = JsonConvert.DeserializeObject<BatchInterface>(response.Content);
                    fillDataTable(table, batch);

                    dataGridViewSearcher.DataSource = table;

                    MessageBox.Show("Lote encontrado.");
                }
                else
                {
                    MessageBox.Show("Lote no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("ID de lote inválido. Ingresa un número válido.");
            }
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

        private RestResponse getBatchByIdFromApi(int batchId)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:64191");
                RestRequest request = new RestRequest($"/api/v1/lotes/{batchId}", Method.Get);
                request.AddHeader("Accept", "application/json");

                RestResponse response = client.Execute(request);
                return response;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el lote con ID: " + ex.Message);
                return null;
            }
        }


    }
}
