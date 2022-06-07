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
    public partial class Applications : Form
    {
        private users _user;
        private DeliveryEntities _deliveryEntities = Constants.deliveryModel;

        public Applications(users user, string theme)
        {
            InitializeComponent();

            this._user = user;
            themeComboBox.Text = theme;
        }
        
        // menu open
        private void label2_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new UserMenu(_user));
        }

        // send application click
        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_user.address) || string.IsNullOrEmpty(_user.phone_number))
            {
                MessageBox.Show("Пожалуйста, внесите свой адрес прописки и номер телефона в профиле");
                return;
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Все поля должны быть заполнены");
                return;
            }

            int type = 2;
            if (themeComboBox.Text.Equals("Заявка на трудоустройство"))
            {
                type = 1;
            }

            var application = new applications
            {
                sender = _user.id,
                type = type,
                text = textBox1.Text
            };

            _deliveryEntities.applications.Add(application);
            _deliveryEntities.SaveChanges();

            MessageBox.Show("Отзыв успешно отправлен");
            textBox1.Text = "";
        }
    }
}
