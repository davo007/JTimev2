using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        public string NCR { get; set; }
        public int? Variation { get; set; }
        public string WorkTask { get; set; }

        [Display(Name ="Mon")]
        [DefaultValue(0)]
        public double? MondayTime { get; set; }

        
        [Display(Name = "Tues")]
        [DefaultValue(0)]
        public double? TuesdayTime { get; set; }

        [Display(Name = "Wed")]
        [DefaultValue(0)]
        public double? WednesdayTime { get; set; }

        [Display(Name = "Thur")]
        [DefaultValue(0)]
        public double? ThursdayTime { get; set; }

        [Display(Name = "Fri")]
        [DefaultValue(0)]
        public double? FridayTime { get; set; }

        [Display(Name = "Sat")]
        [DefaultValue(0)]
        public double? SaturdayTime { get; set; }

        [Display(Name = "Sun")]
        [DefaultValue(0)]
        public double? SundayTime { get; set; }
        public double Total
        {
            get
            {
                return (double)(MondayTime + TuesdayTime + WednesdayTime + ThursdayTime + FridayTime + SaturdayTime + SundayTime);
            }
        }
        //public double Total { get; set; }
        public double Billable { get; set; }
        public string Description { get; set; }
        public bool Approved { get; set; }
        public bool Posted { get; set; }
    }
}