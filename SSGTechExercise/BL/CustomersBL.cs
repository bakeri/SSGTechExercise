using System;
using System.Collections.Generic;
using SSGTechExercise.Models;
using System.Linq;

namespace SSGTechExercise.BL
{
    public class CustomersBL
    {
        public List<Models.Customer> returnAll()
        {
            CustomersContext _db = new CustomersContext();
            List<Customer> lsCustomers = _db.Customer.ToList();
            Colour cl = new Colour();
            foreach (Customer cust  in lsCustomers)
            {
                RealClock realClock = new RealClock();
                cust.Age = calculateAge(cust.DOB,realClock);
              
                cust.RowColour = cl.getRandomColour(cust.Fisrtname + cust.LastName);
            }
            return lsCustomers;
        }

        public int calculateAge(DateTime DOB,IDate datei)
        {
            int age;
            age = datei.Now.Year - DOB.Year;
            if (datei.Now.DayOfYear < DOB.DayOfYear) age--;
            return age;
        }
       

       

     
    }
}