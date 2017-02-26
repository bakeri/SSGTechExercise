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
        private String getColour(string FullName)
        { 
           string strColour;
            Colour colourStruct;
           if (ColourDict.ContainsKey(FullName))
            {
                colourStruct = ColourDict[FullName];

            }
            else
            {
                colourStruct = GetUniqueRandomColor(FullName);
            }

            strColour = colourStruct.red.ToString()+ ","+colourStruct.green.ToString() + "," + colourStruct.blue.ToString();
            return strColour;
        }

        public struct Colour
        {
            public int red;
            public int green;
            public int blue;
        
        };

        public static Dictionary<string, Colour> ColourDict = new Dictionary<string, Colour>();
        public static  Random randomColour = new Random();

        public static Colour GetUniqueRandomColor(string fullname)
        {

            Colour colour;

            
            colour.red = randomColour.Next(0, 255);
            colour.green = randomColour.Next(0, 255);
            colour.blue = randomColour.Next(0, 255);

            ColourDict.Add(fullname, colour);
            return colour;
        }
    }
}