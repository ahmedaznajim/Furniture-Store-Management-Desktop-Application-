using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace furnitureStoreV2
{
    public partial class FormInterFace : Form
    {
        public FormInterFace()
        {
            InitializeComponent();
        }

        private void buttonCustomer_Click(object sender, EventArgs e)
        {


            FormLogCustomer formLogCustomer = new FormLogCustomer();
            formLogCustomer.ShowDialog();
            this.Hide();
            
        }

        private void buttonEmployee_Click(object sender, EventArgs e)
        {
            FormLogEmployee formLogEmployee = new FormLogEmployee();
            formLogEmployee.ShowDialog();
            this.Hide();
        }
    }
}
