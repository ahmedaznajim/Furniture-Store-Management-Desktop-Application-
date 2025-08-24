using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;

namespace furnitureStoreV2
{
    public partial class FormAddWarehouse : Form
    {
        DataTable dt = new DataTable();
        DataRow row1;
        public FormAddWarehouse()
        {
            InitializeComponent();
            dt = ClsEmployee.GetAllEmployees();
            foreach (DataRow row in dt.Rows)
            {
                comboBox1.Items.Add(row[1].ToString());


            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            try
            {
                row1 = dt.Rows[comboBox1.SelectedIndex];
                if (ClsWarehouse.AddNewWarehouse(textBoxLoc.Text, Convert.ToInt32(textBoxSize.Text), Convert.ToInt32(row1[0])) == -1)
                {
                    MessageBox.Show("Faild");

                }
                else
                {
                    MessageBox.Show("Done");
                    this.Hide();
                    this.Close();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Faild");
            }
        }

        private void FormAddWarehouse_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
