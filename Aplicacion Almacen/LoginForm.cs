using Aplicacion_Almacen.Forms;
using Aplicacion_Almacen.Login;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Almacen
{
    public partial class LoginForm : Form
    {

        private int m, x, y;

        public LoginForm()
        {
            InitializeComponent();
            roundedCircleForm();

        }

        private void roundedCircleForm()
        {
            int radiusBorder = 25;

            Rectangle rectangleBorder = new Rectangle(0, 0, this.Width, this.Height);

            GraphicsPath graphicBorder = new GraphicsPath();
            graphicBorder.AddArc(rectangleBorder.X, rectangleBorder.Y, radiusBorder, radiusBorder, 180, 90);
            graphicBorder.AddArc(rectangleBorder.Right - radiusBorder, rectangleBorder.Y, radiusBorder, radiusBorder, 270, 90);
            graphicBorder.AddArc(rectangleBorder.Right - radiusBorder, rectangleBorder.Bottom - radiusBorder, radiusBorder, radiusBorder, 0, 90);
            graphicBorder.AddArc(rectangleBorder.X, rectangleBorder.Bottom - radiusBorder, radiusBorder, radiusBorder, 90, 90);
            graphicBorder.CloseAllFigures();

            this.Region = new Region(graphicBorder);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private ApiResponse deserialize(string jsoncontent)
        {
            return JsonConvert.DeserializeObject<ApiResponse>(jsoncontent);
        }

        private void openPrincipalForm()
        {
            MainForm mainForm = new MainForm();
            mainForm.Show();
            this.Hide();
        }

        private RestResponse Authenticate()
        {
            ApiRequest requestBody = new ApiRequest()
            {
                Username = textBox1.Text,
                Password = textBox2.Text
            };

            string requestBodyJson = JsonConvert.SerializeObject(requestBody);

            RestClient client = new RestClient("http://localhost:52231");

            RestRequest request = new RestRequest("/api/v1/login", Method.Post);
            request.RequestFormat = DataFormat.Json;
            request.AddJsonBody(requestBodyJson);
            request.AddHeader("Accept", "application/json");
            request.AddHeader("Content-Type", "application/json");

            RestResponse response = client.Execute(request);
            return response;
        }


        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                RestResponse response = Authenticate();
                if (response.StatusCode == HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Login Invalido");
                }
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    ApiResponse apiResponse = this.deserialize(response.Content);
                    string result = apiResponse.resultado;
                    string tipo = apiResponse.tipo;

                    if (result == "OK" && tipo == "operario")
                    {
                        openPrincipalForm();
                    }
                    else
                    {
                        MessageBox.Show("Error de autenticacion");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void panelSlidePanelLoginForm_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void panelSlidePanelLoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void panelSlidePanelLoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                m = 1;
                x = e.X;
                y = e.Y;
            }
        }

        private void buttonCloseMainMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    }
}
