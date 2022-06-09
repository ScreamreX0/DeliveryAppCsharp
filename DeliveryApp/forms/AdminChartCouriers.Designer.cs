namespace DeliveryApp
{
    partial class AdminChartCouriers
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonCouriers = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonComplaints = new System.Windows.Forms.Button();
            this.chartComplaints = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartComplaints)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(43, 392);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(149, 40);
            this.buttonBack.TabIndex = 16;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonCouriers
            // 
            this.buttonCouriers.Location = new System.Drawing.Point(43, 307);
            this.buttonCouriers.Name = "buttonCouriers";
            this.buttonCouriers.Size = new System.Drawing.Size(149, 79);
            this.buttonCouriers.TabIndex = 15;
            this.buttonCouriers.Text = "Курьеры";
            this.buttonCouriers.UseVisualStyleBackColor = true;
            // 
            // buttonOrders
            // 
            this.buttonOrders.Location = new System.Drawing.Point(43, 222);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(149, 79);
            this.buttonOrders.TabIndex = 14;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.UseVisualStyleBackColor = true;
            // 
            // buttonComplaints
            // 
            this.buttonComplaints.Location = new System.Drawing.Point(43, 137);
            this.buttonComplaints.Name = "buttonComplaints";
            this.buttonComplaints.Size = new System.Drawing.Size(149, 79);
            this.buttonComplaints.TabIndex = 13;
            this.buttonComplaints.Text = "Жалобы";
            this.buttonComplaints.UseVisualStyleBackColor = true;
            // 
            // chartComplaints
            // 
            chartArea1.Name = "ChartArea1";
            this.chartComplaints.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartComplaints.Legends.Add(legend1);
            this.chartComplaints.Location = new System.Drawing.Point(278, 48);
            this.chartComplaints.Name = "chartComplaints";
            this.chartComplaints.Size = new System.Drawing.Size(455, 384);
            this.chartComplaints.TabIndex = 12;
            this.chartComplaints.Text = "chart1";
            // 
            // AdminChartCouriers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 469);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCouriers);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonComplaints);
            this.Controls.Add(this.chartComplaints);
            this.Name = "AdminChartCouriers";
            this.Text = "Диаграммы";
            ((System.ComponentModel.ISupportInitialize)(this.chartComplaints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonCouriers;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonComplaints;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartComplaints;
    }
}