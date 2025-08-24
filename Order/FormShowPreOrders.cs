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
    public partial class FormShowPreOrders : Form
    {
        int CustomerId;
        public FormShowPreOrders(int customerId)
        {
            InitializeComponent();
            CustomerId = customerId;
            List<ClsOrder> clsOrders=ClsOrder.GetPreOrdersAsList(customerId);
            DisplayProducts(clsOrders);
        }
        private void DisplayProducts(List<ClsOrder> clsOrders)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var clsOrder in clsOrders)
            {

                GroupBox groupBox = new GroupBox
                {
                    Width = 200,
                    Height = 200,
                    
                   
                    Padding = new Padding(5),
                    Margin = new Padding(10)
                };


             

                Label lblId = new Label
                {
                    Text = "ID:" + clsOrder.OrderID.ToString(),
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    Location = new Point(10, 50),
                    AutoSize = true
                };
                Label lblPrice = new Label
                {
                    Text = clsOrder.Date.ToString(),
                    Font = new Font("Arial", 10, FontStyle.Regular),
                    Location = new Point(10, 100),
                    AutoSize = true
                };


                Button btnBuy = new Button
                {
                    Text = "Show Products",
                    Size = new Size(100, 30),
                    Location = new Point(50, 150),
                    BackColor = Color.LightGreen
                };


                btnBuy.Click += (sender, e) =>
                {
                    FormShowProductsOfAnOrder formShowProductsOfAnOrder = new FormShowProductsOfAnOrder(clsOrder.OrderID);
                    formShowProductsOfAnOrder.ShowDialog();



                };




                
                groupBox.Controls.Add(lblPrice);
                groupBox.Controls.Add(btnBuy);
                groupBox.Controls.Add(lblId);


                flowLayoutPanel1.Controls.Add(groupBox);
            }
        }
        private void FormShowPreOrders_Load(object sender, EventArgs e)
        {
           
        }
    }
}
