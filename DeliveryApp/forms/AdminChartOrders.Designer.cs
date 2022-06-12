namespace DeliveryApp
{
    partial class AdminChartOrders
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonDay = new System.Windows.Forms.RadioButton();
            this.radioButtonAllTime = new System.Windows.Forms.RadioButton();
            this.radioButtonYear = new System.Windows.Forms.RadioButton();
            this.radioButtonMonth = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonCouriers = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonComplaints = new System.Windows.Forms.Button();
            this.chartOrders = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonPoint = new System.Windows.Forms.Button();
            this.buttonSpline = new System.Windows.Forms.Button();
            this.buttonGraph = new System.Windows.Forms.Button();
            this.buttonColumn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRight
            // 
            this.buttonRight.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRight.ForeColor = System.Drawing.Color.White;
            this.buttonRight.Location = new System.Drawing.Point(245, 9);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(49, 23);
            this.buttonRight.TabIndex = 33;
            this.buttonRight.Text = ">";
            this.buttonRight.UseVisualStyleBackColor = false;
            this.buttonRight.Click += new System.EventHandler(this.buttonRight_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLeft.ForeColor = System.Drawing.Color.White;
            this.buttonLeft.Location = new System.Drawing.Point(193, 9);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(49, 23);
            this.buttonLeft.TabIndex = 32;
            this.buttonLeft.Text = "<";
            this.buttonLeft.UseVisualStyleBackColor = false;
            this.buttonLeft.Click += new System.EventHandler(this.buttonLeft_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonDay);
            this.groupBox1.Controls.Add(this.radioButtonAllTime);
            this.groupBox1.Controls.Add(this.radioButtonYear);
            this.groupBox1.Controls.Add(this.radioButtonMonth);
            this.groupBox1.Location = new System.Drawing.Point(194, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(101, 91);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonDay
            // 
            this.radioButtonDay.AutoSize = true;
            this.radioButtonDay.Checked = true;
            this.radioButtonDay.ForeColor = System.Drawing.Color.White;
            this.radioButtonDay.Location = new System.Drawing.Point(6, 69);
            this.radioButtonDay.Name = "radioButtonDay";
            this.radioButtonDay.Size = new System.Drawing.Size(65, 17);
            this.radioButtonDay.TabIndex = 17;
            this.radioButtonDay.TabStop = true;
            this.radioButtonDay.Text = "За день";
            this.radioButtonDay.UseVisualStyleBackColor = true;
            this.radioButtonDay.CheckedChanged += new System.EventHandler(this.radioButtonDay_CheckedChanged);
            // 
            // radioButtonAllTime
            // 
            this.radioButtonAllTime.AutoSize = true;
            this.radioButtonAllTime.ForeColor = System.Drawing.Color.White;
            this.radioButtonAllTime.Location = new System.Drawing.Point(6, 0);
            this.radioButtonAllTime.Name = "radioButtonAllTime";
            this.radioButtonAllTime.Size = new System.Drawing.Size(94, 17);
            this.radioButtonAllTime.TabIndex = 16;
            this.radioButtonAllTime.Text = "За все время";
            this.radioButtonAllTime.UseVisualStyleBackColor = true;
            this.radioButtonAllTime.CheckedChanged += new System.EventHandler(this.radioButtonAllTime_CheckedChanged);
            // 
            // radioButtonYear
            // 
            this.radioButtonYear.AutoSize = true;
            this.radioButtonYear.ForeColor = System.Drawing.Color.White;
            this.radioButtonYear.Location = new System.Drawing.Point(6, 23);
            this.radioButtonYear.Name = "radioButtonYear";
            this.radioButtonYear.Size = new System.Drawing.Size(58, 17);
            this.radioButtonYear.TabIndex = 13;
            this.radioButtonYear.Text = "За год";
            this.radioButtonYear.UseVisualStyleBackColor = true;
            this.radioButtonYear.CheckedChanged += new System.EventHandler(this.radioButtonYear_CheckedChanged);
            // 
            // radioButtonMonth
            // 
            this.radioButtonMonth.AutoSize = true;
            this.radioButtonMonth.ForeColor = System.Drawing.Color.White;
            this.radioButtonMonth.Location = new System.Drawing.Point(6, 46);
            this.radioButtonMonth.Name = "radioButtonMonth";
            this.radioButtonMonth.Size = new System.Drawing.Size(73, 17);
            this.radioButtonMonth.TabIndex = 14;
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
            this.buttonBack.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonBack.ForeColor = System.Drawing.Color.White;
            this.buttonBack.Location = new System.Drawing.Point(16, 364);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(149, 40);
            this.buttonBack.TabIndex = 29;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonCouriers
            // 
            this.buttonCouriers.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonCouriers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonCouriers.ForeColor = System.Drawing.Color.White;
            this.buttonCouriers.Location = new System.Drawing.Point(16, 279);
            this.buttonCouriers.Name = "buttonCouriers";
            this.buttonCouriers.Size = new System.Drawing.Size(149, 79);
            this.buttonCouriers.TabIndex = 28;
            this.buttonCouriers.Text = "Пользователи";
            this.buttonCouriers.UseVisualStyleBackColor = false;
            this.buttonCouriers.Click += new System.EventHandler(this.buttonCouriers_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonOrders.ForeColor = System.Drawing.Color.White;
            this.buttonOrders.Location = new System.Drawing.Point(16, 194);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(149, 79);
            this.buttonOrders.TabIndex = 27;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.UseVisualStyleBackColor = false;
            // 
            // buttonComplaints
            // 
            this.buttonComplaints.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonComplaints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.buttonComplaints.ForeColor = System.Drawing.Color.White;
            this.buttonComplaints.Location = new System.Drawing.Point(16, 109);
            this.buttonComplaints.Name = "buttonComplaints";
            this.buttonComplaints.Size = new System.Drawing.Size(149, 79);
            this.buttonComplaints.TabIndex = 26;
            this.buttonComplaints.Text = "Жалобы";
            this.buttonComplaints.UseVisualStyleBackColor = false;
            this.buttonComplaints.Click += new System.EventHandler(this.buttonComplaints_Click);
            // 
            // chartOrders
            // 
            chartArea8.Name = "ChartArea1";
            this.chartOrders.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartOrders.Legends.Add(legend8);
            this.chartOrders.Location = new System.Drawing.Point(301, 9);
            this.chartOrders.Name = "chartOrders";
            this.chartOrders.Size = new System.Drawing.Size(434, 395);
            this.chartOrders.TabIndex = 25;
            // 
            // buttonPoint
            // 
            this.buttonPoint.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonPoint.ForeColor = System.Drawing.Color.White;
            this.buttonPoint.Location = new System.Drawing.Point(634, 414);
            this.buttonPoint.Name = "buttonPoint";
            this.buttonPoint.Size = new System.Drawing.Size(100, 23);
            this.buttonPoint.TabIndex = 42;
            this.buttonPoint.Text = "Точки";
            this.buttonPoint.UseVisualStyleBackColor = false;
            this.buttonPoint.Click += new System.EventHandler(this.buttonPoint_Click);
            // 
            // buttonSpline
            // 
            this.buttonSpline.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonSpline.ForeColor = System.Drawing.Color.White;
            this.buttonSpline.Location = new System.Drawing.Point(523, 414);
            this.buttonSpline.Name = "buttonSpline";
            this.buttonSpline.Size = new System.Drawing.Size(105, 23);
            this.buttonSpline.TabIndex = 41;
            this.buttonSpline.Text = "Площадь";
            this.buttonSpline.UseVisualStyleBackColor = false;
            this.buttonSpline.Click += new System.EventHandler(this.buttonSpline_Click);
            // 
            // buttonGraph
            // 
            this.buttonGraph.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonGraph.ForeColor = System.Drawing.Color.White;
            this.buttonGraph.Location = new System.Drawing.Point(412, 414);
            this.buttonGraph.Name = "buttonGraph";
            this.buttonGraph.Size = new System.Drawing.Size(105, 23);
            this.buttonGraph.TabIndex = 40;
            this.buttonGraph.Text = "График";
            this.buttonGraph.UseVisualStyleBackColor = false;
            this.buttonGraph.Click += new System.EventHandler(this.buttonGraph_Click);
            // 
            // buttonColumn
            // 
            this.buttonColumn.BackColor = System.Drawing.Color.SlateBlue;
            this.buttonColumn.ForeColor = System.Drawing.Color.White;
            this.buttonColumn.Location = new System.Drawing.Point(301, 414);
            this.buttonColumn.Name = "buttonColumn";
            this.buttonColumn.Size = new System.Drawing.Size(105, 23);
            this.buttonColumn.TabIndex = 39;
            this.buttonColumn.Text = "Гистограмма";
            this.buttonColumn.UseVisualStyleBackColor = false;
            this.buttonColumn.Click += new System.EventHandler(this.buttonColumn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 33);
            this.label2.TabIndex = 43;
            this.label2.Text = "Заказы";
            // 
            // AdminChartOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(760, 449);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonPoint);
            this.Controls.Add(this.buttonSpline);
            this.Controls.Add(this.buttonGraph);
            this.Controls.Add(this.buttonColumn);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonCouriers);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonComplaints);
            this.Controls.Add(this.chartOrders);
            this.Name = "AdminChartOrders";
            this.Text = "Диаграммы";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButtonAllTime;
        private System.Windows.Forms.RadioButton radioButtonYear;
        private System.Windows.Forms.RadioButton radioButtonMonth;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonCouriers;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonComplaints;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrders;
        private System.Windows.Forms.RadioButton radioButtonDay;
        private System.Windows.Forms.Button buttonPoint;
        private System.Windows.Forms.Button buttonSpline;
        private System.Windows.Forms.Button buttonGraph;
        private System.Windows.Forms.Button buttonColumn;
        private System.Windows.Forms.Label label2;
    }
}