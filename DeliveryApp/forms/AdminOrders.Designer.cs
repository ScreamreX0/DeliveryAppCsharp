namespace DeliveryApp.forms
{
    partial class AdminOrders
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
            this.filterButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxTotalSum = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.checkBoxPaymentMethod = new System.Windows.Forms.CheckBox();
            this.checkBoxComment = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxCustomerName = new System.Windows.Forms.CheckBox();
            this.checkBoxCustomerLastName = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkBoxId = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxOrderDate = new System.Windows.Forms.CheckBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.OrderToDatePicker = new System.Windows.Forms.DateTimePicker();
            this.OrderFromDatePicker = new System.Windows.Forms.DateTimePicker();
            this.PaymentMethodComboBox = new System.Windows.Forms.ComboBox();
            this.TotalSumTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.SlateBlue;
            this.filterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filterButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.filterButton.Location = new System.Drawing.Point(775, 74);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(120, 37);
            this.filterButton.TabIndex = 77;
            this.filterButton.Text = "Фильтровать";
            this.filterButton.UseVisualStyleBackColor = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label10.ForeColor = System.Drawing.Color.Gainsboro;
            this.label10.Location = new System.Drawing.Point(796, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 76;
            this.label10.Text = "Сумма заказа";
            // 
            // checkBoxTotalSum
            // 
            this.checkBoxTotalSum.AutoSize = true;
            this.checkBoxTotalSum.Location = new System.Drawing.Point(775, 142);
            this.checkBoxTotalSum.Name = "checkBoxTotalSum";
            this.checkBoxTotalSum.Size = new System.Drawing.Size(15, 14);
            this.checkBoxTotalSum.TabIndex = 75;
            this.checkBoxTotalSum.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Gainsboro;
            this.label9.Location = new System.Drawing.Point(409, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 74;
            this.label9.Text = "Метод оплаты";
            // 
            // checkBoxPaymentMethod
            // 
            this.checkBoxPaymentMethod.AutoSize = true;
            this.checkBoxPaymentMethod.Location = new System.Drawing.Point(388, 83);
            this.checkBoxPaymentMethod.Name = "checkBoxPaymentMethod";
            this.checkBoxPaymentMethod.Size = new System.Drawing.Size(15, 14);
            this.checkBoxPaymentMethod.TabIndex = 73;
            this.checkBoxPaymentMethod.UseVisualStyleBackColor = true;
            // 
            // checkBoxComment
            // 
            this.checkBoxComment.AutoSize = true;
            this.checkBoxComment.Location = new System.Drawing.Point(388, 142);
            this.checkBoxComment.Name = "checkBoxComment";
            this.checkBoxComment.Size = new System.Drawing.Size(15, 14);
            this.checkBoxComment.TabIndex = 72;
            this.checkBoxComment.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(408, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 71;
            this.label8.Text = "Фильтры";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(409, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Комментарий";
            // 
            // checkBoxCustomerName
            // 
            this.checkBoxCustomerName.AutoSize = true;
            this.checkBoxCustomerName.Location = new System.Drawing.Point(197, 139);
            this.checkBoxCustomerName.Name = "checkBoxCustomerName";
            this.checkBoxCustomerName.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCustomerName.TabIndex = 69;
            this.checkBoxCustomerName.UseVisualStyleBackColor = true;
            // 
            // checkBoxCustomerLastName
            // 
            this.checkBoxCustomerLastName.AutoSize = true;
            this.checkBoxCustomerLastName.Location = new System.Drawing.Point(197, 84);
            this.checkBoxCustomerLastName.Name = "checkBoxCustomerLastName";
            this.checkBoxCustomerLastName.Size = new System.Drawing.Size(15, 14);
            this.checkBoxCustomerLastName.TabIndex = 68;
            this.checkBoxCustomerLastName.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(218, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Имя заказчика";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(218, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "Фамилия заказчика";
            // 
            // checkBoxId
            // 
            this.checkBoxId.AutoSize = true;
            this.checkBoxId.Location = new System.Drawing.Point(55, 142);
            this.checkBoxId.Name = "checkBoxId";
            this.checkBoxId.Size = new System.Drawing.Size(15, 14);
            this.checkBoxId.TabIndex = 65;
            this.checkBoxId.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(73, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Номер заказа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(583, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "Дата заказа до";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(583, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Дата заказа от";
            // 
            // checkBoxOrderDate
            // 
            this.checkBoxOrderDate.AutoSize = true;
            this.checkBoxOrderDate.Location = new System.Drawing.Point(565, 83);
            this.checkBoxOrderDate.Name = "checkBoxOrderDate";
            this.checkBoxOrderDate.Size = new System.Drawing.Size(15, 14);
            this.checkBoxOrderDate.TabIndex = 61;
            this.checkBoxOrderDate.UseVisualStyleBackColor = true;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(218, 81);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(112, 20);
            this.LastNameTextBox.TabIndex = 60;
            // 
            // OrderToDatePicker
            // 
            this.OrderToDatePicker.CustomFormat = "dd-MM-yyyy";
            this.OrderToDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OrderToDatePicker.Location = new System.Drawing.Point(586, 139);
            this.OrderToDatePicker.Name = "OrderToDatePicker";
            this.OrderToDatePicker.Size = new System.Drawing.Size(124, 20);
            this.OrderToDatePicker.TabIndex = 59;
            // 
            // OrderFromDatePicker
            // 
            this.OrderFromDatePicker.CustomFormat = "dd-MM-yyyy";
            this.OrderFromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OrderFromDatePicker.Location = new System.Drawing.Point(586, 81);
            this.OrderFromDatePicker.Name = "OrderFromDatePicker";
            this.OrderFromDatePicker.Size = new System.Drawing.Size(124, 20);
            this.OrderFromDatePicker.TabIndex = 58;
            // 
            // PaymentMethodComboBox
            // 
            this.PaymentMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PaymentMethodComboBox.FormattingEnabled = true;
            this.PaymentMethodComboBox.Items.AddRange(new object[] {
            "Карта",
            "Наличные"});
            this.PaymentMethodComboBox.Location = new System.Drawing.Point(409, 80);
            this.PaymentMethodComboBox.Name = "PaymentMethodComboBox";
            this.PaymentMethodComboBox.Size = new System.Drawing.Size(100, 21);
            this.PaymentMethodComboBox.TabIndex = 57;
            // 
            // TotalSumTextBox
            // 
            this.TotalSumTextBox.Location = new System.Drawing.Point(796, 139);
            this.TotalSumTextBox.Name = "TotalSumTextBox";
            this.TotalSumTextBox.Size = new System.Drawing.Size(99, 20);
            this.TotalSumTextBox.TabIndex = 56;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(218, 139);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(112, 20);
            this.NameTextBox.TabIndex = 55;
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(76, 139);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(77, 20);
            this.IdTextBox.TabIndex = 54;
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Location = new System.Drawing.Point(409, 139);
            this.CommentTextBox.Multiline = true;
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(100, 33);
            this.CommentTextBox.TabIndex = 53;
            // 
            // ordersGridView
            // 
            this.ordersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ordersGridView.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.GridColor = System.Drawing.Color.Snow;
            this.ordersGridView.Location = new System.Drawing.Point(54, 201);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.Size = new System.Drawing.Size(841, 306);
            this.ordersGridView.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(47, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 39);
            this.label2.TabIndex = 51;
            this.label2.Text = "<";
            // 
            // AdminOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(943, 533);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.checkBoxTotalSum);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBoxPaymentMethod);
            this.Controls.Add(this.checkBoxComment);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.checkBoxCustomerName);
            this.Controls.Add(this.checkBoxCustomerLastName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.checkBoxId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBoxOrderDate);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.OrderToDatePicker);
            this.Controls.Add(this.OrderFromDatePicker);
            this.Controls.Add(this.PaymentMethodComboBox);
            this.Controls.Add(this.TotalSumTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.IdTextBox);
            this.Controls.Add(this.CommentTextBox);
            this.Controls.Add(this.ordersGridView);
            this.Controls.Add(this.label2);
            this.Name = "AdminOrders";
            this.Text = "Practice app (Список заказов)";
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxTotalSum;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox checkBoxPaymentMethod;
        private System.Windows.Forms.CheckBox checkBoxComment;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxCustomerName;
        private System.Windows.Forms.CheckBox checkBoxCustomerLastName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox checkBoxId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxOrderDate;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.DateTimePicker OrderToDatePicker;
        private System.Windows.Forms.DateTimePicker OrderFromDatePicker;
        private System.Windows.Forms.ComboBox PaymentMethodComboBox;
        private System.Windows.Forms.TextBox TotalSumTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.Label label2;
    }
}