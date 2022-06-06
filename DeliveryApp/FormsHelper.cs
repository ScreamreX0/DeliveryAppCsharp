using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeliveryApp
{
    internal class FormsHelper
    { 
        public static void openForm(Form context, Form newForm)
        {
            newForm.Location = context.Location;
            newForm.StartPosition = FormStartPosition.Manual;
            context.Hide();
            newForm.Show();
        }
    }
}
