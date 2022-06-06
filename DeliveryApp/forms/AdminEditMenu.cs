using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryApp.forms
{
    public partial class AdminEditMenu : Form
    {
        public AdminEditMenu()
        {
            InitializeComponent();
        }

        private void AdminEditMenu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deliveryDataSet.dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter.Fill(this.deliveryDataSet.dishes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deliveryDataSet.menu". При необходимости она может быть перемещена или удалена.
            this.menuTableAdapter.Fill(this.deliveryDataSet.menu);

        }
    }
}
