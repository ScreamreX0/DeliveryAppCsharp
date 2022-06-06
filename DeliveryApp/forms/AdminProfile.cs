using DeliveryApp;
using DeliveryApp.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeApp.forms
{
    public partial class AdminProfile : Form
    {
        users user;

        public AdminProfile(users user)
        {
            InitializeComponent();

            this.user = user;

            // Установка заголовка страницы
            this.Text = "Practice app (Администратор " + user.first_name + " " + user.last_name + ")";

            // Проверка на пустоту адреса пользователя
            if (!String.IsNullOrWhiteSpace(user.address))
            {
                addAddressButton.Text = "Изменить адрес";
                addressLabel.Text = "Адрес:\n" + user.address;
            }
            else
            {
                addAddressButton.Text = "Добавить адрес";
            }

            // Проверка на пустоут номера пользователя
            if (!String.IsNullOrWhiteSpace(user.phone_number))
            {
                addPhoneButton.Text = "Изменить номер";
                phoneNumberLabel.Text = "Номер телефона:\n" + user.phone_number;
            }
            else
            {
                addPhoneButton.Text = "Добавить номер";
            }
        }

        // Метод на добавление номера
        private void button1_Click(object sender, EventArgs e)
        {
            if (phoneNumberField.Text.Contains("+7") && phoneNumberField.Text.Length == 12)
            {
                DeliveryEntities delivery = new DeliveryEntities();

                delivery.users.Find(user.id).phone_number = phoneNumberField.Text;
                delivery.SaveChanges();

                phoneNumberLabel.Text = "Номер телефона:\n" + phoneNumberField.Text;
                phoneNumberField.Text = "";

                MessageBox.Show("Телефонный номер успешно изменен");
            }
            else
            {
                MessageBox.Show("Введите номер в формате '+71234567890'");
                return;
            }
        }

        // Метод на добавление адреса
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (!(String.IsNullOrEmpty(addressField.Text)))
            {
                DeliveryEntities delivery = new DeliveryEntities();

                delivery.users.Find(user.id).address = addressField.Text;
                delivery.SaveChanges();

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

        // Метод для открытия меню админа
        private void label2_Click_1(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminMenu(user));
        }
    }
}
