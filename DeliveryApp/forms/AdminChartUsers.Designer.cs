namespace DeliveryApp
{
    partial class AdminChartUsers
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
            this.label1 = new System.Windows.Forms.Label();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.buttonColumn = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonAllTime = new System.Windows.Forms.RadioButton();
            this.radioButtonYear = new System.Windows.Forms.RadioButton();
            this.radioButtonMonth = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonUsers = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonComplaints = new System.Windows.Forms.Button();
            this.chartUsers = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Пользователи";
            // 
            // infoTextBox
            // 
            this.infoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoTextBox.Location = new System.Drawing.Point(173, 313);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.Size = new System.Drawing.Size(122, 91);
            this.infoTextBox.TabIndex = 37;
            // 
            // buttonGraph
            // 
            this.buttonGraph.Location = new System.Drawing.Point(532, 410);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(203, 23);
            this.buttonGraph.TabIndex = 35;
            this.buttonGraph.Text = "График";
            this.buttonGraph.UseVisualStyleBackColor = true;
            // 
            // buttonColumn
            // 
            this.buttonColumn.Location = new System.Drawing.Point(301, 410);
            this.buttonColumn.Name = "buttonColumn";
            this.buttonColumn.Size = new System.Drawing.Size(216, 23);
            this.buttonColumn.TabIndex = 34;
            this.buttonColumn.Text = "Гистограмма";
            this.buttonColumn.UseVisualStyleBackColor = true;
            // 
            // buttonRight
            // 
            this.buttonRight.Location = new System.Drawing.Point(245, 9);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(49, 23);
            this.buttonRight.TabIndex = 33;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(193, 9);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(49, 23);
            this.buttonLeft.TabIndex = 32;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonAllTime);
            this.groupBox1.Controls.Add(this.radioButtonYear);
            this.groupBox1.Controls.Add(this.radioButtonMonth);
            this.groupBox1.Location = new System.Drawing.Point(194, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 66);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonAllTime
            // 
            this.radioButtonAllTime.AutoSize = true;
            this.radioButtonAllTime.Checked = true;
            this.radioButtonAllTime.Location = new System.Drawing.Point(6, 0);
            this.radioButtonAllTime.Name = "radioButtonAllTime";
            this.radioButtonAllTime.Size = new System.Drawing.Size(94, 17);
            this.radioButtonAllTime.TabIndex = 16;
            this.radioButtonAllTime.TabStop = true;
            this.radioButtonAllTime.Text = "За все время";
            this.radioButtonAllTime.UseVisualStyleBackColor = true;
            this.radioButtonAllTime.CheckedChanged += new System.EventHandler(this.radioButtonAllTime_CheckedChanged);
            // 
            // radioButtonYear
            // 
            this.radioButtonYear.AutoSize = true;
            this.radioButtonYear.Location = new System.Drawing.Point(6, 23);
            this.radioButtonYear.Name = "radioButtonYear";
            this.radioButtonYear.Size = new System.Drawing.Size(58, 17);
            this.radioButtonYear.TabIndex = 13;
            this.radioButtonYear.TabStop = true;
            this.radioButtonYear.Text = "За год";
            this.radioButtonYear.UseVisualStyleBackColor = true;
            this.radioButtonYear.CheckedChanged += new System.EventHandler(this.radioButtonYear_CheckedChanged);
            // 
            // radioButtonMonth
            // 
            this.radioButtonMonth.AutoSize = true;
            this.radioButtonMonth.Location = new System.Drawing.Point(6, 46);
            this.radioButtonMonth.Name = "radioButtonMonth";
            this.radioButtonMonth.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMonth.TabIndex = 14;
            this.radioButtonMonth.TabStop = true;
            this.radioButtonMonth.Text = "За месяц";
            this.radioButtonMonth.UseVisualStyleBackColor = true;
            this.radioButtonMonth.CheckedChanged += new System.EventHandler(this.radioButtonMonth_CheckedChanged);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(193, 38);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(101, 20);
            this.dateTimePicker.TabIndex = 30;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(16, 364);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(149, 40);
            this.buttonBack.TabIndex = 29;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonCouriers
            // 
            this.buttonUsers.Location = new System.Drawing.Point(16, 279);
            this.buttonUsers.Name = "buttonCouriers";
            this.buttonUsers.Size = new System.Drawing.Size(149, 79);
            this.buttonUsers.TabIndex = 28;
            this.buttonUsers.Text = "Пользователи";
            this.buttonUsers.UseVisualStyleBackColor = true;
            // 
            // buttonOrders
            // 
            this.buttonOrders.Location = new System.Drawing.Point(16, 194);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(149, 79);
            this.buttonOrders.TabIndex = 27;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonComplaints
            // 
            this.buttonComplaints.Location = new System.Drawing.Point(16, 109);
            this.buttonComplaints.Name = "buttonComplaints";
            this.buttonComplaints.Size = new System.Drawing.Size(149, 79);
            this.buttonComplaints.TabIndex = 26;
            this.buttonComplaints.Text = "Жалобы";
            this.buttonComplaints.UseVisualStyleBackColor = true;
            this.buttonComplaints.Click += new System.EventHandler(this.buttonComplaints_Click);
            // 
            // chartUsers
            // 
            chartArea1.Name = "ChartArea1";
            this.chartUsers.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartUsers.Legends.Add(legend1);
            this.chartUsers.Location = new System.Drawing.Point(301, 9);
            this.chartUsers.Name = "chartUsers";
            this.chartUsers.Size = new System.Drawing.Size(434, 395);
            this.chartUsers.TabIndex = 25;
            // 
            // AdminChartUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 449);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.buttonGraph);
            this.Controls.Add(this.buttonColumn);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonUsers);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonComplaints);
            this.Controls.Add(this.chartUsers);
            this.Name = "AdminChartUsers";
            this.Text = "Диаграммы";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartUsers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.Button buttonGraph;
        private System.Windows.Forms.Button buttonColumn;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonAllTime;
        private System.Windows.Forms.RadioButton radioButtonYear;
        private System.Windows.Forms.RadioButton radioButtonMonth;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonUsers;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonComplaints;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartUsers;
    }
}