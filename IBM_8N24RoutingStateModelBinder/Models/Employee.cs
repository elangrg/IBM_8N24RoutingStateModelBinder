using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace IBM_8N24RoutingStateModelBinder.Models
{
    public class Employee
    {
        
        public int EmpID { get; set; }
      
        public string EmpName
        { get; set; }
        
        public double Salary { get; set; }

    }


    public class BookTitle
    {
        public string Title { get; set; }
        public string DateOfPurchase { get; set; }

    }


}