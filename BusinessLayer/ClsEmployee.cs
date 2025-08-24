using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessLayer;
namespace BusinessLayer
{
    public class ClsEmployee
    {
        public int ID { get; set; }
        public string Position { get; set; }
        public float Salary { get; set; }
        public int CustomerID { get; set; }
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }


        public static int AddNewEmployee(int ID, string Position, int Salary, string UserName, string Password)
        {
    return  ClsEmployeeDataAccess.AddNewEmployee(ID, Position, Salary,UserName, Password);



        }

        public static DataTable GetAllEmployees()
        {
            return ClsEmployeeDataAccess.GetAllEmployees();


        }
        public static bool DeleteEmployee(int ID)
        {
            return ClsEmployeeDataAccess.DeleteEmployee(ID);


        }

        public static bool UpdateEmployee(int ID, string Position, int Salary, string employeeUserName, string employeePassword)
        {
            return ClsEmployeeDataAccess.UpdateEmployee(ID, Position, Salary, employeeUserName, employeePassword);

        }

        public static bool CheckEmployeeLogInInfo(string EmployeeUserName, string EmployeePassword)
        {
           DataTable dt = ClsEmployeeDataAccess.EmployeeLogInInfo(EmployeeUserName);
            try
            {
                if (dt.Rows[0] == null)
                {
                    return false;


                }
                DataRow dr = dt.Rows[0];
                string temp1 = dr[1].ToString();
                string temp2 = "";
                for (int i = 0; i < (dr[1].ToString().Length); i++)
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
                    if (temp2 == EmployeePassword)
                    {
                        return true;

                    }

                }

            }
            catch (Exception ex)
            {

            }
            
            return false;



        }


    }
}
