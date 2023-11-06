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
    public partial class EmailForm : Form
    {

        public event Action LanguageChanged;

        public EmailForm()
        {
            InitializeComponent();
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += updateLanguage;
            }
        }

        private void buttonBackToMainMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateLanguage()
        {
            buttonSendEmail.Text = LanguageManager.GetString("SendEmail");
            buttonBackToMainMenu.Text = LanguageManager.GetString("Back");

            labelDestination.Text = LanguageManager.GetString("Destination");
            labelMessage.Text = LanguageManager.GetString("Message");

        }
    }
}
