using DeliveryApp;
using DeliveryApp.forms;
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
    public partial class AdminMenu : Form
    {
        users user;
        public AdminMenu(users user)
        {
            InitializeComponent();

            this.user = user;

            // Установка заголовка страницы
            this.Text = "DeliveryApp (Администратор " + user.first_name + " " + user.last_name + ")";
        }
    }
}
