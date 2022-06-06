using DeliveryApp;
using DeliveryApp.forms;
using PracticeApp.forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeApp
{
    public partial class Auth : Form
    {
        private bool _eyeIsClosed;
        private DeliveryEntities _deliveryEntities = Constants.deliveryModel;
        public Auth()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            // password field
            passwordField.Text = "";
            passwordField.PasswordChar = '*';
            passwordField.MaxLength = 50;

            // picture box
            pictureBox1.Image = Image.FromFile(Path.Combine("..\\..\\assets\\closed eye.png"));

            // eye
            _eyeIsClosed = true;
        }

        // eye click
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (_eyeIsClosed)
            {
                pictureBox1.Image = Image.FromFile(Path.Combine("..\\..\\assets\\opened eye.png"));
                passwordField.PasswordChar = '\0';
                _eyeIsClosed = false;
            } 
            else
            {
                pictureBox1.Image = Image.FromFile(Path.Combine("..\\..\\assets\\closed eye.png"));
                passwordField.PasswordChar = '*';
                _eyeIsClosed = true;
            }
        }

        // enter click
        private void enterButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(loginField.Text) || String.IsNullOrWhiteSpace(passwordField.Text))
            {
                errorLabel.Text = "Все поля должны быть заполнены";
                return;
            }


            var user = _deliveryEntities
                .users
                .ToList()
                .FirstOrDefault(param => param.login.Equals(loginField.Text) && param.password.Equals(passwordField.Text));

            if (user is null)
            {
                errorLabel.Text = "Неверный логин или пароль";
                return;
            }


            if (user.roles.id == 1)  // admin
            {
                FormsHelper.openForm(this, new AdminMenu(user));
            }
            else if (user.roles.id == 2)  // customer
            {
                FormsHelper.openForm(this, new UserMenu(user));
            }
            else if (user.roles.id == 3) // courier
            {
                // TODO: add couriers forms
            }
            else
            {
                errorLabel.Text = "Неверная роль пользователя";
                return;
            }
        }

        // reg click
        private void regButton_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new Registration());
        }
    }
}
