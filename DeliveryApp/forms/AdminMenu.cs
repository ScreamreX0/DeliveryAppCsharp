using DeliveryApp;
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

namespace DeliveryApp
{
    public partial class AdminMenu : Form
    {
        private users _user;
        public AdminMenu(users user)
        {
            InitializeComponent();

            this._user = user;

            init();
        }

        private void init()
        {
            // forme title
            this.Text = "DeliveryApp (Администратор " + _user.first_name + " " + _user.last_name + ")";

            // picture box            
            pictureBox2.Image = Image.FromFile(Path.Combine("..\\..\\assets\\graph.png"));

        }

        // admin edit menu open
        private void button3_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminEditMenu(_user));
        }

        // admin orders open
        private void button4_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminOrders(_user));
        }

        // admin applicaitons open
        private void button2_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminApplications(_user));
        }

        // admin profile open
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminProfile(_user));
        }

        // Метод для открытия формы авторизации
        private void button1_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new Auth());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminChartComplaint(_user));
        }
    }
}
