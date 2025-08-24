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
    public partial class ShowProductInfo : UserControl
    {
        public ShowProductInfo()
        {
            InitializeComponent();
        }

        private void ShowProductInfo_Load(object sender, EventArgs e)
        {
            
        }

       public  void LoadInformation(int id,string ProductName,
            int Quantity, int PriceInJod, int Availabilty,string Image)
        {
            labelProductID.Text = id.ToString();
            labelProductName.Text = ProductName.ToString();
            labelQuantity.Text = Quantity.ToString();
            labelPriceInJod.Text = PriceInJod.ToString();
            labelAvailabilty.Text = Availabilty.ToString();
            pictureBox1.ImageLocation = Image;
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
