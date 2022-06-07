using DeliveryApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryApp
{
    public partial class UserProfile : Form
    {
        private users _user;
        private DeliveryEntities _deliveryEntities = Constants.deliveryModel;

        public UserProfile(users user)
        {
            InitializeComponent();

            this._user = user;

            init();
        }

        private void init()
        {
            label1.Text = _user.first_name.ToString() + " " + _user.last_name.ToString();

            if (!String.IsNullOrWhiteSpace(_user.address))
            {
                addAddressButton.Text = "Изменить адрес";
                addressLabel.Text = "Адрес:\n" + _user.address;
            }
            else
            {
                addAddressButton.Text = "Добавить адрес";
            }

            if (!String.IsNullOrWhiteSpace(_user.phone_number))
            {
                addPhoneButton.Text = "Изменить номер";
                phoneNumberLabel.Text = "Номер телефона:\n" + _user.phone_number;
            }
            else
            {
                addPhoneButton.Text = "Добавить номер";
            }
        }

        // add/change phone number click
        private void button1_Click(object sender, EventArgs e)
        {
            if (phoneNumberField.Text.Contains("+7") && phoneNumberField.Text.Length == 12)
            {
                _deliveryEntities.users.Find(_user.id).phone_number = phoneNumberField.Text;
                _deliveryEntities.SaveChanges();

                phoneNumberLabel.Text = "Номер телефона:\n" + phoneNumberField.Text;
                phoneNumberField.Text = "";
            } 
            else
            {
                MessageBox.Show("Введите номер в формате '+7XXXXXXXXXX'");
                return;
            }
        }

        // add/change address click
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(addressField.Text)))
            {
                _deliveryEntities.users.Find(_user.id).address = addressField.Text;
                _deliveryEntities.SaveChanges();

                addressLabel.Text = "Адрес:\n" + addressField.Text;
                addressField.Text = "";

                MessageBox.Show("Адрес успешно изменен");
            }
            else
            {
                MessageBox.Show("Поле не должно быть пустым");
                return;
            }
        }

        // user menu open
        private void label2_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new UserMenu(_user));
        }

        // about open
        private void aboutUs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormsHelper.openForm(this, new About(_user));
        }

        // user history open
        private void button1_Click_2(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new UserHistory(_user));
        }

        // applications open
        private void button2_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new Applications(_user, "Заявка на трудоустройство"));
        }

        // applications open
        private void button3_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new Applications(_user, "Отзыв"));
        }
    }
}
