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
    public partial class FormUpdate : Form
    {
        int ID;
        string FirstName;
        string LastName;
        string Phone;
        string Email;
        public FormUpdate(int ID,
          string FirstName,
          string LastName, string Phone, string Email)
        {
            InitializeComponent();
            this.ID = ID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
           label5.Text = ID.ToString();
            textBoxFname.Text = FirstName;
            textBoxLname.Text = LastName;
            textBoxPhone.Text = Email;
            textBoxEmail.Text = Phone;


        }

        private void FormUpdate_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if(ClsPersonBuinessLayer.UpdatePerson(ID, textBoxFname.Text,
                textBoxLname.Text, textBoxEmail.Text, textBoxPhone.Text))

            {
                MessageBox.Show("Done");
                this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Faild");


            }
        }
    };
}