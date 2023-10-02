namespace Aplicacion_Almacen.Forms
{
    partial class AssignBatchToTruck
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
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelIDBatch = new System.Windows.Forms.Label();
            this.txtBoxIDBatch = new System.Windows.Forms.TextBox();
            this.labelTruckID = new System.Windows.Forms.Label();
            this.txtBoxIDTruck = new System.Windows.Forms.TextBox();
            this.dataGridViewAssignedBatchToTruck = new System.Windows.Forms.DataGridView();
            this.dateTimePickerBatchShippingDate = new System.Windows.Forms.DateTimePicker();
            this.labelEstimatedDate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignedBatchToTruck)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMainMenu.ForeColor = System.Drawing.Color.Olive;
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(12, 12);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(113, 23);
            this.buttonBackToMainMenu.TabIndex = 56;
            this.buttonBackToMainMenu.Text = "Volver";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(272, 214);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(147, 26);
            this.buttonRefresh.TabIndex = 55;
            this.buttonRefresh.Text = "Recargar";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(351, 182);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(68, 26);
            this.buttonDelete.TabIndex = 54;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(272, 182);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(68, 26);
            this.buttonAdd.TabIndex = 53;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelIDBatch
            // 
            this.labelIDBatch.AutoSize = true;
            this.labelIDBatch.Location = new System.Drawing.Point(269, 131);
            this.labelIDBatch.Name = "labelIDBatch";
            this.labelIDBatch.Size = new System.Drawing.Size(42, 13);
            this.labelIDBatch.TabIndex = 52;
            this.labelIDBatch.Text = "ID Lote";
            // 
            // txtBoxIDBatch
            // 
            this.txtBoxIDBatch.Location = new System.Drawing.Point(272, 156);
            this.txtBoxIDBatch.Name = "txtBoxIDBatch";
            this.txtBoxIDBatch.Size = new System.Drawing.Size(61, 20);
            this.txtBoxIDBatch.TabIndex = 51;
            // 
            // labelTruckID
            // 
            this.labelTruckID.AutoSize = true;
            this.labelTruckID.Location = new System.Drawing.Point(269, 59);
            this.labelTruckID.Name = "labelTruckID";
            this.labelTruckID.Size = new System.Drawing.Size(56, 13);
            this.labelTruckID.TabIndex = 50;
            this.labelTruckID.Text = "ID Camion";
            // 
            // txtBoxIDTruck
            // 
            this.txtBoxIDTruck.Location = new System.Drawing.Point(272, 89);
            this.txtBoxIDTruck.Name = "txtBoxIDTruck";
            this.txtBoxIDTruck.Size = new System.Drawing.Size(61, 20);
            this.txtBoxIDTruck.TabIndex = 49;
            // 
            // dataGridViewAssignedBatchToTruck
            // 
            this.dataGridViewAssignedBatchToTruck.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewAssignedBatchToTruck.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAssignedBatchToTruck.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAssignedBatchToTruck.Location = new System.Drawing.Point(12, 59);
            this.dataGridViewAssignedBatchToTruck.Name = "dataGridViewAssignedBatchToTruck";
            this.dataGridViewAssignedBatchToTruck.Size = new System.Drawing.Size(231, 410);
            this.dataGridViewAssignedBatchToTruck.TabIndex = 48;
            this.dataGridViewAssignedBatchToTruck.SelectionChanged += new System.EventHandler(this.dataGridViewAssignedBatchToTruck_SelectionChanged);
            // 
            // dateTimePickerBatchShippingDate
            // 
            this.dateTimePickerBatchShippingDate.Location = new System.Drawing.Point(428, 89);
            this.dateTimePickerBatchShippingDate.Name = "dateTimePickerBatchShippingDate";
            this.dateTimePickerBatchShippingDate.Size = new System.Drawing.Size(216, 20);
            this.dateTimePickerBatchShippingDate.TabIndex = 58;
            // 
            // labelEstimatedDate
            // 
            this.labelEstimatedDate.AutoSize = true;
            this.labelEstimatedDate.BackColor = System.Drawing.Color.Transparent;
            this.labelEstimatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelEstimatedDate.Location = new System.Drawing.Point(425, 58);
            this.labelEstimatedDate.Name = "labelEstimatedDate";
            this.labelEstimatedDate.Size = new System.Drawing.Size(181, 17);
            this.labelEstimatedDate.TabIndex = 57;
            this.labelEstimatedDate.Text = "Fecha estimada de entrega";
            // 
            // AssignBatchToTruck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(741, 481);
            this.Controls.Add(this.dateTimePickerBatchShippingDate);
            this.Controls.Add(this.labelEstimatedDate);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelIDBatch);
            this.Controls.Add(this.txtBoxIDBatch);
            this.Controls.Add(this.labelTruckID);
            this.Controls.Add(this.txtBoxIDTruck);
            this.Controls.Add(this.dataGridViewAssignedBatchToTruck);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AssignBatchToTruck";
            this.Text = "AssignBatchToTruck";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAssignedBatchToTruck)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelIDBatch;
        private System.Windows.Forms.TextBox txtBoxIDBatch;
        private System.Windows.Forms.Label labelTruckID;
        private System.Windows.Forms.TextBox txtBoxIDTruck;
        private System.Windows.Forms.DataGridView dataGridViewAssignedBatchToTruck;
        private System.Windows.Forms.DateTimePicker dateTimePickerBatchShippingDate;
        private System.Windows.Forms.Label labelEstimatedDate;
    }
}