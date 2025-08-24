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

namespace furnitureStoreV2.Product
{
    public partial class FormShowCurrtentOrders : Form
    {
        List<int> OrderProductsIDs = new List<int>();
        int CustomerID;
        public FormShowCurrtentOrders(List<int> OrderProductsIDs, int customerID)
        {
            InitializeComponent();
            this.OrderProductsIDs = OrderProductsIDs;
            CustomerID = customerID;
        }
        private void DisplayProducts(List<int> OrderProductsIDs)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var OrderProductsID in OrderProductsIDs)
            {
                DataTable dataTable = ClsProduct.SerchID(OrderProductsID);
                DataRow dataRow = dataTable.Rows[0];

                GroupBox groupBox = new GroupBox
                {
                    Width = 200,
                    Height = 270,
                    Text = dataRow[1].ToString(),
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    Padding = new Padding(5),
                    Margin = new Padding(10)
                };


                PictureBox picBox = new PictureBox
                {
                    Width = 180,
                    Height = 120,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = Image.FromFile(dataRow[5].ToString()),
                    Location = new Point(10, 20)
                };

                Label lblId = new Label
                {
                    Text = "ID:" + dataRow[0].ToString(),
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    Location = new Point(10, 150),
                    AutoSize = true
                };
                Label lblPrice = new Label
                {
                    Text = "Price: JOD" + dataRow[3].ToString(),
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    Location = new Point(10, 180),
                    AutoSize = true
                };

                Button btnBuy = new Button
                {
                    Text = "Delete",
                    Size = new Size(100, 30),
                    Location = new Point(50, 200),
                    BackColor = Color.Red,
                };


                btnBuy.Click += (sender, e) =>
                {
                    OrderProductsIDs.Remove(OrderProductsID);
                    MessageBox.Show("Deleted");
                    DisplayProducts(OrderProductsIDs);


                };








                groupBox.Controls.Add(picBox);
                groupBox.Controls.Add(lblPrice);

                groupBox.Controls.Add(lblId);
                groupBox.Controls.Add(btnBuy);


                flowLayoutPanel1.Controls.Add(groupBox);
            }
        }
        private void FormShowPreOrders_Load(object sender, EventArgs e)
        {
            DisplayProducts(OrderProductsIDs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (OrderProductsIDs.Count == 0)
            {
                MessageBox.Show("No Products Selected");
                return;
            }
            else
            {
                try
                {
                    int OrderID = ClsOrder.AddNewOrder(CustomerID, DateTime.Now);
                    foreach (var OrderProductsID in OrderProductsIDs)
                    {
                        ClsOrder.AddProductToMuOrder(OrderID, OrderProductsID, 1);
                    }
                    OrderProductsIDs.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    MessageBox.Show("Done");
                    this.Close();
                }
            }
        }
    }
}
