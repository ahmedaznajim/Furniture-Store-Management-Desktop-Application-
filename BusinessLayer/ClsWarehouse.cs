using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class ClsWarehouse
    {
        public string WarehouseLocation {  get; set; }
        public string warehouseSize { get; set; }
        public int EmployeeID { get; set; }

        public static int AddNewWarehouse(string WarehouseLocation, int warehouseSize,
       int EmployeeID)
        {
            return ClsWarehouseDataAccess.AddNewWarehouse(WarehouseLocation, warehouseSize, EmployeeID);

        }
        public static DataTable GetAllWarehouse()
        {
          return  ClsWarehouseDataAccess.GetAllWarehouse();

        }
        public static bool DeleteWarehouse(int ID)
        {
           return ClsWarehouseDataAccess.DeleteWarehouse(ID);


        }


        public static DataTable ShowProducts(int WarehousID)
        {
            return ClsWarehouseDataAccess.ShowProducts (WarehousID);


        }
        public static DataTable GetWareHousesNamesById()
        {
            return ClsWarehouseDataAccess.GetWareHousesNamesById();

        }
        }
}
