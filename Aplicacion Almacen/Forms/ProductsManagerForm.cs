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

        public event Action LanguageChanged;
        private string jsonBody;

        public ProductsManagerForm()
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
            buttonEdit.Text = LanguageManager.GetString("Edit");
            buttonDelete.Text = LanguageManager.GetString("Delete");
            buttonRefresh.Text = LanguageManager.GetString("Refresh");
            buttonBackToMainMenu.Text = LanguageManager.GetString("Back");
            buttonSearchByID.Text = LanguageManager.GetString("Searcher");

            labelActivated.Text = LanguageManager.GetString("Activated");
            labelCorner.Text = LanguageManager.GetString("Corner");
            labelCustomer.Text = LanguageManager.GetString("Customer");
            labelNumber.Text = LanguageManager.GetString("Number");
            labelStreet.Text = LanguageManager.GetString("Street");
            labelVolume.Text = LanguageManager.GetString("Volume");
            labelWeight.Text = LanguageManager.GetString("Weight");
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
            if (content == null)
            {
                return null;
            }
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

        private void refreshTable()
        {
            DataTable table = getDataTable();
            dataGridViewProducts.DataSource = table;
        }
        #endregion getProductsFromAPI

        #region postProductsToAPI

        private bool sendProductDataToApi(string jsonBody)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:64191");
                RestRequest request = new RestRequest("/api/v1/productos", Method.Post);
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
                MessageBox.Show("Error al agregar el producto: " + ex.Message);
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
                MessageBox.Show("Por favor, completa todos los campos y selecciona el estado del producto.");
                return;
            }

            ProductInterface product = new ProductInterface
            {
                ProductWeight = Convert.ToInt32(txtBoxWeight.Text),
                Volume = Convert.ToInt32(txtBoxVolume.Text),
                Street = txtBoxStreet.Text,
                DoorNumber = Convert.ToInt32(txtBoxNumber.Text),
                Corner = txtBoxCorner.Text,
                Customer = txtBoxClient.Text,
                ActivatedProduct = Convert.ToBoolean(statusValue)
            };

            jsonBody = JsonConvert.SerializeObject(product);

            if (sendProductDataToApi(jsonBody))
            {
                refreshTable();
                MessageBox.Show("Producto agregado exitosamente.");
                clearTxtBoxs();
            }
            else
            {
                MessageBox.Show("Error al agregar el producto. Por favor, verifica los datos ingresados.");
            }
        }

        #endregion postProductsToAPI

        #region putProductsToAPI


        private bool editProductInApi(string jsonBody)
        {
            try
            {
                int productIdToEdit = JsonConvert.DeserializeObject<ProductInterface>(jsonBody).IDProduct;

                RestClient client = new RestClient("http://localhost:64191");
                RestRequest request = new RestRequest($"/api/v1/productos/{productIdToEdit}", Method.Put);
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
                MessageBox.Show("Error al editar el producto: " + ex.Message);
                return false;
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            jsonBody = "";

            if (string.IsNullOrEmpty(textBoxID.Text))
            {
                MessageBox.Show("Por favor, selecciona una fila para editar un producto.");
                return;
            }

            int productIdToEdit = Convert.ToInt32(textBoxID.Text);

            if (!validateInputsUser())
            {
                MessageBox.Show("Por favor, completa todos los campos y selecciona el estado del producto.");
                return;
            }

            string selectedStatus = comboBoxActivated.SelectedItem as string;
            int statusValue = selectedStatus == "true" ? 1 : 0;

            ProductInterface product = productFromTxtBox(productIdToEdit, statusValue);

            jsonBody = JsonConvert.SerializeObject(product);

            if (editProductInApi(jsonBody))
            {
                refreshTable();
                MessageBox.Show("Producto editado exitosamente.");
                clearTxtBoxs();
            }
            else
            {
                MessageBox.Show("Error al editar el producto. Por favor, verifica los datos ingresados.");
            }

        }

        private ProductInterface productFromTxtBox(int productIdToEdit, int statusValue)
        {
            return new ProductInterface
            {
                IDProduct = productIdToEdit,
                ProductWeight = Convert.ToInt32(txtBoxWeight.Text),
                Volume = Convert.ToInt32(txtBoxVolume.Text),
                Street = txtBoxStreet.Text,
                DoorNumber = Convert.ToInt32(txtBoxNumber.Text),
                Corner = txtBoxCorner.Text,
                Customer = txtBoxClient.Text,
                ActivatedProduct = Convert.ToBoolean(statusValue)
            };
        }

        #endregion putProductsToAPI

        #region deleteProductsFromAPI

        private bool deleteProductFromApi(int productId)
        {
            try
            {
                RestClient client = new RestClient("http://localhost:64191");
                RestRequest request = new RestRequest($"/api/v1/productos/{productId}", Method.Delete);
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
            if (string.IsNullOrEmpty(textBoxID.Text))
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar un producto.");
                return;
            }

            int productIdToDelete = Convert.ToInt32(textBoxID.Text);

            if (deleteProductFromApi(productIdToDelete))
            {
                refreshTable();
                MessageBox.Show("Producto eliminado exitosamente.");
                clearTxtBoxs();
            }
            else
            {
                MessageBox.Show("Error al eliminar el producto. Por favor, verifica los datos ingresados.");
            }
        }

        #endregion deleteProductsFromAPI

        #region validationsAndUtils
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private bool validateInputsUser()
        {

            if (string.IsNullOrWhiteSpace(txtBoxWeight.Text) ||
                string.IsNullOrWhiteSpace(txtBoxVolume.Text) ||
                string.IsNullOrWhiteSpace(txtBoxStreet.Text) ||
                string.IsNullOrWhiteSpace(txtBoxNumber.Text) ||
                string.IsNullOrWhiteSpace(txtBoxCorner.Text) ||
                string.IsNullOrWhiteSpace(txtBoxClient.Text))
            {
                return false;
            }

            return true;
        }

        private void clearTxtBoxs()
        {
            txtBoxWeight.Clear();
            txtBoxVolume.Clear();
            txtBoxStreet.Clear();
            txtBoxNumber.Clear();
            txtBoxCorner.Clear();
            txtBoxClient.Clear();
            textBoxID.Clear();
        }

        private void dataGridViewProducts_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count > 0)
            {

                int productIdFromDataGrid = Convert.ToInt32(dataGridViewProducts.SelectedRows[0].Cells["ID"].Value);
                textBoxID.Text = productIdFromDataGrid.ToString();
            }
        }
        #endregion validationsAndUtils

        #region searcher
        private void buttonSearchByID_Click(object sender, EventArgs e)
        {
            ProductManagerSearcher searcherForm = new ProductManagerSearcher();
            searcherForm.Show();
        }
        #endregion searcher
    }

}
