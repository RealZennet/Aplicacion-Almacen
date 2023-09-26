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
    public partial class ProductManagerSearcher : Form
    {
        public ProductManagerSearcher()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private RestResponse getProductByIdFromApi(int productId)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:64191");
                RestRequest request = new RestRequest($"/api/v1/productos/{productId}", Method.Get);
                request.AddHeader("Accept", "application/json");

                RestResponse response = client.Execute(request);
                return response;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener el producto por ID: " + ex.Message);
                return null;
            }
        }

        private void buttonSearchProductByID_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBoxID.Text, out int searchID))
            {
                RestResponse response = getProductByIdFromApi(searchID);

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("ID", typeof(int));
                    table.Columns.Add("Peso", typeof(string));
                    table.Columns.Add("Volumen", typeof(int));
                    table.Columns.Add("Calle", typeof(string));
                    table.Columns.Add("Numero Direccion", typeof(int));
                    table.Columns.Add("Esquina", typeof(string));
                    table.Columns.Add("Cliente", typeof(string));
                    table.Columns.Add("Activado", typeof(bool));

                    ProductInterface product = JsonConvert.DeserializeObject<ProductInterface>(response.Content);
                    fillDataTable(table, product);

                    dataGridViewSearcher.DataSource = table;

                    MessageBox.Show("Producto encontrado.");
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                }
            }
            else
            {
                MessageBox.Show("ID de producto inválido. Ingresa un número válido.");
            }
        }
    }
}
