﻿using System;
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
            //var model = _db.Customer.ToList();
            foreach (Customer cust  in lsCustomers)
            {
                cust.Age = calculateAge(cust.DOB);
                cust.RowColour = getColour(cust.Fisrtname + cust.LastName);
            }
            return lsCustomers;
        }

        private int calculateAge(DateTime DOB)
        {
            int age;
            age = DateTime.Now.Year - DOB.Year;
            if (DateTime.Now.DayOfYear < DOB.DayOfYear) age--;
            return age;
        }
        private int getColour(string FullName)
        { 
            int colour;
            colour = 7;

            return colour;
        }
           
    }
}