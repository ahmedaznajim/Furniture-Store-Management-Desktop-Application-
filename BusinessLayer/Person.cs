using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;

namespace BusinessLayer
{
    public class ClsPersonBuinessLayer
    {
        

        public int ID {  get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public String Email {  get; set; }
        public string PhoneNumber { get; set; }

        public ClsPersonBuinessLayer(int ID, string FirstName, string LastName, String Email,
            string PhoneNumber)
        {
            this.ID = ID;
            this.FirstName = FirstName; 
            this.LastName = LastName;
               this.Email = Email;
            this.PhoneNumber = PhoneNumber;


        }


        public static DataTable GetAllPeople()
        {
 return clsPersonDataAccess.GetAllPeople();

        }
        public static int AddNewPerson(string FirstName, string LastName,
        string Phone, string Email)
        {
         return   clsPersonDataAccess.AddNewPerson(FirstName, LastName, Phone, Email);


        }
        public static bool UpdatePerson(int ID, string FirstName,
            string LastName, string Email, string PhoneNumber)
        {
            return clsPersonDataAccess.UpdatePerson(ID, FirstName,
             LastName, Email, PhoneNumber);


        }
        public static bool DeletePerson(int ID)
        {
            return clsPersonDataAccess.DeletePerson(ID);


        }
        public static DataTable SerchID(int ID)
        {
            return clsPersonDataAccess.SerchID(ID);
        }

        public static DataTable SerchLastName(String LName)
        {
            return clsPersonDataAccess.SerchLastName(LName);
        }

    }
}
