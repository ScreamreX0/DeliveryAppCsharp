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
    public partial class About : Form
    {
        private users _user;
        
        public About(users user)
        {
            InitializeComponent();
            this._user = user;
        }

        // user profile open
        private void label2_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new UserProfile(_user));
        }

        // website open
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://almetpt.ru/");
        }
    }
}
