﻿using Aplicacion_Almacen.APIRequests;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplicacion_Almacen.Forms.crudForms
{
    public partial class EditProductForm : Form
    {

        private ApiRequestProduct apiRequests;
        private string jsonBody;
        public event Action LanguageChanged;
        private int x, y, m;

        public EditProductForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelSlide_MouseUp(object sender, MouseEventArgs e)
        {
            m = 0;
        }

        private void panelSlide_MouseDown(object sender, MouseEventArgs e)
        {
            m = 1;
            x = e.X;
            y = e.Y;
        }

        private void panelSlide_MouseMove(object sender, MouseEventArgs e)
        {
            if (m == 1)
            {
                this.SetDesktopLocation(MousePosition.X - x, MousePosition.Y - y);
            }
        }
    }
}
