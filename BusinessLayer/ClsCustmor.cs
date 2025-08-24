using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLayer
{
    public class ClsCustmor
    {
        public int CustomerID {  get; set; }
        public int Id { get; set; }
        public string UserName { get; set; }
public string Password { get; set; }

        public static int AddNewCustomer(int ID, string UserName, string Password)
        {
            return  ClsCustomerDataAccess.AddNewCustomer(ID,UserName, Password);



        }

        public static DataTable GetAllCustomers()
        {
            return ClsCustomerDataAccess.GetAllCustomers();


        }
        public static bool DeleteCustomer(int ID)
        {
         return   ClsCustomerDataAccess.DeleteCustomer(ID);


        }
        public static int CheckCustomerogInInfo(string CustomerUserName, string CustomerPassword)
        {
            DataTable dt = ClsCustomerDataAccess.CustomereLogInInfo(CustomerUserName);

            try
            {

                DataRow dr = dt.Rows[0];
                string temp1 = dr[3].ToString();
                string temp2 = "";
                for (int i = 0; i < (dr[3].ToString().Length); i++)
                {
                    if (temp1[i] == ' ')
                    {
                        break;

                    }
                    else
                    {
                        temp2 = temp2 + temp1[i];


                    }




                }

                if (dr != null)
                {
                    if (temp2 == CustomerPassword)
                    {
                        return Convert.ToInt32(dr[0]);

                    }


                }

            }
            catch (Exception ex)
            {
             


            }
            return -1;



        }

        public static int SighnUP (string FirstName, string LastName, String Email,
            string PhoneNumber, string UserName, string Password)
        {
            int id = ClsPersonBuinessLayer.AddNewPerson(FirstName, LastName, Email, PhoneNumber);
            int CustomerId=ClsCustmor.AddNewCustomer(id, UserName, Password);
           return CustomerId;



        }

        public static DataTable SerchID(int ID)
        {
            return ClsCustomerDataAccess.SerchID(ID);
        }

        public static DataTable SerchUserName(string UserName)
        {
            return ClsCustomerDataAccess.SerchUserName(UserName);
        }

        public static DataTable SerchLastName(string LastName)
        {
            return ClsCustomerDataAccess.SerchLastName(LastName);
        }


    }
}
