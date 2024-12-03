using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using System.ComponentModel.DataAnnotations;

namespace IBM_8N24RoutingStateModelBinder.Models
{
    public class Student
    {

        public int StudentID { get; set; }
        [Display(Name ="Student First Name - Last Name")]

        [Required]
        public string StudentName { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required]
        public string StudentEmail { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required]
        public string StudentPhone { get; set; }
        [DataType(DataType.Currency)]
        [Range(1000,10000000)]
        public double Fees
        { get; set; }

    }
}