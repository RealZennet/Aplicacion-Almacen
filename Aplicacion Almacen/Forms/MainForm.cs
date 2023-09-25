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

        private void buttonStoreHouse_Click(object sender, EventArgs e)
        {
            showMenus(panelProductsAndBatchsContainer);
        }


    }
}
