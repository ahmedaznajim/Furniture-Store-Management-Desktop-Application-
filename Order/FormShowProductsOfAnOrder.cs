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

namespace furnitureStoreV2.Order
{
    public partial class FormShowProductsOfAnOrder : Form
    {
        int OrderId;

        public List<int> ProductsIDs(int OrderId) { 
        List<int> productsIDs;
       DataTable DataTable = ClsOrder.GetAllOrdersProducts(OrderId);
            productsIDs = new List<int>();
            foreach (DataRow row in DataTable.Rows)
            {
                productsIDs.Add(Convert.ToInt32(row["ProductID"]));
            }
            return productsIDs;






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

            







                groupBox.Controls.Add(picBox);
                groupBox.Controls.Add(lblPrice);

                groupBox.Controls.Add(lblId);
               


                flowLayoutPanel1.Controls.Add(groupBox);
            }
        }




        public FormShowProductsOfAnOrder(int orderId)
        {
            InitializeComponent();
            OrderId = orderId;
            DisplayProducts(ProductsIDs(OrderId));
        }

        private void FormShowProductsOfAnOrder_Load(object sender, EventArgs e)
        {

        }
    }
}
