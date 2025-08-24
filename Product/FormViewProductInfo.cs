using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace furnitureStoreV2.Product
{
    public partial class FormViewProductInfo : Form
    {
        public FormViewProductInfo(int id, string ProductName,
            int Quantity, int PriceInJod, int Availabilty, string Image)
        {
            InitializeComponent();
            label1.Text = "ID= "+id.ToString();
            labelProductName.Text = "ProductName= "+ ProductName.ToString();
            labelQuantity.Text = "Quantity= "+Quantity.ToString();
            labelPriceInJod.Text = PriceInJod.ToString()+"JD";
            if (Availabilty == 0)
            {
                labelAvailabilty.Text = "NOt Available";
            }
            else
            {
                labelAvailabilty.Text = " Available";
            }
           
            pictureBox1.ImageLocation = Image;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void labelAvailabilty_Click(object sender, EventArgs e)
        {

        }
    }
}
