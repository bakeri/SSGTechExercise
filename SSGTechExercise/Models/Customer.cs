using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SSGTechExercise.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Fisrtname { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public DateTime DOB { get; set; }
        [NotMapped]
        public DateTime Today
        {
            get
            {
                return DateTime.Now;
            }
        }
        [NotMapped]
        public int Age { get; set; }

        [NotMapped]
        public int RowColour { get; set; }
    }

   
}