using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JTimev2.Models;

namespace JTimev2.ViewModels
{
    public class TimesheetFormViewModel
    {
        public IEnumerable<Weekending> Weekendings { get; set; }
        public byte? WeekendingId { get; set; }
        public int? Id { get; set; }
        public string EmployeeId { get; set; }
                
        public int JobNumber { get; set; }
        public string Package { get; set; }
        public string Activity { get; set; }
        public string NCR { get; set; }
        public int? Variation { get; set; }
        public double? MondayTime { get; set; }
        public double? TuesdayTime { get; set; }
        public double? WednesdayTime { get; set; }
        public double? ThursdayTime { get; set; }
        public double? FridayTime { get; set; }
        public double? SaturdayTime { get; set; }
        public double? SundayTime { get; set; }
        public double Total { get; set; }
        public double Billable { get; set; }
        public string Description { get; set; }
        public bool Approved { get; set; }
        public bool Posted { get; set; }

        public TimesheetFormViewModel()
        {
            Id = 0;
        }

        public TimesheetFormViewModel(Timesheet timesheet)
        {
            Id = timesheet.Id;
            JobNumber = timesheet.JobNumber;
            Package = timesheet.Package;
            Activity = timesheet.Activity;
            NCR = timesheet.NCR;
            WeekendingId = timesheet.WeekendingId;
            Variation = timesheet.Variation;
            MondayTime = timesheet.MondayTime;
            TuesdayTime = timesheet.TuesdayTime;
            WednesdayTime = timesheet.WednesdayTime;
            ThursdayTime = timesheet.ThursdayTime;
            FridayTime = timesheet.FridayTime;
            SaturdayTime = timesheet.SaturdayTime;
            SundayTime = timesheet.SundayTime;
            Total = timesheet.Total;
            Billable = timesheet.Billable;
            Description = timesheet.Description;
            Approved = timesheet.Approved;
            Posted = timesheet.Posted;
        }
    }
}