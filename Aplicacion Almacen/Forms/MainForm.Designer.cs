namespace Aplicacion_Almacen.Forms
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
            this.leftPanelContainer = new System.Windows.Forms.Panel();
            this.buttonStoreHouse = new System.Windows.Forms.Button();
            this.settingsManagerPanel = new System.Windows.Forms.Panel();
            this.buttonEnglishLanguage = new System.Windows.Forms.Button();
            this.buttonLanguageSpanish = new System.Windows.Forms.Button();
            this.panelProductsAndBatchsContainer = new System.Windows.Forms.Panel();
            this.buttonTruckerCarryBatch = new System.Windows.Forms.Button();
            this.buttonAssignProducts = new System.Windows.Forms.Button();
            this.buttonProductsManager = new System.Windows.Forms.Button();
            this.buttonBatchManager = new System.Windows.Forms.Button();
            this.panelFormsLoader = new System.Windows.Forms.Panel();
            this.panelSeparator = new System.Windows.Forms.Panel();
            this.labelWorkerName = new System.Windows.Forms.Label();
            this.labelUserJob = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.panelSlidePanelMainForm = new System.Windows.Forms.Panel();
            this.buttonCloseMainMenu = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelTotalBatchs = new System.Windows.Forms.Label();
            this.labelTotalProducts = new System.Windows.Forms.Label();
            this.leftPanelContainer.SuspendLayout();
            this.settingsManagerPanel.SuspendLayout();
            this.panelProductsAndBatchsContainer.SuspendLayout();
            this.panelFormsLoader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // settingsManagerPanel
            // 
            this.settingsManagerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.settingsManagerPanel.Controls.Add(this.buttonEnglishLanguage);
            this.settingsManagerPanel.Controls.Add(this.buttonLanguageSpanish);
            this.settingsManagerPanel.Location = new System.Drawing.Point(0, 501);
            this.settingsManagerPanel.Name = "settingsManagerPanel";
            this.settingsManagerPanel.Size = new System.Drawing.Size(250, 67);
            this.settingsManagerPanel.TabIndex = 1;
            // 
            // buttonEnglishLanguage
            // 
            this.buttonEnglishLanguage.FlatAppearance.BorderSize = 0;
            this.buttonEnglishLanguage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEnglishLanguage.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonEnglishLanguage.Location = new System.Drawing.Point(0, 3);
            this.buttonEnglishLanguage.Name = "buttonEnglishLanguage";
            this.buttonEnglishLanguage.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonEnglishLanguage.Size = new System.Drawing.Size(244, 29);
            this.buttonEnglishLanguage.TabIndex = 5;
            this.buttonEnglishLanguage.Text = "English";
            this.buttonEnglishLanguage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonEnglishLanguage.UseVisualStyleBackColor = true;
            this.buttonEnglishLanguage.Click += new System.EventHandler(this.buttonEnglishLanguage_Click);
            // 
            // buttonLanguageSpanish
            // 
            this.buttonLanguageSpanish.FlatAppearance.BorderSize = 0;
            this.buttonLanguageSpanish.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLanguageSpanish.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonLanguageSpanish.Location = new System.Drawing.Point(0, 35);
            this.buttonLanguageSpanish.Name = "buttonLanguageSpanish";
            this.buttonLanguageSpanish.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonLanguageSpanish.Size = new System.Drawing.Size(244, 29);
            this.buttonLanguageSpanish.TabIndex = 4;
            this.buttonLanguageSpanish.Text = "Spanish";
            this.buttonLanguageSpanish.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonLanguageSpanish.UseVisualStyleBackColor = true;
            this.buttonLanguageSpanish.Click += new System.EventHandler(this.buttonLanguageSpanish_Click);
            // 
            // panelProductsAndBatchsContainer
            // 
            this.panelProductsAndBatchsContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(96)))));
            this.panelProductsAndBatchsContainer.Controls.Add(this.buttonTruckerCarryBatch);
            this.panelProductsAndBatchsContainer.Controls.Add(this.buttonAssignProducts);
            this.panelProductsAndBatchsContainer.Controls.Add(this.buttonProductsManager);
            this.panelProductsAndBatchsContainer.Controls.Add(this.buttonBatchManager);
            this.panelProductsAndBatchsContainer.Location = new System.Drawing.Point(0, 131);
            this.panelProductsAndBatchsContainer.Name = "panelProductsAndBatchsContainer";
            this.panelProductsAndBatchsContainer.Size = new System.Drawing.Size(250, 135);
            this.panelProductsAndBatchsContainer.TabIndex = 0;
            // 
            // buttonTruckerCarryBatch
            // 
            this.buttonTruckerCarryBatch.FlatAppearance.BorderSize = 0;
            this.buttonTruckerCarryBatch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTruckerCarryBatch.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTruckerCarryBatch.Location = new System.Drawing.Point(0, 103);
            this.buttonTruckerCarryBatch.Name = "buttonTruckerCarryBatch";
            this.buttonTruckerCarryBatch.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.buttonTruckerCarryBatch.Size = new System.Drawing.Size(240, 26);
            this.buttonTruckerCarryBatch.TabIndex = 6;
            this.buttonTruckerCarryBatch.Text = "Asignar lote a camionero";
            this.buttonTruckerCarryBatch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTruckerCarryBatch.UseVisualStyleBackColor = true;
            this.buttonTruckerCarryBatch.Click += new System.EventHandler(this.buttonTruckerCarryBatch_Click);
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
            this.buttonAssignProducts.Click += new System.EventHandler(this.buttonAssignProducts_Click);
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
            this.buttonProductsManager.Click += new System.EventHandler(this.buttonProductsManager_Click);
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
            this.buttonBatchManager.Click += new System.EventHandler(this.buttonBatchManager_Click);
            // 
            // panelFormsLoader
            // 
            this.panelFormsLoader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelFormsLoader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.panelFormsLoader.Controls.Add(this.labelTotalProducts);
            this.panelFormsLoader.Controls.Add(this.labelTotalBatchs);
            this.panelFormsLoader.Controls.Add(this.pictureBox3);
            this.panelFormsLoader.Controls.Add(this.panelSeparator);
            this.panelFormsLoader.Controls.Add(this.labelWorkerName);
            this.panelFormsLoader.Controls.Add(this.labelUserJob);
            this.panelFormsLoader.Controls.Add(this.labelUser);
            this.panelFormsLoader.Controls.Add(this.pictureBox2);
            this.panelFormsLoader.Controls.Add(this.labelUserID);
            this.panelFormsLoader.Location = new System.Drawing.Point(256, 41);
            this.panelFormsLoader.Name = "panelFormsLoader";
            this.panelFormsLoader.Size = new System.Drawing.Size(773, 559);
            this.panelFormsLoader.TabIndex = 3;
            // 
            // panelSeparator
            // 
            this.panelSeparator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(84)))), ((int)(((byte)(112)))));
            this.panelSeparator.Location = new System.Drawing.Point(385, 1);
            this.panelSeparator.Name = "panelSeparator";
            this.panelSeparator.Size = new System.Drawing.Size(3, 524);
            this.panelSeparator.TabIndex = 82;
            // 
            // labelWorkerName
            // 
            this.labelWorkerName.AutoSize = true;
            this.labelWorkerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkerName.Location = new System.Drawing.Point(34, 205);
            this.labelWorkerName.Name = "labelWorkerName";
            this.labelWorkerName.Size = new System.Drawing.Size(69, 20);
            this.labelWorkerName.TabIndex = 4;
            this.labelWorkerName.Text = "Nombre:";
            // 
            // labelUserJob
            // 
            this.labelUserJob.AutoSize = true;
            this.labelUserJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserJob.Location = new System.Drawing.Point(34, 240);
            this.labelUserJob.Name = "labelUserJob";
            this.labelUserJob.Size = new System.Drawing.Size(60, 20);
            this.labelUserJob.TabIndex = 3;
            this.labelUserJob.Text = "Sector:";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelUser.Location = new System.Drawing.Point(129, 15);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(74, 24);
            this.labelUser.TabIndex = 2;
            this.labelUser.Text = "Usuario";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.Location = new System.Drawing.Point(34, 167);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(30, 20);
            this.labelUserID.TabIndex = 0;
            this.labelUserID.Text = "ID:";
            // 
            // panelSlidePanelMainForm
            // 
            this.panelSlidePanelMainForm.Location = new System.Drawing.Point(256, 0);
            this.panelSlidePanelMainForm.Name = "panelSlidePanelMainForm";
            this.panelSlidePanelMainForm.Size = new System.Drawing.Size(671, 35);
            this.panelSlidePanelMainForm.TabIndex = 4;
            this.panelSlidePanelMainForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelSlidePanelMainForm_MouseDown);
            this.panelSlidePanelMainForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelSlidePanelMainForm_MouseMove);
            this.panelSlidePanelMainForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelSlidePanelMainForm_MouseUp);
            // 
            // buttonCloseMainMenu
            // 
            this.buttonCloseMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseMainMenu.ForeColor = System.Drawing.Color.Olive;
            this.buttonCloseMainMenu.Location = new System.Drawing.Point(963, 9);
            this.buttonCloseMainMenu.Name = "buttonCloseMainMenu";
            this.buttonCloseMainMenu.Size = new System.Drawing.Size(20, 23);
            this.buttonCloseMainMenu.TabIndex = 57;
            this.buttonCloseMainMenu.Text = "X";
            this.buttonCloseMainMenu.UseVisualStyleBackColor = true;
            this.buttonCloseMainMenu.Click += new System.EventHandler(this.buttonCloseMainMenu_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.ForeColor = System.Drawing.Color.Olive;
            this.buttonMinimize.Location = new System.Drawing.Point(989, 9);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(20, 23);
            this.buttonMinimize.TabIndex = 58;
            this.buttonMinimize.Text = "_";
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Aplicacion_Almacen.Properties.Resources.png_clipart_logistics_computer_icons_freight_transport_logistics_computer_icons_removebg_preview;
            this.pictureBox3.Location = new System.Drawing.Point(509, 39);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(124, 113);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 83;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Aplicacion_Almacen.Properties.Resources.usuario;
            this.pictureBox2.Location = new System.Drawing.Point(112, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(113, 110);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
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
            // labelTotalBatchs
            // 
            this.labelTotalBatchs.AutoSize = true;
            this.labelTotalBatchs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalBatchs.Location = new System.Drawing.Point(422, 167);
            this.labelTotalBatchs.Name = "labelTotalBatchs";
            this.labelTotalBatchs.Size = new System.Drawing.Size(109, 20);
            this.labelTotalBatchs.TabIndex = 84;
            this.labelTotalBatchs.Text = "Lotes Totales:";
            // 
            // labelTotalProducts
            // 
            this.labelTotalProducts.AutoSize = true;
            this.labelTotalProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalProducts.Location = new System.Drawing.Point(422, 205);
            this.labelTotalProducts.Name = "labelTotalProducts";
            this.labelTotalProducts.Size = new System.Drawing.Size(141, 20);
            this.labelTotalProducts.TabIndex = 85;
            this.labelTotalProducts.Text = "Productos Totales:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(1021, 568);
            this.Controls.Add(this.buttonMinimize);
            this.Controls.Add(this.buttonCloseMainMenu);
            this.Controls.Add(this.panelSlidePanelMainForm);
            this.Controls.Add(this.panelFormsLoader);
            this.Controls.Add(this.leftPanelContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Aplicacion Almacen";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.leftPanelContainer.ResumeLayout(false);
            this.settingsManagerPanel.ResumeLayout(false);
            this.panelProductsAndBatchsContainer.ResumeLayout(false);
            this.panelFormsLoader.ResumeLayout(false);
            this.panelFormsLoader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel leftPanelContainer;
        private System.Windows.Forms.Button buttonStoreHouse;
        private System.Windows.Forms.Panel settingsManagerPanel;
        private System.Windows.Forms.Button buttonLanguageSpanish;
        private System.Windows.Forms.Panel panelProductsAndBatchsContainer;
        private System.Windows.Forms.Button buttonAssignProducts;
        private System.Windows.Forms.Button buttonProductsManager;
        private System.Windows.Forms.Button buttonBatchManager;
        private System.Windows.Forms.Panel panelFormsLoader;
        private System.Windows.Forms.Button buttonTruckerCarryBatch;
        private System.Windows.Forms.Button buttonEnglishLanguage;
        private System.Windows.Forms.Panel panelSlidePanelMainForm;
        private System.Windows.Forms.Button buttonCloseMainMenu;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelUserJob;
        private System.Windows.Forms.Label labelWorkerName;
        private System.Windows.Forms.Panel panelSeparator;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelTotalBatchs;
        private System.Windows.Forms.Label labelTotalProducts;
    }
}