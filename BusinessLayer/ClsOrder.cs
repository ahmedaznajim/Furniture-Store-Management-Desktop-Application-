using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class ClsOrder
    {
        public int OrderID { get; set; }
        public int CustomerID {  get; set; }
        public DateTime Date{ get; set; }


        public static int AddNewOrder(int ID,DateTime Date)
        {
            return ClsOrderDataAccess.AddNewOrder(ID,Date);



        }

        public static DataTable GetAllOrders()
        {
            return ClsOrderDataAccess.GetAllOrders();


        }
        public static bool DeleteCustomer(int ID)
        {
            return ClsOrderDataAccess.DeleteOrder(ID);


        }
        public static int AddProductToMuOrder(int ProductID, int OrderId, int Quantity)
        {
            return ClsOrderDataAccess.AddProductToMuOrder(OrderId, ProductID, Quantity);


        }

        public static DataTable GetCurrentOrder(int CustomerID)
        {
            return ClsOrderDataAccess.GetCurrentOrder(CustomerID);

        }
        public static DataTable GetPREOrders(int CustumerId)
        {
            return ClsOrderDataAccess.GetPREOrders(CustumerId);


        }

        public static List<ClsOrder> GetPreOrdersAsList(int CustumerId)
        {
            DataTable dataTable= ClsOrderDataAccess.GetPREOrders(CustumerId);
            List<ClsOrder> orders = new List<ClsOrder>();
            foreach (DataRow dataRow in dataTable.Rows)
            {
                ClsOrder order = new ClsOrder();
                order.OrderID = Convert.ToInt32(dataRow[0]);
                order.CustomerID = Convert.ToInt32(dataRow[1]);
                order.Date = Convert.ToDateTime(dataRow[2]);
                orders.Add(order);
            }

            return orders;

        }
        public static DataTable GetAllOrdersProducts(int OrderID)
        {
            return ClsOrderDataAccess.GetAllOrdersProducts(OrderID);
        }
    }
}
