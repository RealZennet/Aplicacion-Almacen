﻿using Aplicacion_Almacen.Languages;
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
        public event Action LanguageChaned;
        public int m, x, y;

        public ProductManagerSearcher()
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
            buttonSearchProductByID.Text = LanguageManager.GetString("Search");
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductManagerSearcher_Load(object sender, EventArgs e)
        {

        }

        #region slidePanel

        private void panelSlide_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void panelSlide_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            x = e.X;
            y = e.Y;
        }

        #endregion slidePanel

        private static void fillDataTable(DataTable table, ProductInterface product)
        {
            DataRow rows = table.NewRow();
            rows["ID"] = product.IDProduct;
            rows[LanguageManager.GetString("Weight")] = product.ProductWeight;
            rows[LanguageManager.GetString("Volume")] = product.Volume;
            rows[LanguageManager.GetString("Street")] = product.Street;
            rows[LanguageManager.GetString("Number")] = product.DoorNumber;
            rows[LanguageManager.GetString("Corner")] = product.Corner;
            rows[LanguageManager.GetString("Customer")] = product.Customer;
            rows[LanguageManager.GetString("Activated")] = product.ActivatedProduct;
            table.Rows.Add(rows);
        }

        private void panelSlide_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void panelSlide_Paint(object sender, PaintEventArgs e)
        {

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
                MessageBox.Show(Messages.Error + " : " + ex.Message);
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
                    table.Columns.Add(LanguageManager.GetString("Weight"), typeof(string));
                    table.Columns.Add(LanguageManager.GetString("Volume"), typeof(int));
                    table.Columns.Add(LanguageManager.GetString("Street"), typeof(string));
                    table.Columns.Add(LanguageManager.GetString("Number"), typeof(int));
                    table.Columns.Add(LanguageManager.GetString("Corner"), typeof(string));
                    table.Columns.Add(LanguageManager.GetString("Customer"), typeof(string));
                    table.Columns.Add(LanguageManager.GetString("Activated"), typeof(bool));

                    ProductInterface product = JsonConvert.DeserializeObject<ProductInterface>(response.Content);
                    fillDataTable(table, product);

                    dataGridViewSearcher.DataSource = table;

                    MessageBox.Show(Messages.ProductFound);
                }
                else
                {
                    MessageBox.Show(Messages.ProductNotFound);
                }
            }
            else
            {
                MessageBox.Show(Messages.Error);
            }
        }


    }
}
