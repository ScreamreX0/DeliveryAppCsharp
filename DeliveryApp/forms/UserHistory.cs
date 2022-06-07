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
    public partial class UserHistory : Form
    {
        private users _user;
        private DataTable _detailsTable = new DataTable();
        private DataTable _orders = new DataTable();
        private DeliveryEntities _deliveryEntities = Constants.deliveryModel;
        public UserHistory(users user)
        {
            InitializeComponent();

            this._user = user;

            init();
        }

        private void init()
        {
            // details data grid
            detailsGridView.DefaultCellStyle.ForeColor = Color.Black;

            // orders data grid
            _orders.Columns.Add("Номер", typeof(int));
            _orders.Columns.Add("Дата", typeof(string));

            // history data grid
            historyGridView.DefaultCellStyle.ForeColor = Color.Black;
            historyGridView.DataSource = _orders;

            foreach (taken_orders row in _deliveryEntities.taken_orders.ToList())
            {
                if (row.arrive_date == null)
                {
                    continue;
                }

                _orders.Rows.Add(
                    row.order_id,
                    row.arrive_date
                );
            }

            _detailsTable.Columns.Add("Название блюда", typeof(string));
            _detailsTable.Columns.Add("Цена (руб.)", typeof(float));

            detailsGridView.DataSource = _detailsTable;
        }

        // profile open
        private void backButton_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new UserProfile(_user));
        }

        // details fill
        private void historyGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (historyGridView.CurrentCell == null)
            {
                return;
            }

            _detailsTable.Clear();

            int current_order_id = int.Parse(historyGridView.CurrentRow.Cells[0].Value.ToString());

            foreach (orders_dishes od in _deliveryEntities.orders_dishes.ToList())
            {
                if (od.order_id != current_order_id)
                {
                    continue;
                }


                foreach (dishes d in _deliveryEntities.dishes)
                {
                    if (d.id == od.dish_id)
                    {
                        _detailsTable.Rows.Add(
                            d.name,
                            d.price
                        );
                    }
                }
            }
        }
    }
}
