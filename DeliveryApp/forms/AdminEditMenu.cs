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
    public partial class AdminEditMenu : Form
    {
        private users _user;
        private DeliveryEntities _deliveryEntities = Constants.deliveryModel;
        public AdminEditMenu(users user)
        {
            InitializeComponent();

            init();

            this._user = user;
        }

        private void init()
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView2.DefaultCellStyle.ForeColor = Color.Black;

            dishesBindingSource.Filter = "menu_id = 1";
        }

        // admin menu open
        private void label2_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminMenu(_user));
        }

        private void AdminEditMenu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter.Fill(this.deliveryDataSet.dishes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.menu". При необходимости она может быть перемещена или удалена.
            this.menuTableAdapter.Fill(this.deliveryDataSet.menu);

        }

        // save changes click
        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            dishesBindingSource.EndEdit();
            this.dishesTableAdapter.Update(this.deliveryDataSet.dishes);
        }

        // filtering dishes by menu
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = (int)dataGridView2.CurrentRow.Cells[0].Value;
            dishesBindingSource.Filter = "menu_id = " + index;
        }

        // filtering menu by name
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            menuBindingSource.Filter = $"name like '%{textBox1.Text}%'";
        }

        // filtering dishes by name
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            dishesBindingSource.Filter = $"name like '%{textBox2.Text}%'";
        }
    }
}
