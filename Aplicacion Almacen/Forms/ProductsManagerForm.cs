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
    public partial class ProductsManagerForm : Form
    {
        public ProductsManagerForm()
        {
            InitializeComponent();
            RefreshTable();
            comboBoxActivated.Items.Add("true");
            comboBoxActivated.Items.Add("false");
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductsManagerForm_Load(object sender, EventArgs e)
        {

        }

        #region getProductsFromAPI
        private List<ProductInterface> deserializeProduct(string content)
        {
            return JsonConvert.DeserializeObject<List<ProductInterface>>(content);
        }

        private static RestResponse getProductsFromApi()
        {
            RestClient client = new RestClient("http://localhost:64191");
            RestRequest request = new RestRequest("/api/v1/productos", Method.Get);
            request.AddHeader("Accept", "application/json");
            RestResponse response = client.Execute(request);
            return response;
        }

        private static void fillDataTable(DataTable table, ProductInterface product)
        {
            DataRow rows = table.NewRow();
            rows["ID"] = product.IDProduct;
            rows["Peso"] = product.ProductWeight;
            rows["Volumen"] = product.Volume;
            rows["Calle"] = product.Street;
            rows["Numero Direccion"] = product.DoorNumber;
            rows["Esquina"] = product.Corner;
            rows["Cliente"] = product.Customer;
            rows["Activado"] = product.ActivatedProduct;
            table.Rows.Add(rows);
        }

        private DataTable getDataTable()
        {
            RestResponse response = getProductsFromApi();

            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Peso", typeof(string));
            table.Columns.Add("Volumen", typeof(int));
            table.Columns.Add("Calle", typeof(string));
            table.Columns.Add("Numero Direccion", typeof(int));
            table.Columns.Add("Esquina", typeof(string));
            table.Columns.Add("Cliente", typeof(string));
            table.Columns.Add("Activado", typeof(bool));

            foreach (ProductInterface product in deserializeProduct(response.Content))
            {
                fillDataTable(table, product);
            }

            return table;
        }

        private void RefreshTable()
        {
            DataTable table = getDataTable();
            dataGridViewProducts.DataSource = table;
        }
        #endregion getProductsFromAPI

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshTable();
        }
    }
}
