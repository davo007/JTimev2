using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JTimev2.DTO
{
    public class TimesheetDto
    {
        public int Id { get; set; }
        public string EmployeeId { get; set; }

        public WeekendingDto Weekending { get; set; }
        public byte WeekendingId { get; set; }
        public int JobNumber { get; set; }
        public string Package { get; set; }
        public string Activity { get; set; }
        public string NCR { get; set; }
        public int? Variation { get; set; }
        public string WorkTask { get; set; }
        public double? MondayTime { get; set; }
        public double? TuesdayTime { get; set; }
        public double? WednesdayTime { get; set; }
        public double? ThursdayTime { get; set; }
        public double? FridayTime { get; set; }
        public double? SaturdayTime { get; set; }
        public double? SundayTime { get; set; }
        public double Total { get; set; }
        public double Billable { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? TotalInvoices { get; set; }
        public decimal? AdjContract { get; set; }
        public string Description { get; set; }
        public bool Approved { get; set; }
        public bool Posted { get; set; }
    }
}