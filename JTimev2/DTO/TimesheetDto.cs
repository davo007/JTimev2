using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JTimev2.DTO
{
    public class TimesheetDto
    {
        public int Id { get; set; }
        public int EmployeeId { get; set; }

        public WeekendingDto Weekending { get; set; }
        public byte WeekendingId { get; set; }
        public int JobNumber { get; set; }
        public string Package { get; set; }
        public string Activity { get; set; }
        public int? NCR { get; set; }
        public int? Variation { get; set; }
        public int? MondayTime { get; set; }
        public int? TuesdayTime { get; set; }
        public int? WednesdayTime { get; set; }
        public int? ThursdayTime { get; set; }
        public int? FridayTime { get; set; }
        public int? SaturdayTime { get; set; }
        public int? SundayTime { get; set; }
        public int Total { get; set; }
        public int Billable { get; set; }
        public string Description { get; set; }
        public bool Approved { get; set; }
        public bool Posted { get; set; }
    }
}