using Aplicacion_Almacen.Login;
using Aplicacion_Almacen.Properties;
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

namespace Aplicacion_Almacen.Forms
{
    public partial class MainForm : Form
    {
        private int m, x, y;
        public event Action LanguageChanged;
        private ApiResponse userApiResponse;
        private ApiRequest userInfo;

        public MainForm(ApiResponse userData, ApiRequest usernameInfo)
        {
            InitializeComponent();
            roundedCircleForm();
            LanguageManager.Initialize(typeof(Languages.Resource_language_spanish));
            UpdateUI();
            customMenus();
            userApiResponse = userData;
            userInfo = usernameInfo;
            getUserData();
        }

        private void getUserData()
        {
            labelUserID.Text = $"ID: {userApiResponse.id}";
            labelUserJob.Text = $"Puesto: {userApiResponse.tipo}";
            labelWorkerName.Text = $"{userInfo.Username}";
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


        private void showAssignedBatchToTruckForm()
        {
            AssignBatchToTruckForm formAssignBatchToTruckCtl = new AssignBatchToTruckForm();
            showForm(formAssignBatchToTruckCtl);
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

        private void buttonTruckerCarryBatch_Click(object sender, EventArgs e)
        {
            showAssignedBatchToTruckForm();
        }

        private void buttonEnglishLanguage_Click(object sender, EventArgs e)
        {
            LanguageManager.Initialize(typeof(Languages.Resource_language_english));
            UpdateUI();

            LanguageChanged?.Invoke();
        }

        private void buttonLanguageSpanish_Click(object sender, EventArgs e)
        {
            LanguageManager.Initialize(typeof(Languages.Resource_language_spanish));
            UpdateUI();
            LanguageChanged?.Invoke();
        }

        private void UpdateUI()
        {
            MainForm.ActiveForm.Text = LanguageManager.GetString("AppStoreHouseTitle");
            buttonStoreHouse.Text = LanguageManager.GetString("ProductAndLotDistribution");
            buttonAssignProducts.Text = LanguageManager.GetString("AssignProducts");
            buttonProductsManager.Text = LanguageManager.GetString("ManageProducts");
            buttonBatchManager.Text = LanguageManager.GetString("ManageLots");
            buttonTruckerCarryBatch.Text = LanguageManager.GetString("AssignLotToTrucker");
        }

        private void buttonCloseMainMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelSlidePanelMainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }

        private void panelSlidePanelMainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                m = 1;
                x = e.X;
                y = e.Y;
            }
        }

        private void panelSlidePanelMainForm_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }
    }
}