namespace Aplicacion_Almacen.Forms
{
    partial class BatchManagerForm
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
            this.labelIDDestination = new System.Windows.Forms.Label();
            this.txtBoxIDDestination = new System.Windows.Forms.TextBox();
            this.dateTimePickerBatchShippingDate = new System.Windows.Forms.DateTimePicker();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelEstimatedDate = new System.Windows.Forms.Label();
            this.dataGridViewBatch = new System.Windows.Forms.DataGridView();
            this.comboBoxActivated = new System.Windows.Forms.ComboBox();
            this.txtBoxIDBatch = new System.Windows.Forms.TextBox();
            this.labelLot = new System.Windows.Forms.Label();
            this.buttonSearcher = new System.Windows.Forms.Button();
            this.buttonBackToMainMenu = new System.Windows.Forms.Button();
            this.labelEstatus = new System.Windows.Forms.Label();
            this.buttonDestinationList = new System.Windows.Forms.Button();
            this.dateTimePickerBatchManagementTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBatch)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIDDestination
            // 
            this.labelIDDestination.AutoSize = true;
            this.labelIDDestination.BackColor = System.Drawing.Color.Transparent;
            this.labelIDDestination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelIDDestination.Location = new System.Drawing.Point(11, 310);
            this.labelIDDestination.Name = "labelIDDestination";
            this.labelIDDestination.Size = new System.Drawing.Size(73, 17);
            this.labelIDDestination.TabIndex = 18;
            this.labelIDDestination.Text = "ID Destino";
            // 
            // txtBoxIDDestination
            // 
            this.txtBoxIDDestination.Location = new System.Drawing.Point(14, 330);
            this.txtBoxIDDestination.Name = "txtBoxIDDestination";
            this.txtBoxIDDestination.Size = new System.Drawing.Size(50, 20);
            this.txtBoxIDDestination.TabIndex = 17;
            // 
            // dateTimePickerBatchShippingDate
            // 
            this.dateTimePickerBatchShippingDate.Location = new System.Drawing.Point(12, 253);
            this.dateTimePickerBatchShippingDate.Name = "dateTimePickerBatchShippingDate";
            this.dateTimePickerBatchShippingDate.Size = new System.Drawing.Size(216, 20);
            this.dateTimePickerBatchShippingDate.TabIndex = 16;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(14, 440);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(112, 23);
            this.buttonRefresh.TabIndex = 15;
            this.buttonRefresh.Text = "Recargar";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(73, 412);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(53, 23);
            this.buttonDelete.TabIndex = 14;
            this.buttonDelete.Text = "Eliminar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(14, 412);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(53, 23);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Agregar";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // labelEstimatedDate
            // 
            this.labelEstimatedDate.AutoSize = true;
            this.labelEstimatedDate.BackColor = System.Drawing.Color.Transparent;
            this.labelEstimatedDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelEstimatedDate.Location = new System.Drawing.Point(11, 233);
            this.labelEstimatedDate.Name = "labelEstimatedDate";
            this.labelEstimatedDate.Size = new System.Drawing.Size(181, 17);
            this.labelEstimatedDate.TabIndex = 12;
            this.labelEstimatedDate.Text = "Fecha estimada de entrega";
            // 
            // dataGridViewBatch
            // 
            this.dataGridViewBatch.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.dataGridViewBatch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBatch.Location = new System.Drawing.Point(12, 56);
            this.dataGridViewBatch.Name = "dataGridViewBatch";
            this.dataGridViewBatch.Size = new System.Drawing.Size(579, 169);
            this.dataGridViewBatch.TabIndex = 11;
            this.dataGridViewBatch.SelectionChanged += new System.EventHandler(this.dataGridViewBatch_SelectionChanged);
            // 
            // comboBoxActivated
            // 
            this.comboBoxActivated.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxActivated.FormattingEnabled = true;
            this.comboBoxActivated.Location = new System.Drawing.Point(138, 326);
            this.comboBoxActivated.Name = "comboBoxActivated";
            this.comboBoxActivated.Size = new System.Drawing.Size(92, 24);
            this.comboBoxActivated.TabIndex = 41;
            // 
            // txtBoxIDBatch
            // 
            this.txtBoxIDBatch.Location = new System.Drawing.Point(14, 386);
            this.txtBoxIDBatch.Name = "txtBoxIDBatch";
            this.txtBoxIDBatch.Size = new System.Drawing.Size(50, 20);
            this.txtBoxIDBatch.TabIndex = 42;
            // 
            // labelLot
            // 
            this.labelLot.AutoSize = true;
            this.labelLot.BackColor = System.Drawing.Color.Transparent;
            this.labelLot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelLot.Location = new System.Drawing.Point(11, 366);
            this.labelLot.Name = "labelLot";
            this.labelLot.Size = new System.Drawing.Size(53, 17);
            this.labelLot.TabIndex = 43;
            this.labelLot.Text = "ID Lote";
            // 
            // buttonSearcher
            // 
            this.buttonSearcher.Location = new System.Drawing.Point(637, 440);
            this.buttonSearcher.Name = "buttonSearcher";
            this.buttonSearcher.Size = new System.Drawing.Size(92, 23);
            this.buttonSearcher.TabIndex = 44;
            this.buttonSearcher.Text = "Buscador";
            this.buttonSearcher.UseVisualStyleBackColor = true;
            this.buttonSearcher.Click += new System.EventHandler(this.buttonSearcher_Click);
            // 
            // buttonBackToMainMenu
            // 
            this.buttonBackToMainMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBackToMainMenu.ForeColor = System.Drawing.Color.Olive;
            this.buttonBackToMainMenu.Location = new System.Drawing.Point(14, 12);
            this.buttonBackToMainMenu.Name = "buttonBackToMainMenu";
            this.buttonBackToMainMenu.Size = new System.Drawing.Size(113, 23);
            this.buttonBackToMainMenu.TabIndex = 45;
            this.buttonBackToMainMenu.Text = "Volver";
            this.buttonBackToMainMenu.UseVisualStyleBackColor = true;
            this.buttonBackToMainMenu.Click += new System.EventHandler(this.buttonBackToMainMenu_Click);
            // 
            // labelEstatus
            // 
            this.labelEstatus.AutoSize = true;
            this.labelEstatus.BackColor = System.Drawing.Color.Transparent;
            this.labelEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.labelEstatus.Location = new System.Drawing.Point(140, 306);
            this.labelEstatus.Name = "labelEstatus";
            this.labelEstatus.Size = new System.Drawing.Size(52, 17);
            this.labelEstatus.TabIndex = 46;
            this.labelEstatus.Text = "Estado";
            // 
            // buttonDestinationList
            // 
            this.buttonDestinationList.Location = new System.Drawing.Point(539, 440);
            this.buttonDestinationList.Name = "buttonDestinationList";
            this.buttonDestinationList.Size = new System.Drawing.Size(92, 23);
            this.buttonDestinationList.TabIndex = 47;
            this.buttonDestinationList.Text = "Ver destinos";
            this.buttonDestinationList.UseVisualStyleBackColor = true;
            this.buttonDestinationList.Click += new System.EventHandler(this.buttonDestinationList_Click);
            // 
            // dateTimePickerBatchManagementTime
            // 
            this.dateTimePickerBatchManagementTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePickerBatchManagementTime.Location = new System.Drawing.Point(12, 279);
            this.dateTimePickerBatchManagementTime.Name = "dateTimePickerBatchManagementTime";
            this.dateTimePickerBatchManagementTime.Size = new System.Drawing.Size(218, 20);
            this.dateTimePickerBatchManagementTime.TabIndex = 85;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label5.Location = new System.Drawing.Point(135, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 88;
            this.label5.Text = "Email";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(138, 375);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(92, 20);
            this.txtBoxEmail.TabIndex = 87;
            // 
            // BatchManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(47)))), ((int)(((byte)(68)))));
            this.ClientSize = new System.Drawing.Size(741, 481);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBoxEmail);
            this.Controls.Add(this.dateTimePickerBatchManagementTime);
            this.Controls.Add(this.buttonDestinationList);
            this.Controls.Add(this.labelEstatus);
            this.Controls.Add(this.buttonBackToMainMenu);
            this.Controls.Add(this.buttonSearcher);
            this.Controls.Add(this.labelLot);
            this.Controls.Add(this.txtBoxIDBatch);
            this.Controls.Add(this.comboBoxActivated);
            this.Controls.Add(this.labelIDDestination);
            this.Controls.Add(this.txtBoxIDDestination);
            this.Controls.Add(this.dateTimePickerBatchShippingDate);
            this.Controls.Add(this.buttonRefresh);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelEstimatedDate);
            this.Controls.Add(this.dataGridViewBatch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BatchManagerForm";
            this.Text = "BatchManagerForm";
            this.Load += new System.EventHandler(this.BatchManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIDDestination;
        private System.Windows.Forms.TextBox txtBoxIDDestination;
        private System.Windows.Forms.DateTimePicker dateTimePickerBatchShippingDate;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelEstimatedDate;
        private System.Windows.Forms.DataGridView dataGridViewBatch;
        private System.Windows.Forms.ComboBox comboBoxActivated;
        private System.Windows.Forms.TextBox txtBoxIDBatch;
        private System.Windows.Forms.Label labelLot;
        private System.Windows.Forms.Button buttonSearcher;
        private System.Windows.Forms.Button buttonBackToMainMenu;
        private System.Windows.Forms.Label labelEstatus;
        private System.Windows.Forms.Button buttonDestinationList;
        private System.Windows.Forms.DateTimePicker dateTimePickerBatchManagementTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxEmail;
    }
}