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
    public partial class AdminOrders : Form
    {
        private DataTable _ordersTable = new DataTable();
        private DeliveryEntities _deliveryEntities = Constants.deliveryModel;
        private users _user;
        public AdminOrders(users user)
        {
            InitializeComponent();
            this._user = user;
            init();
        }

        private void init() 
        {
            // orders grid view
            ordersGridView.DefaultCellStyle.ForeColor = Color.Black;

            // orders table
            _ordersTable.Columns.Add("Номер", typeof(int));
            _ordersTable.Columns.Add("Фамилия заказчика", typeof(string));
            _ordersTable.Columns.Add("Имя заказчика", typeof(string));
            _ordersTable.Columns.Add("Время заказа", typeof(string));
            _ordersTable.Columns.Add("Комментарий", typeof(string));
            _ordersTable.Columns.Add("Метод оплаты", typeof(string));
            _ordersTable.Columns.Add("Время доставки", typeof(string));

            _ordersTable.Columns[0].ReadOnly = true;
            _ordersTable.Columns[1].ReadOnly = true;
            _ordersTable.Columns[2].ReadOnly = true;
            _ordersTable.Columns[3].ReadOnly = true;
            _ordersTable.Columns[4].ReadOnly = true;
            _ordersTable.Columns[5].ReadOnly = true;
            _ordersTable.Columns[6].ReadOnly = true;

            // orders table fill
            foreach (orders order in _deliveryEntities.orders)
            {
                string name = "";
                string lastname = "";
                foreach (users userRow in _deliveryEntities.users)
                {
                    if (userRow.id == order.customer_id)
                    {
                        name = userRow.first_name;
                        lastname = userRow.last_name;
                        break;
                    }
                }

                string arriveDate = "";
                foreach (taken_orders takenOrderRow in _deliveryEntities.taken_orders)
                {
                    if (takenOrderRow.order_id == order.id)
                    {
                        if (takenOrderRow.arrive_date != null)
                        {
                            arriveDate = takenOrderRow.arrive_date.ToString();
                        }

                        break;
                    }
                }

                _ordersTable.Rows.Add(
                    order.id,
                    lastname,
                    name,
                    order.time,
                    order.comment,
                    order.payment_method,
                    arriveDate);
            }

            ordersGridView.DataSource = _ordersTable;

            IdTextBox.Enabled = false;
            LastNameTextBox.Enabled = false;
            NameTextBox.Enabled = false;
            PaymentMethodComboBox.Enabled = false;
            CommentTextBox.Enabled = false;
            OrderFromDatePicker.Enabled = false;
            OrderToDatePicker.Enabled = false;
        }

        // admin menu open
        private void label2_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminMenu(_user));
        }

        // filtering
        private void filterButton_Click(object sender, EventArgs e)
        {
            string command = "";

            if (checkBoxId.Checked && !string.IsNullOrWhiteSpace(IdTextBox.Text))
            {
                // Поиск по id
                command += $"[Номер] = '{IdTextBox.Text}' and ";
            }
            if (checkBoxCustomerName.Checked && !string.IsNullOrWhiteSpace(NameTextBox.Text))
            {
                // Поиск по Имени
                command += $"[Имя заказчика] like '%{NameTextBox.Text}%' and ";
            }
            if (checkBoxCustomerLastName.Checked && !string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                // Поиск по фамилии
                command += $"[Фамилия заказчика] like '%{LastNameTextBox.Text}%' and ";
            }
            if (checkBoxPaymentMethod.Checked)
            {
                // Поиск по методу оплаты
                command += $"[Метод оплаты] = '{PaymentMethodComboBox.Text}' and ";
            }
            if (checkBoxComment.Checked && !string.IsNullOrWhiteSpace(CommentTextBox.Text))
            {
                // Поиск по комменту
                command += $"[Комментарий] like '%{CommentTextBox.Text}%' and ";
            }
            if (checkBoxOrderDate.Checked)
            {
                // Поиск по времени заказа
                command += $"[Время заказа] >= '{OrderFromDatePicker.Text}'" +
                    $" and  [Время заказа] < '{OrderToDatePicker.Text}' and ";
            }

            if (string.IsNullOrEmpty(command))
            {
                ((DataTable)ordersGridView.DataSource).DefaultView.RowFilter = "";
                return;
            }

            command = command.Substring(0, command.Length - 4);
            ((DataTable)ordersGridView.DataSource).DefaultView.RowFilter = command;
        }

        private void checkBoxId_CheckedChanged(object sender, EventArgs e)
        {
            IdTextBox.Enabled = checkBoxId.Checked;
        }

        private void checkBoxCustomerLastName_CheckedChanged(object sender, EventArgs e)
        {
            LastNameTextBox.Enabled = checkBoxCustomerLastName.Checked;
        }

        private void checkBoxCustomerName_CheckedChanged(object sender, EventArgs e)
        {
            NameTextBox.Enabled = checkBoxCustomerName.Checked;
        }

        private void checkBoxPaymentMethod_CheckedChanged(object sender, EventArgs e)
        {
            PaymentMethodComboBox.Enabled = checkBoxPaymentMethod.Checked;
        }

        private void checkBoxComment_CheckedChanged(object sender, EventArgs e)
        {
            CommentTextBox.Enabled = checkBoxComment.Checked;
        }

        private void checkBoxOrderDate_CheckedChanged(object sender, EventArgs e)
        {
            OrderFromDatePicker.Enabled = checkBoxOrderDate.Checked;
            OrderToDatePicker.Enabled = checkBoxOrderDate.Checked;
        }
    }
}
