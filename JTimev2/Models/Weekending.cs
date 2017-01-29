using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JTimev2.Models
{
    public class Weekending
    {
        [Display(Name = "Week Ending")]
        
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfSun { get; set; }
        
       
    }
}