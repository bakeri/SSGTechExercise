using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace SSGTechExercise.Models
{

    public class Customer
    {
        public int CustomerId { get; set; }

        [Display(Name = "First Name")]
        public string Fisrtname { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Telephone Number")]
        [RegularExpression(@"^(\+\s?)?((?<!\+.*)\(\+?\d+([\s\-\.]?\d+)?\)|\d+)([\s\-\.]?(\(\d+([\s\-\.]?\d+)?\)|\d+))*(\s?(x|ext\.?)\s?\d+)?$", ErrorMessage = "Entered Telephone Number format is not valid.")]
        public string Telephone { get; set; }

        [Display(Name = "Date Of Birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MMM/yyyy}")]
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