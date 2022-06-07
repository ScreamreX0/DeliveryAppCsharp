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
    public partial class AdminApplications : Form
    {
        private DataTable _applicationTable = new DataTable();
        private DeliveryEntities _deliveryEntities = Constants.deliveryModel;
        private users _user;
        public AdminApplications(users user)
        {
            InitializeComponent();

            this._user = user;

            init();
        }

        private void init()
        {
            // application table
            _applicationTable.Columns.Add("Номер");
            _applicationTable.Columns.Add("Отправитель");
            _applicationTable.Columns.Add("Тип");
            _applicationTable.Columns.Add("Заявка");

            foreach (applications application in _deliveryEntities.applications)
            {
                _applicationTable.Rows.Add(application.id,
                    application.users.login,
                    application.type,
                    application.text);
            }

            // data grid view
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.DataSource = _applicationTable;
        }

        // admin menu open
        private void label2_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminMenu(_user));
        }
    }
}
