namespace DeliveryApp
{
    partial class UserHistory
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.detailsGridView = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Label();
            this.historyGridView = new System.Windows.Forms.DataGridView();
            this.deliveryDataSet = new DeliveryApp.DeliveryDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.detailsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(511, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(261, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Подробности выбранного заказа";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(31, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Заказы";
            // 
            // detailsGridView
            // 
            this.detailsGridView.AllowUserToAddRows = false;
            this.detailsGridView.AllowUserToDeleteRows = false;
            this.detailsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detailsGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.detailsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsGridView.Location = new System.Drawing.Point(515, 132);
            this.detailsGridView.Name = "detailsGridView";
            this.detailsGridView.ReadOnly = true;
            this.detailsGridView.Size = new System.Drawing.Size(257, 269);
            this.detailsGridView.TabIndex = 8;
            this.detailsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historyGridView_CellClick);
            // 
            // backButton
            // 
            this.backButton.AutoSize = true;
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.backButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.backButton.Location = new System.Drawing.Point(28, 49);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(37, 39);
            this.backButton.TabIndex = 7;
            this.backButton.Text = "<";
            // 
            // historyGridView
            // 
            this.historyGridView.AllowUserToAddRows = false;
            this.historyGridView.AllowUserToDeleteRows = false;
            this.historyGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historyGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.historyGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyGridView.Location = new System.Drawing.Point(35, 132);
            this.historyGridView.Name = "historyGridView";
            this.historyGridView.ReadOnly = true;
            this.historyGridView.Size = new System.Drawing.Size(411, 269);
            this.historyGridView.TabIndex = 6;
            this.historyGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.historyGridView_CellClick);
            // 
            // deliveryDataSet
            // 
            this.deliveryDataSet.DataSetName = "DeliveryDataSet";
            this.deliveryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UserHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.detailsGridView);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.historyGridView);
            this.Name = "UserHistory";
            this.Text = "Practice app (История заказов)";
            ((System.ComponentModel.ISupportInitialize)(this.detailsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView detailsGridView;
        private System.Windows.Forms.Label backButton;
        private System.Windows.Forms.DataGridView historyGridView;
        private DeliveryDataSet deliveryDataSet;
    }
}