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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            customMenus();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void customMenus()
        {
            panelProductsAndBatchsContainer.Visible = false;
        }

        private void hideMenus()
        {
            if (panelProductsAndBatchsContainer.Visible == true)
            {
                panelProductsAndBatchsContainer.Visible = false;
            }
        }

        private void showMenus(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private Form currentForm = null;

        private void showForm(Form newForm)
        {
            if (currentForm != null)
            {
                panelFormsLoader.Controls.Remove(currentForm);
                currentForm.Dispose();
            }

            currentForm = newForm;
            newForm.TopLevel = false;
            panelFormsLoader.Controls.Add(newForm);
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            panelFormsLoader.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
        }

        private void showProductsForm()
        {
            ProductsManagerForm formProductCtl = new ProductsManagerForm();
            showForm(formProductCtl);
        }

        private void showBatchForm()
        {
            BatchManagerForm formBatchCtl = new BatchManagerForm();
            showForm(formBatchCtl);
        }

        private void showAssignProductToBatchForm()
        {
            AssignProductsToBatchForm formAssignProducttoBatchCtl = new AssignProductsToBatchForm();
            showForm(formAssignProducttoBatchCtl);
        }


        private void buttonStoreHouse_Click(object sender, EventArgs e)
        {
            showMenus(panelProductsAndBatchsContainer);
        }

        private void buttonProductsManager_Click(object sender, EventArgs e)
        {
            showProductsForm();
        }

        private void buttonBatchManager_Click(object sender, EventArgs e)
        {
            showBatchForm();
        }

        private void buttonAssignProducts_Click(object sender, EventArgs e)
        {
            showAssignProductToBatchForm();
        }
    }
}
