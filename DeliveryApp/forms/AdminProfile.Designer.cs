namespace DeliveryApp
{
    partial class AdminProfile
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
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressField = new System.Windows.Forms.TextBox();
            this.addAddressButton = new System.Windows.Forms.Button();
            this.phoneNumberField = new System.Windows.Forms.TextBox();
            this.addPhoneButton = new System.Windows.Forms.Button();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.addressLabel.Location = new System.Drawing.Point(475, 315);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(273, 78);
            this.addressLabel.TabIndex = 23;
            // 
            // addressField
            // 
            this.addressField.Location = new System.Drawing.Point(93, 315);
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(166, 20);
            this.addressField.TabIndex = 21;
            // 
            // addAddressButton
            // 
            this.addAddressButton.BackColor = System.Drawing.Color.SlateBlue;
            this.addAddressButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAddressButton.Location = new System.Drawing.Point(93, 341);
            this.addAddressButton.Name = "addAddressButton";
            this.addAddressButton.Size = new System.Drawing.Size(166, 23);
            this.addAddressButton.TabIndex = 20;
            this.addAddressButton.Text = "Добавить адрес";
            this.addAddressButton.UseVisualStyleBackColor = false;
            this.addAddressButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // phoneNumberField
            // 
            this.phoneNumberField.Location = new System.Drawing.Point(93, 187);
            this.phoneNumberField.Name = "phoneNumberField";
            this.phoneNumberField.Size = new System.Drawing.Size(166, 20);
            this.phoneNumberField.TabIndex = 19;
            // 
            // addPhoneButton
            // 
            this.addPhoneButton.BackColor = System.Drawing.Color.SlateBlue;
            this.addPhoneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPhoneButton.Location = new System.Drawing.Point(93, 213);
            this.addPhoneButton.Name = "addPhoneButton";
            this.addPhoneButton.Size = new System.Drawing.Size(166, 23);
            this.addPhoneButton.TabIndex = 18;
            this.addPhoneButton.Text = "Добавить номер";
            this.addPhoneButton.UseVisualStyleBackColor = false;
            this.addPhoneButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumberLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.phoneNumberLabel.Location = new System.Drawing.Point(475, 187);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(273, 78);
            this.phoneNumberLabel.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(43, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 39);
            this.label2.TabIndex = 16;
            this.label2.Text = "<";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // AdminProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(860, 512);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.addressField);
            this.Controls.Add(this.addAddressButton);
            this.Controls.Add(this.phoneNumberField);
            this.Controls.Add(this.addPhoneButton);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.Color.Gainsboro;
            this.Name = "AdminProfile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.Button addAddressButton;
        private System.Windows.Forms.TextBox phoneNumberField;
        private System.Windows.Forms.Button addPhoneButton;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Label label2;
    }
}