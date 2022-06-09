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
    public partial class AdminChartOrders : Form
    {
        users _user;
        public AdminChartOrders(users _user)
        {
            InitializeComponent();

            this._user = _user;

            init();
        }

        private void init() 
        { 
            buttonOrders.Enabled = false;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminMenu(_user));
        }
    }
}
