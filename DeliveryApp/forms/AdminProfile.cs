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
    public partial class AdminProfile : Form
    {
        private users _user;

        public AdminProfile(users user)
        {
            InitializeComponent();

            this._user = user;

            init();
        }

        private void init()
        {
            // form title
            this.Text = "DeliveryApp (Администратор " + _user.first_name + " " + _user.last_name + ")";

            // admin address
            if (!String.IsNullOrWhiteSpace(_user.address))
            {
                addAddressButton.Text = "Изменить адрес";
                addressLabel.Text = "Адрес:\n" + _user.address;
            }
            else
            {
                addAddressButton.Text = "Добавить адрес";
            }

            // admin phone number
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

        // add/change phone number 
        private void button1_Click(object sender, EventArgs e)
        {
            if (phoneNumberField.Text.Contains("+7") && phoneNumberField.Text.Length == 12)
            {
                DeliveryEntities delivery = new DeliveryEntities();

                delivery.users.Find(_user.id).phone_number = phoneNumberField.Text;
                delivery.SaveChanges();

                phoneNumberLabel.Text = "Номер телефона:\n" + phoneNumberField.Text;
                phoneNumberField.Text = "";
            }
            else
            {
                MessageBox.Show("Введите номер в формате '+71234567890'");
                return;
            }
        }

        // add/change address
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(addressField.Text)))
            {
                DeliveryEntities delivery = new DeliveryEntities();

                delivery.users.Find(_user.id).address = addressField.Text;
                delivery.SaveChanges();

                addressLabel.Text = "Адрес:\n" + addressField.Text;
                addressField.Text = "";
            }
            else
            {
                MessageBox.Show("Поле не должно быть пустым");
                return;
            }
        }

        // Метод для открытия меню админа
        private void label2_Click_1(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminMenu(_user));
        }
    }
}
