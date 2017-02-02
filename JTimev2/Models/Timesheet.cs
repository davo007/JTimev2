using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JTimev2.Models
{
    public class Timesheet
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }
        
        public Weekending Weekending { get; set; }

        [Display(Name = "Weekending Date")]
        public byte WeekendingId { get; set; }

        [Display(Name = "Job Number")]
        public int JobNumber { get; set; }
        public string Package { get; set; }
        public string Activity { get; set; }
        public int? NCR { get; set; }
        public int? Variation { get; set; }

        [Display(Name ="Monday")]
        public int? MondayTime { get; set; }

        [Display(Name = "Tuesday")]
        public int? TuesdayTime { get; set; }

        [Display(Name = "Wednesday")]
        public int? WednesdayTime { get; set; }

        [Display(Name = "Thursday")]
        public int? ThursdayTime { get; set; }

        [Display(Name = "Friday")]
        public int? FridayTime { get; set; }

        [Display(Name = "Saturday")]
        public int? SaturdayTime { get; set; }

        [Display(Name = "Sunday")]
        public int? SundayTime { get; set; }
        public int Total { get; set; }
        public int Billable { get; set; }
        public string Description { get; set; }
        public bool Approved { get; set; }
        public bool Posted { get; set; }
    }
}