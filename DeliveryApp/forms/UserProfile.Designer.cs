namespace PracticeApp.forms
{
    partial class UserProfile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phoneNumberLabel = new System.Windows.Forms.Label();
            this.addPhoneButton = new System.Windows.Forms.Button();
            this.phoneNumberField = new System.Windows.Forms.TextBox();
            this.addressField = new System.Windows.Forms.TextBox();
            this.addAddressButton = new System.Windows.Forms.Button();
            this.aboutUs = new System.Windows.Forms.LinkLabel();
            this.addressLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(70, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 37);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(27, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "<";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // phoneNumberLabel
            // 
            this.phoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.phoneNumberLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.phoneNumberLabel.Location = new System.Drawing.Point(492, 28);
            this.phoneNumberLabel.Name = "phoneNumberLabel";
            this.phoneNumberLabel.Size = new System.Drawing.Size(273, 78);
            this.phoneNumberLabel.TabIndex = 2;
            // 
            // addPhoneButton
            // 
            this.addPhoneButton.BackColor = System.Drawing.Color.SlateBlue;
            this.addPhoneButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPhoneButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.addPhoneButton.Location = new System.Drawing.Point(77, 232);
            this.addPhoneButton.Name = "addPhoneButton";
            this.addPhoneButton.Size = new System.Drawing.Size(166, 23);
            this.addPhoneButton.TabIndex = 3;
            this.addPhoneButton.Text = "Добавить номер";
            this.addPhoneButton.UseVisualStyleBackColor = false;
            this.addPhoneButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // phoneNumberField
            // 
            this.phoneNumberField.Location = new System.Drawing.Point(77, 206);
            this.phoneNumberField.Name = "phoneNumberField";
            this.phoneNumberField.Size = new System.Drawing.Size(166, 20);
            this.phoneNumberField.TabIndex = 4;
            // 
            // addressField
            // 
            this.addressField.Location = new System.Drawing.Point(77, 334);
            this.addressField.Name = "addressField";
            this.addressField.Size = new System.Drawing.Size(166, 20);
            this.addressField.TabIndex = 7;
            // 
            // addAddressButton
            // 
            this.addAddressButton.BackColor = System.Drawing.Color.SlateBlue;
            this.addAddressButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addAddressButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.addAddressButton.Location = new System.Drawing.Point(77, 360);
            this.addAddressButton.Name = "addAddressButton";
            this.addAddressButton.Size = new System.Drawing.Size(166, 23);
            this.addAddressButton.TabIndex = 6;
            this.addAddressButton.Text = "Добавить адрес";
            this.addAddressButton.UseVisualStyleBackColor = false;
            this.addAddressButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // aboutUs
            // 
            this.aboutUs.AutoSize = true;
            this.aboutUs.LinkColor = System.Drawing.Color.White;
            this.aboutUs.Location = new System.Drawing.Point(74, 470);
            this.aboutUs.Name = "aboutUs";
            this.aboutUs.Size = new System.Drawing.Size(36, 13);
            this.aboutUs.TabIndex = 11;
            this.aboutUs.TabStop = true;
            this.aboutUs.Text = "О нас";
            this.aboutUs.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.aboutUs_LinkClicked);
            // 
            // addressLabel
            // 
            this.addressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addressLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.addressLabel.Location = new System.Drawing.Point(492, 219);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(273, 78);
            this.addressLabel.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SlateBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(521, 341);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 58);
            this.button1.TabIndex = 13;
            this.button1.Text = "История заказов";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.SlateBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.Location = new System.Drawing.Point(125, 465);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Стать курьером";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SlateBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.Location = new System.Drawing.Point(264, 465);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Оставить отзыв";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.aboutUs);
            this.Controls.Add(this.addressField);
            this.Controls.Add(this.addAddressButton);
            this.Controls.Add(this.phoneNumberField);
            this.Controls.Add(this.addPhoneButton);
            this.Controls.Add(this.phoneNumberLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UserProfile";
            this.Text = "Practice app (Профиль)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label phoneNumberLabel;
        private System.Windows.Forms.Button addPhoneButton;
        private System.Windows.Forms.TextBox phoneNumberField;
        private System.Windows.Forms.TextBox addressField;
        private System.Windows.Forms.Button addAddressButton;
        private System.Windows.Forms.LinkLabel aboutUs;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
    }
}