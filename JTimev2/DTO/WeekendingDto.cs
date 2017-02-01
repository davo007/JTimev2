using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JTimev2.DTO
{
    public class WeekendingDto
    {
        [Display(Name = "Week Ending")]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfSun { get; set; }
    }
}