using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Almacen.Forms.crudForms
{
    public partial class AddProductForm : Form
    {
        public event Action LanguageChanged;
        private int x, y, m;

        public AddProductForm()
        {
            InitializeComponent();
            MainForm mainForm = Application.OpenForms.OfType<MainForm>().FirstOrDefault();
            if (mainForm != null)
            {
                mainForm.LanguageChanged += updateLanguage;
            }
            LanguageManager.Initialize(typeof(Languages.Resource_language_spanish));
            LanguageManager.Initialize(typeof(Languages.Resource_language_english));
            roundedCircleForm();

            comboBoxActivated.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxActivated.Items.Add("true");
            comboBoxActivated.Items.Add("false");
            comboBoxActivated.SelectedItem = "true";
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

        private void updateLanguage()
        {
            labelActivated.Text = LanguageManager.GetString("Activated");
            labelCorner.Text = LanguageManager.GetString("Corner");
            labelCustomer.Text = LanguageManager.GetString("Customer");
            labelNumber.Text = LanguageManager.GetString("Number");
            labelStreet.Text = LanguageManager.GetString("Street");
            labelVolume.Text = LanguageManager.GetString("Volume");
            labelWeight.Text = LanguageManager.GetString("Weight");
            buttonSave.Text = LanguageManager.GetString("Save");
            buttonCancel.Text = LanguageManager.GetString("Cancel");
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
