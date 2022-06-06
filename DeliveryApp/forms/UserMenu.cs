using DeliveryApp;
using PracticeApp.forms;
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
    public partial class UserMenu : Form
    {
        private users _user;
        private DeliveryEntities _deliveryEntities = Constants.deliveryModel;
        private DataTable _cartTable = new DataTable();

        public UserMenu(users user)
        {
            InitializeComponent();

            this._user = user;

            init();

            settingRatings();
        }

        private void init()
        {
            // menu source
            dishesBindingSource.Filter = "menu_id = 1";

            // cart table
            _cartTable.Columns.Add("Позиция", typeof(int));
            _cartTable.Columns.Add("Название блюда", typeof(string));
            _cartTable.Columns.Add("Меню", typeof(string));
            _cartTable.Columns.Add("Цена (руб.)", typeof(float));

            // menu data grid
            menuDataGrid.DefaultCellStyle.ForeColor = Color.Black;

            // cart data grid
            cartGridView.DefaultCellStyle.ForeColor = Color.Black;
            cartGridView.DataSource = _cartTable;

            // total sum label
            totalSum.Text = "0 руб.";

            // payment method combo box
            paymentMethod.Text = "Наличные";
        }

        // rating settings
        private void settingRatings()
        {
            foreach (DataRow row in menuDataGrid.Rows)
            {
                Console.WriteLine(row[3]);

                /*if (row.Cells[3].Value.Equals(null))
                {
                    row.Cells[3].Value = "Нет оценок";
                }*/
            }
        }

        // user profile open
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new UserProfile(_user));
        }

        // filtering menu
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = menuComboBox.SelectedIndex + 1;
            dishesBindingSource.Filter = "menu_id = " + index;
        }

        // adding dish to cart
        private void button1_Click(object sender, EventArgs e)
        {
            int currentRowIndex = menuDataGrid.CurrentCell.RowIndex;

            _cartTable.Rows.Add(
                menuDataGrid.Rows[currentRowIndex].Cells[0].Value.ToString(),
                menuDataGrid.Rows[currentRowIndex].Cells[1].Value.ToString(),
                menuComboBox.SelectedValue.ToString(),
                menuDataGrid.Rows[currentRowIndex].Cells[2].Value.ToString());

            float sum = 0;
            foreach (DataRow row in _cartTable.Rows)
            {
                sum += float.Parse(row[3].ToString());
            }

            totalSum.Text = sum + " руб.";
        }

        // order click
        private void button2_Click(object sender, EventArgs e)
        {
            if (_cartTable.Rows.Count == 0)
            {
                return;
            }

            String payment = "cash";
            if (paymentMethod.Text.Equals("Карта"))
            {
                payment = "card";
            }

            var order = new orders
            {
                customer_id = _user.id,
                time = DateTime.Now,
                comment = commentTextBox.Text,
                payment_method = payment,
                issue_point = 1,
                card_id = null  // TODO: add card
                
            };

            _deliveryEntities.orders.Add(order);
            _deliveryEntities.SaveChanges();

            int dishId;
            foreach (DataRow row in _cartTable.Rows)
            {
                dishId = int.Parse(row[0].ToString());
                _deliveryEntities.orders_dishes.Add(new orders_dishes { 
                    order_id = order.id, 
                    dish_id = dishId });

            }

            _deliveryEntities.SaveChanges();

            totalSum.Text = "";
            _cartTable.Clear();
            MessageBox.Show("Заказ принят");
        }

        // delete dish click
        private void button3_Click(object sender, EventArgs e)
        {
            if (cartGridView.CurrentCell is null)
            {
                return;
            }

            _cartTable.Rows.Remove(_cartTable.Rows[cartGridView.CurrentRow.Index]);

            float sum = 0;
            foreach (DataRow row in _cartTable.Rows)
            {
                sum += float.Parse(row[3].ToString());
            }

            totalSum.Text = sum + " руб.";
        }

        // clear cart click
        private void button4_Click(object sender, EventArgs e)
        {
            _cartTable.Clear();
            totalSum.Text = "0 руб.";
        }

        // cart filtering by menu
        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (menuFilterComboBox.SelectedValue == null)
            {
                return;
            }
            filterCart();
        }

        // cart filtering by name
        private void nameFilterTextBox_TextChanged(object sender, EventArgs e)
        {
            filterCart();
        }

        // enable/disable filter by menu
        private void menuFilterCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            menuFilterComboBox.Enabled = menuFilterCheckBox.Checked;
            filterCart();
        }

        // enable/disable filter by name
        private void nameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            nameFilterTextBox.Enabled = nameCheckBox.Checked;
            filterCart();
        }

        // filtering method
        private void filterCart()
        {
            string command = "";
            bool menu = menuFilterCheckBox.Checked;
            bool name = nameCheckBox.Checked;

            if (menu)
            {
                command += $"[Меню] = '{menuFilterComboBox.SelectedValue}' and ";
            }
            if (name)
            {
                command += $"[Название блюда] like '%{nameFilterTextBox.Text}%' and ";
            }

            // deleting extra 'and'
            if (!command.Equals(""))
            {
                command = command.Substring(0, command.Length - 5);
            }

            ((DataTable)cartGridView.DataSource).DefaultView.RowFilter = command;
        }

        private void UserMenu_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deliveryDataSet1.dishes". При необходимости она может быть перемещена или удалена.
            this.dishesTableAdapter.Fill(this.deliveryDataSet1.dishes);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "deliveryDataSet1.menu". При необходимости она может быть перемещена или удалена.
            this.menuTableAdapter.Fill(this.deliveryDataSet1.menu);

        }
    }
}
