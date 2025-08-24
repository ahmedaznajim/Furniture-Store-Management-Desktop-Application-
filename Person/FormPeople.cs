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
    public partial class FormPeople : Form
    {
        public FormPeople()
        {
            InitializeComponent();

        }

        private void FormPeople_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ClsPersonBuinessLayer.GetAllPeople();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormAddPerson formAddPerson = new FormAddPerson();
            formAddPerson.ShowDialog();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                FormUpdate update = new FormUpdate(
                     Convert.ToInt32(selectedRow.Cells[0].Value),
                    Convert.ToString(selectedRow.Cells[1].Value),
                    Convert.ToString(selectedRow.Cells[2].Value),
                    Convert.ToString(selectedRow.Cells[3].Value),
                    Convert.ToString(selectedRow.Cells[4].Value)


                );

                update.ShowDialog();
                dataGridView1.DataSource = ClsPersonBuinessLayer.GetAllPeople();
            }
            else
            {
                MessageBox.Show("Please select a row first.");
            }
        }







        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ClsPersonBuinessLayer.GetAllPeople();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                if (ClsPersonBuinessLayer.DeletePerson(Convert.ToInt32(selectedRow.Cells[0].Value)))
                {
                    MessageBox.Show("Done");
                    dataGridView1.DataSource = ClsPersonBuinessLayer.GetAllPeople();

                }
                else
                {
                    MessageBox.Show("Faild");
                }
            }
            catch
            {
                MessageBox.Show("Select a complete Row");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1 || comboBox1.SelectedIndex == 2)
            {
                textBoxSerch.Enabled = true;
            }
            if (comboBox1.SelectedIndex == 0)
            {
                textBoxSerch.Enabled = false;
                textBoxSerch.Text = "";
                dataGridView1.DataSource = ClsPersonBuinessLayer.GetAllPeople();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                dataGridView1.DataSource = ClsPersonBuinessLayer.SerchID(
               Convert.ToInt32(textBoxSerch.Text));
            }

            if (comboBox1.SelectedIndex == 2)
            {
                dataGridView1.DataSource = ClsPersonBuinessLayer.SerchLastName(Convert.ToString(textBoxSerch.Text));
            }

        }

        private void textBoxSerch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
