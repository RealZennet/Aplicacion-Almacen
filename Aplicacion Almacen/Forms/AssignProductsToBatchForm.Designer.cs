namespace Aplicacion_Almacen.Forms
{
    partial class AssignProductsToBatchForm
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxIDBatch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxIDProduct = new System.Windows.Forms.TextBox();
            this.dataGridViewAssignedProducts = new System.Windows.Forms.DataGridView();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.dateTimePickerBatchShippingDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignedProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(279, 285);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(147, 26);
            this.buttonRefresh.TabIndex = 18;
            this.buttonRefresh.Text = "Recargar";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(358, 253);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(68, 26);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(279, 253);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(68, 26);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "ID del lote a asignar";
            // 
            // txtBoxIDBatch
            // 
            this.txtBoxIDBatch.Location = new System.Drawing.Point(279, 227);
            this.txtBoxIDBatch.Name = "txtBoxIDBatch";
            this.txtBoxIDBatch.Size = new System.Drawing.Size(61, 20);
            this.txtBoxIDBatch.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "ID Lote";
            // 
            // txtBoxIDProduct
            // 
            this.txtBoxIDProduct.Location = new System.Drawing.Point(272, 89);
            this.txtBoxIDProduct.Name = "txtBoxIDProduct";
            this.txtBoxIDProduct.Size = new System.Drawing.Size(61, 20);
            this.txtBoxIDProduct.TabIndex = 12;
            // 
            // dataGridViewAssignedProducts
            // 
            this.dataGridViewAssignedProducts.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewAssignedProducts.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAssignedProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssignedProducts.Location = new System.Drawing.Point(12, 59);
            this.dataGridViewAssignedProducts.Name = "dataGridViewAssignedProducts";
            this.dataGridViewAssignedProducts.Size = new System.Drawing.Size(231, 410);
            this.dataGridViewAssignedProducts.TabIndex = 11;
            this.dataGridViewAssignedProducts.SelectionChanged += new System.EventHandler(this.dataGridViewAssignedProducts_SelectionChanged);
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMainMenu.ForeColor = System.Drawing.Color.Olive;
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(113, 23);
            this.buttonBackToMainMenu.TabIndex = 46;
            this.buttonBackToMainMenu.Text = "Volver";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // dateTimePickerBatchShippingDate
            // 
            this.dateTimePickerBatchShippingDate.Location = new System.Drawing.Point(272, 157);
            this.dateTimePickerBatchShippingDate.Name = "dateTimePickerBatchShippingDate";
            this.dateTimePickerBatchShippingDate.Size = new System.Drawing.Size(216, 20);
            this.dateTimePickerBatchShippingDate.TabIndex = 49;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(269, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 17);
            this.label1.TabIndex = 48;
            this.label1.Text = "Fecha de salida";
            // 
            // AssignProductsToBatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(741, 481);
            this.Controls.Add(this.dateTimePickerBatchShippingDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxIDBatch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxIDProduct);
            this.Controls.Add(this.dataGridViewAssignedProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssignProductsToBatchForm";
            this.Text = "AssignProductsToBatchForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignedProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxIDBatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxIDProduct;
        private System.Windows.Forms.DataGridView dataGridViewAssignedProducts;
        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.DateTimePicker dateTimePickerBatchShippingDate;
        private System.Windows.Forms.Label label1;
    }
}