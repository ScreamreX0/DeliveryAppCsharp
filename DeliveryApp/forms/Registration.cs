using DeliveryApp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryApp
{
    public partial class Registration : Form
    {
        private bool _eyeIsClosed = true;
        private DeliveryEntities _deliveryEntities = Constants.deliveryModel;

        public Registration()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            // login field
            loginField.MaxLength = 50;

            // password field
            passwordField.Text = "";
            passwordField.PasswordChar = '*';
            passwordField.MaxLength = 50;

            // confirm password field
            confirmPasswordField.Text = "";
            confirmPasswordField.PasswordChar = '*';
            confirmPasswordField.MaxLength = 50;

            // eye pic
            pictureBox1.Image = Image.FromFile(Path.Combine("..\\..\\assets\\closed eye.png"));
        }

        // auth click
        private void label4_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new Auth());
        }

        // eye click
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (_eyeIsClosed)
            {
                pictureBox1.Image = Image.FromFile(Path.Combine("..\\..\\assets\\opened eye.png"));
                passwordField.PasswordChar = '\0';
                confirmPasswordField.PasswordChar = '\0';
                _eyeIsClosed = false;
            }
            else
            {
                pictureBox1.Image = Image.FromFile(Path.Combine("..\\..\\assets\\closed eye.png"));
                passwordField.PasswordChar = '*';
                confirmPasswordField.PasswordChar = '*';
                _eyeIsClosed = true;
            }
        }

        // reg button click
        private void regButton_Click(object sender, EventArgs e)
        {
            errorLabel.Text = "";

            string checkForFieldsResult = checkForFields();

            if (!checkForFieldsResult.Equals("ok"))
            {
                errorLabel.Text = checkForFieldsResult;
                return;
            }

            // check for existing user
            var user = _deliveryEntities
                .users
                .ToList()
                .FirstOrDefault(param => param.login.Equals(loginField.Text));

            if (user != null)
            {
                errorLabel.Text = "Указанный email уже зарегистрирован";
                return;
            }

            // Добавление пользователя в базу
            var customer = new users
            {
                first_name = firstNameField.Text,
                last_name = nameField.Text,
                phone_number = "",
                address = "",
                login = loginField.Text,
                password = passwordField.Text,
                role = 2  // customer role
            };

            _deliveryEntities.users.Add(customer);
            _deliveryEntities.SaveChanges();

            FormsHelper.openForm(this, new UserMenu(customer));
        }

        private String checkForFields()
        {
            // check for empty fields
            if (String.IsNullOrWhiteSpace(firstNameField.Text)
                || String.IsNullOrWhiteSpace(nameField.Text)
                || String.IsNullOrWhiteSpace(loginField.Text)
                || String.IsNullOrWhiteSpace(passwordField.Text))
            {
                return "Все поля должны быть заполнены";
            }

            Regex regexLenght = new Regex("^(?=.{2,50}$)");
            Regex regexLenght2 = new Regex("^(?=.{5,50}$)");

            // first name check
            if (!regexLenght.Match(firstNameField.Text).Success)
            {
                return "Длина фамилии от 2 до 50 символов";
            }

            // name check
            if (!regexLenght.Match(nameField.Text).Success)
            {
                return "Длина имени от 2 до 50 символов";
            }

            // login check
            if (!regexLenght2.Match(loginField.Text).Success)
            {
                return "Длина логина от 5 до 50 символов";
            }

            // password check
            if (!regexLenght2.Match(passwordField.Text).Success)
            {
                return "Длина пароля от 5 до 50 символов";
            }

            // confirm password check
            if (!passwordField.Text.Equals(confirmPasswordField.Text))
            {
                return "Пароли должны совпадать";
            }

            return "ok";
        }
    }
}
