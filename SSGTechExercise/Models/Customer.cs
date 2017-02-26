using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace SSGTechExercise.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }

        [Display(Name = "First Name")]
        public string Fisrtname { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Telephone { get; set; }
        [Display(Name = "Date Of Birth")]
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
        public string RowColour { get; set; }
    }

   
}