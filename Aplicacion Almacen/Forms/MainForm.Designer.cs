﻿namespace Aplicacion_Almacen.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.leftPanelContainer = new System.Windows.Forms.Panel();
            this.settingsManagerPanel = new System.Windows.Forms.Panel();
            this.buttonBatchManager = new System.Windows.Forms.Button();
            this.buttonProductsManager = new System.Windows.Forms.Button();
            this.buttonAssignProducts = new System.Windows.Forms.Button();
            this.panelProductsAndBatchsContainer = new System.Windows.Forms.Panel();
            this.buttonStoreHouse = new System.Windows.Forms.Button();
            this.buttonLanguage = new System.Windows.Forms.Button();
            this.panelFormsLoader = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.leftPanelContainer.SuspendLayout();
            this.settingsManagerPanel.SuspendLayout();
            this.panelProductsAndBatchsContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = global::Aplicacion_Almacen.Properties.Resources.ZENNETLOGO;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // leftPanelContainer
            // 
            this.leftPanelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            this.leftPanelContainer.Controls.Add(this.buttonStoreHouse);
            this.leftPanelContainer.Controls.Add(this.settingsManagerPanel);
            this.leftPanelContainer.Controls.Add(this.pictureBox1);
            this.leftPanelContainer.Controls.Add(this.panelProductsAndBatchsContainer);
            this.leftPanelContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanelContainer.Location = new System.Drawing.Point(0, 0);
            this.leftPanelContainer.Name = "leftPanelContainer";
            this.leftPanelContainer.Size = new System.Drawing.Size(250, 568);
            this.leftPanelContainer.TabIndex = 0;
            // 
            // settingsManagerPanel
            // 
            this.settingsManagerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.settingsManagerPanel.Controls.Add(this.buttonLanguage);
            this.settingsManagerPanel.Location = new System.Drawing.Point(0, 525);
            this.settingsManagerPanel.Name = "settingsManagerPanel";
            this.settingsManagerPanel.Size = new System.Drawing.Size(250, 43);
            this.settingsManagerPanel.TabIndex = 1;
            // 
            // buttonBatchManager
            // 
            this.buttonBatchManager.FlatAppearance.BorderSize = 0;
            this.buttonBatchManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBatchManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonBatchManager.Location = new System.Drawing.Point(0, 39);
            this.buttonBatchManager.Name = "buttonBatchManager";
            this.buttonBatchManager.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonBatchManager.Size = new System.Drawing.Size(240, 26);
            this.buttonBatchManager.TabIndex = 4;
            this.buttonBatchManager.Text = "Gestionar Lotes";
            this.buttonBatchManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBatchManager.UseVisualStyleBackColor = true;
            // 
            // buttonProductsManager
            // 
            this.buttonProductsManager.FlatAppearance.BorderSize = 0;
            this.buttonProductsManager.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProductsManager.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonProductsManager.Location = new System.Drawing.Point(0, 4);
            this.buttonProductsManager.Name = "buttonProductsManager";
            this.buttonProductsManager.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonProductsManager.Size = new System.Drawing.Size(240, 29);
            this.buttonProductsManager.TabIndex = 3;
            this.buttonProductsManager.Text = "Gestionar Productos";
            this.buttonProductsManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonProductsManager.UseVisualStyleBackColor = true;
            // 
            // buttonAssignProducts
            // 
            this.buttonAssignProducts.FlatAppearance.BorderSize = 0;
            this.buttonAssignProducts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAssignProducts.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonAssignProducts.Location = new System.Drawing.Point(0, 71);
            this.buttonAssignProducts.Name = "buttonAssignProducts";
            this.buttonAssignProducts.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonAssignProducts.Size = new System.Drawing.Size(240, 26);
            this.buttonAssignProducts.TabIndex = 5;
            this.buttonAssignProducts.Text = "Asignar Productos";
            this.buttonAssignProducts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAssignProducts.UseVisualStyleBackColor = true;
            // 
            // panelProductsAndBatchsContainer
            // 
            this.panelProductsAndBatchsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.panelProductsAndBatchsContainer.Controls.Add(this.buttonAssignProducts);
            this.panelProductsAndBatchsContainer.Controls.Add(this.buttonProductsManager);
            this.panelProductsAndBatchsContainer.Controls.Add(this.buttonBatchManager);
            this.panelProductsAndBatchsContainer.Location = new System.Drawing.Point(0, 131);
            this.panelProductsAndBatchsContainer.Name = "panelProductsAndBatchsContainer";
            this.panelProductsAndBatchsContainer.Size = new System.Drawing.Size(250, 99);
            this.panelProductsAndBatchsContainer.TabIndex = 0;
            // 
            // buttonStoreHouse
            // 
            this.buttonStoreHouse.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonStoreHouse.FlatAppearance.BorderSize = 0;
            this.buttonStoreHouse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStoreHouse.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonStoreHouse.Location = new System.Drawing.Point(0, 80);
            this.buttonStoreHouse.Name = "buttonStoreHouse";
            this.buttonStoreHouse.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonStoreHouse.Size = new System.Drawing.Size(250, 45);
            this.buttonStoreHouse.TabIndex = 2;
            this.buttonStoreHouse.Text = "Distribucion de productos y lotes";
            this.buttonStoreHouse.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStoreHouse.UseVisualStyleBackColor = true;
            this.buttonStoreHouse.Click += new System.EventHandler(this.buttonStoreHouse_Click);
            // 
            // buttonLanguage
            // 
            this.buttonLanguage.FlatAppearance.BorderSize = 0;
            this.buttonLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLanguage.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLanguage.Location = new System.Drawing.Point(3, 3);
            this.buttonLanguage.Name = "buttonLanguage";
            this.buttonLanguage.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonLanguage.Size = new System.Drawing.Size(244, 29);
            this.buttonLanguage.TabIndex = 4;
            this.buttonLanguage.Text = "Idiomas";
            this.buttonLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLanguage.UseVisualStyleBackColor = true;
            // 
            // panelFormsLoader
            // 
            this.panelFormsLoader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelFormsLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.panelFormsLoader.Location = new System.Drawing.Point(256, 41);
            this.panelFormsLoader.Name = "panelFormsLoader";
            this.panelFormsLoader.Size = new System.Drawing.Size(773, 559);
            this.panelFormsLoader.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1021, 568);
            this.Controls.Add(this.panelFormsLoader);
            this.Controls.Add(this.leftPanelContainer);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.leftPanelContainer.ResumeLayout(false);
            this.settingsManagerPanel.ResumeLayout(false);
            this.panelProductsAndBatchsContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel leftPanelContainer;
        private System.Windows.Forms.Button buttonStoreHouse;
        private System.Windows.Forms.Panel settingsManagerPanel;
        private System.Windows.Forms.Button buttonLanguage;
        private System.Windows.Forms.Panel panelProductsAndBatchsContainer;
        private System.Windows.Forms.Button buttonAssignProducts;
        private System.Windows.Forms.Button buttonProductsManager;
        private System.Windows.Forms.Button buttonBatchManager;
        private System.Windows.Forms.Panel panelFormsLoader;
    }
}