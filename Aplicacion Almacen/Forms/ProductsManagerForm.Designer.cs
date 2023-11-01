namespace Aplicacion_Almacen.Forms
{
    partial class ProductsManagerForm
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
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.buttonSearchByID = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.comboBoxActivated = new System.Windows.Forms.ComboBox();
            this.labelCustomer = new System.Windows.Forms.Label();
            this.txtBoxClient = new System.Windows.Forms.TextBox();
            this.labelCorner = new System.Windows.Forms.Label();
            this.labelNumber = new System.Windows.Forms.Label();
            this.labelStreet = new System.Windows.Forms.Label();
            this.labelActivated = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.labelWeight = new System.Windows.Forms.Label();
            this.txtBoxCorner = new System.Windows.Forms.TextBox();
            this.txtBoxNumber = new System.Windows.Forms.TextBox();
            this.txtBoxStreet = new System.Windows.Forms.TextBox();
            this.txtBoxVolume = new System.Windows.Forms.TextBox();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.txtBoxWeight = new System.Windows.Forms.TextBox();
            this.buttonViewMap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMainMenu.ForeColor = System.Drawing.Color.Olive;
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(13, 13);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(113, 23);
            this.buttonBackToMainMenu.TabIndex = 0;
            this.buttonBackToMainMenu.Text = "Volver";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.GridColor = System.Drawing.Color.Maroon;
            this.dataGridViewProducts.Location = new System.Drawing.Point(13, 42);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(732, 248);
            this.dataGridViewProducts.TabIndex = 1;
            this.dataGridViewProducts.SelectionChanged += new System.EventHandler(this.dataGridViewProducts_SelectionChanged);
            // 
            // buttonSearchByID
            // 
            this.buttonSearchByID.Location = new System.Drawing.Point(670, 485);
            this.buttonSearchByID.Name = "buttonSearchByID";
            this.buttonSearchByID.Size = new System.Drawing.Size(75, 23);
            this.buttonSearchByID.TabIndex = 43;
            this.buttonSearchByID.Text = "Buscador";
            this.buttonSearchByID.UseVisualStyleBackColor = true;
            this.buttonSearchByID.Click += new System.EventHandler(this.buttonSearchByID_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(281, 307);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(18, 13);
            this.labelID.TabIndex = 42;
            this.labelID.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.textBoxID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxID.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxID.Location = new System.Drawing.Point(284, 326);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(75, 23);
            this.textBoxID.TabIndex = 41;
            // 
            // comboBoxActivated
            // 
            this.comboBoxActivated.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxActivated.FormattingEnabled = true;
            this.comboBoxActivated.Location = new System.Drawing.Point(12, 420);
            this.comboBoxActivated.Name = "comboBoxActivated";
            this.comboBoxActivated.Size = new System.Drawing.Size(92, 24);
            this.comboBoxActivated.TabIndex = 40;
            // 
            // labelCustomer
            // 
            this.labelCustomer.AutoSize = true;
            this.labelCustomer.Location = new System.Drawing.Point(157, 444);
            this.labelCustomer.Name = "labelCustomer";
            this.labelCustomer.Size = new System.Drawing.Size(39, 13);
            this.labelCustomer.TabIndex = 39;
            this.labelCustomer.Text = "Cliente";
            // 
            // txtBoxClient
            // 
            this.txtBoxClient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.txtBoxClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxClient.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxClient.Location = new System.Drawing.Point(160, 460);
            this.txtBoxClient.Name = "txtBoxClient";
            this.txtBoxClient.Size = new System.Drawing.Size(92, 23);
            this.txtBoxClient.TabIndex = 38;
            // 
            // labelCorner
            // 
            this.labelCorner.AutoSize = true;
            this.labelCorner.Location = new System.Drawing.Point(157, 393);
            this.labelCorner.Name = "labelCorner";
            this.labelCorner.Size = new System.Drawing.Size(45, 13);
            this.labelCorner.TabIndex = 37;
            this.labelCorner.Text = "Esquina";
            // 
            // labelNumber
            // 
            this.labelNumber.AutoSize = true;
            this.labelNumber.Location = new System.Drawing.Point(157, 352);
            this.labelNumber.Name = "labelNumber";
            this.labelNumber.Size = new System.Drawing.Size(44, 13);
            this.labelNumber.TabIndex = 36;
            this.labelNumber.Text = "Numero";
            // 
            // labelStreet
            // 
            this.labelStreet.AutoSize = true;
            this.labelStreet.Location = new System.Drawing.Point(157, 307);
            this.labelStreet.Name = "labelStreet";
            this.labelStreet.Size = new System.Drawing.Size(30, 13);
            this.labelStreet.TabIndex = 35;
            this.labelStreet.Text = "Calle";
            // 
            // labelActivated
            // 
            this.labelActivated.AutoSize = true;
            this.labelActivated.Location = new System.Drawing.Point(9, 393);
            this.labelActivated.Name = "labelActivated";
            this.labelActivated.Size = new System.Drawing.Size(52, 13);
            this.labelActivated.TabIndex = 34;
            this.labelActivated.Text = "Activado:";
            // 
            // labelVolume
            // 
            this.labelVolume.AutoSize = true;
            this.labelVolume.Location = new System.Drawing.Point(12, 352);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(48, 13);
            this.labelVolume.TabIndex = 33;
            this.labelVolume.Text = "Volumen";
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(12, 307);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(31, 13);
            this.labelWeight.TabIndex = 32;
            this.labelWeight.Text = "Peso";
            // 
            // txtBoxCorner
            // 
            this.txtBoxCorner.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.txtBoxCorner.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxCorner.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCorner.Location = new System.Drawing.Point(160, 409);
            this.txtBoxCorner.Name = "txtBoxCorner";
            this.txtBoxCorner.Size = new System.Drawing.Size(92, 23);
            this.txtBoxCorner.TabIndex = 31;
            // 
            // txtBoxNumber
            // 
            this.txtBoxNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.txtBoxNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxNumber.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNumber.Location = new System.Drawing.Point(160, 368);
            this.txtBoxNumber.Name = "txtBoxNumber";
            this.txtBoxNumber.Size = new System.Drawing.Size(92, 23);
            this.txtBoxNumber.TabIndex = 30;
            // 
            // txtBoxStreet
            // 
            this.txtBoxStreet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.txtBoxStreet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxStreet.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxStreet.Location = new System.Drawing.Point(160, 326);
            this.txtBoxStreet.Name = "txtBoxStreet";
            this.txtBoxStreet.Size = new System.Drawing.Size(92, 23);
            this.txtBoxStreet.TabIndex = 29;
            // 
            // txtBoxVolume
            // 
            this.txtBoxVolume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.txtBoxVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxVolume.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxVolume.Location = new System.Drawing.Point(12, 368);
            this.txtBoxVolume.Name = "txtBoxVolume";
            this.txtBoxVolume.Size = new System.Drawing.Size(92, 23);
            this.txtBoxVolume.TabIndex = 28;
            // 
            // buttonEdit
            // 
            this.buttonEdit.Location = new System.Drawing.Point(284, 352);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(75, 23);
            this.buttonEdit.TabIndex = 27;
            this.buttonEdit.Text = "Edit";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(7, 487);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(112, 23);
            this.buttonRefresh.TabIndex = 26;
            this.buttonRefresh.Text = "Recargar";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(66, 458);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(53, 23);
            this.buttonDelete.TabIndex = 25;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(7, 457);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(53, 23);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // txtBoxWeight
            // 
            this.txtBoxWeight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.txtBoxWeight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBoxWeight.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxWeight.Location = new System.Drawing.Point(12, 326);
            this.txtBoxWeight.Name = "txtBoxWeight";
            this.txtBoxWeight.Size = new System.Drawing.Size(92, 23);
            this.txtBoxWeight.TabIndex = 23;
            // 
            // buttonViewMap
            // 
            this.buttonViewMap.Location = new System.Drawing.Point(572, 485);
            this.buttonViewMap.Name = "buttonViewMap";
            this.buttonViewMap.Size = new System.Drawing.Size(92, 23);
            this.buttonViewMap.TabIndex = 90;
            this.buttonViewMap.Text = "Ver Mapa";
            this.buttonViewMap.UseVisualStyleBackColor = true;
            this.buttonViewMap.Click += new System.EventHandler(this.buttonViewMap_Click);
            // 
            // ProductsManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(757, 520);
            this.Controls.Add(this.buttonViewMap);
            this.Controls.Add(this.buttonSearchByID);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.comboBoxActivated);
            this.Controls.Add(this.labelCustomer);
            this.Controls.Add(this.txtBoxClient);
            this.Controls.Add(this.labelCorner);
            this.Controls.Add(this.labelNumber);
            this.Controls.Add(this.labelStreet);
            this.Controls.Add(this.labelActivated);
            this.Controls.Add(this.labelVolume);
            this.Controls.Add(this.labelWeight);
            this.Controls.Add(this.txtBoxCorner);
            this.Controls.Add(this.txtBoxNumber);
            this.Controls.Add(this.txtBoxStreet);
            this.Controls.Add(this.txtBoxVolume);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.txtBoxWeight);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsManagerForm";
            this.Text = "ProductsManagerForm";
            this.Load += new System.EventHandler(this.ProductsManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.Button buttonSearchByID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.ComboBox comboBoxActivated;
        private System.Windows.Forms.Label labelCustomer;
        private System.Windows.Forms.TextBox txtBoxClient;
        private System.Windows.Forms.Label labelCorner;
        private System.Windows.Forms.Label labelNumber;
        private System.Windows.Forms.Label labelStreet;
        private System.Windows.Forms.Label labelActivated;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.TextBox txtBoxCorner;
        private System.Windows.Forms.TextBox txtBoxNumber;
        private System.Windows.Forms.TextBox txtBoxStreet;
        private System.Windows.Forms.TextBox txtBoxVolume;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox txtBoxWeight;
        private System.Windows.Forms.Button buttonViewMap;
    }
}