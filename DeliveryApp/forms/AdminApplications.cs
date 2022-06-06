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
    public partial class AdminApplications : Form
    {
        DataTable table = new DataTable();
        DeliveryEntities deliveryEntities = new DeliveryEntities();
        users user;
        public AdminApplications(users user)
        {
            InitializeComponent();

            this.user = user;

            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;

            // Добавление колонок в таблицу
            table.Columns.Add("Номер");
            table.Columns.Add("Отправитель");
            table.Columns.Add("Тип");
            table.Columns.Add("Заявка");

            // Добавление данных в таблицу
            foreach (applications application in deliveryEntities.applications)
            {
                table.Rows.Add(application.id,
                    application.users.login,
                    application.type,
                    application.text);
            }

            dataGridView1.DataSource = table;
        }

        // admin menu open
        private void label2_Click(object sender, EventArgs e)
        {
            FormsHelper.openForm(this, new AdminMenu(user));
        }
    }
}
