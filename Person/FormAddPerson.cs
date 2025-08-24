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
    public partial class FormAddPerson : Form
    {
        public FormAddPerson()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
           if( ClsPersonBuinessLayer.AddNewPerson(textBoxFname.Text, textBoxLname.Text, textBoxPhone.Text, textBoxEmail.Text)==-1) {
                MessageBox.Show("Faild");
            
            } else
            {
                MessageBox.Show("Done");
                this.Hide();


            }
        }
    }
}
