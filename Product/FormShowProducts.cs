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
using furnitureStoreV2.Order;
using furnitureStoreV2.Product;
using furnitureStoreV2.Properties;

namespace furnitureStoreV2
{
    public partial class FormShowProducts : Form
    {
        int OrderId;
        int CustumerId;
        List<int> OrderProductsIDs = new List<int>();


        private void DisplayProducts(List<ClsProduct> products)
        {
            flowLayoutPanel1.Controls.Clear(); 

            foreach (var product in products)
            {
               
                GroupBox groupBox = new GroupBox
                {
                    Width = 200,
                    Height = 270,
                    Text = product.ProductName, 
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Padding = new Padding(5),
                    Margin = new Padding(10)
                };

         
                PictureBox picBox = new PictureBox
                {
                    Width = 180,
                    Height = 120,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = Image.FromFile(product.image),
                    Location = new Point(10, 20) 
                };

                Label lblId = new Label
                {
                    Text = "ID:" + product.ID .ToString(),
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    Location = new Point(10, 150),
                    AutoSize = true
                };
                Label lblPrice = new Label
                {
                    Text = "Price: $" + product.Price.ToString("F2"),
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    Location = new Point(10, 180),
                    AutoSize = true
                };

              
                Button btnBuy = new Button
                {
                    Text = "Buy Now",
                    Size = new Size(100, 30),
                    Location = new Point(50, 200),
                    BackColor = Color.LightGreen
                };

             
                btnBuy.Click += (sender, e) =>
                {
                    OrderProductsIDs.Add(product.ID);
                    MessageBox.Show("Done");



                };

               


                groupBox.Controls.Add(picBox);
                groupBox.Controls.Add(lblPrice);
                groupBox.Controls.Add(btnBuy);
                groupBox.Controls.Add(lblId);
                

                flowLayoutPanel1.Controls.Add(groupBox);
            }
        }

        public FormShowProducts(int CustumerId)
        {
            InitializeComponent();




            DisplayProducts(ClsProduct.GetProductsAsList());
           
            this.CustumerId = CustumerId;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void FormShowProducts_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonShowMyOrder_Click(object sender, EventArgs e)
        {

            FormCurrentOrder f = new FormCurrentOrder(OrderId); 
            f.ShowDialog();
        }

        private void showMyPrevousToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormShowCurrtentOrders formShowPreOrders = new FormShowCurrtentOrders(OrderProductsIDs,CustumerId);
            formShowPreOrders.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormShowPreOrders formShowPreOrders = new FormShowPreOrders( CustumerId);
            formShowPreOrders.ShowDialog();
        }
    }
}
