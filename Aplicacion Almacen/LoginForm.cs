using Aplicacion_Almacen.ApiRequests;
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
        private readonly ApiRequestLogin authService;
        private int m, x, y;

        public LoginForm()
        {
            InitializeComponent();
            roundedCircleForm();
            authService = new ApiRequestLogin("http://localhost:52231");

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
            ApiResponse apiResponse = authService.Authenticate(textBox1.Text, textBox2.Text);

            if (apiResponse != null && apiResponse.resultado == "OK" && apiResponse.tipo == "operario")
            {
                MainForm mainForm = new MainForm(apiResponse);
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Error de autenticación");
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            try
            {
                ApiResponse apiResponse = authService.Authenticate(textBox1.Text, textBox2.Text);

                if (apiResponse == null)
                {
                    MessageBox.Show("Error de autenticación");
                }
                else if (apiResponse.resultado == "OK" && apiResponse.tipo == "operario")
                {
                    apiResponse.tipo = "operario";
                    openPrincipalForm();
                }
                else
                {
                    MessageBox.Show("Error de autenticación");
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
