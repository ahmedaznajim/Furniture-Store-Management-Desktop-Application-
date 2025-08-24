using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using static System.Net.Mime.MediaTypeNames;

namespace BusinessLayer
{
    public class ClsProduct
    {
        public int ID { get; set; }
        public string ProductName { get; set; }
        public int Quantity
        {
            get; set;
        }
        public int Price { get; set; }

        public int availabilty{ get; set; }

        public string image { get; set; }


        public static int AddNewProduct(string ProductName, int Quantity,
       int Price, int stock, string image)
        {
            return ClsproductDataAccess.AddNewProduct(ProductName, Quantity, Price, stock,image);


        }

        public static DataTable GetAllproducts()
        {
            return ClsproductDataAccess.GetAllproducts();

        }
        public static bool Deleteproduct(int ID)
        {
            return ClsproductDataAccess.Deleteproduct(ID);

        }
        public static int Store(int Quantity, int ProductID, int WarehousID)
        {

            return ClsproductDataAccess.Store(Quantity, ProductID, WarehousID);

        }

        public static List<ClsProduct> GetProductsAsList()
        {
            List<ClsProduct> p=new List<ClsProduct>();
            DataTable dt = ClsProduct.GetAllproducts();
          

            foreach (DataRow dr in dt.Rows)
            {
                ClsProduct Product = new ClsProduct() 
                {
                    ID = Convert.ToInt32( dr[0]),
                    ProductName = dr[1].ToString(),
                    Quantity = Convert.ToInt32(dr[2]),
                    Price = Convert.ToInt32(dr[3]), 
                    availabilty = Convert.ToInt32(dr[4]),
                    image = dr[5].ToString()
                };
                p.Add(Product);
                



            }

            return p;
        }
        public static DataTable SerchID(int ID)
        {
            return ClsproductDataAccess.SerchID(ID);
        }
        public static DataTable SerchName(string Name)
        {
            return ClsproductDataAccess.SerchName(Name);
        }


    }
}
