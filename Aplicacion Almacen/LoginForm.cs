using Aplicacion_Almacen.Forms;
using Aplicacion_Almacen.Login;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Almacen
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

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

    }
}
