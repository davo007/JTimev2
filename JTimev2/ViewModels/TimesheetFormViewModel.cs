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
        public int EmployeeId { get; set; }
                
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
        public int? SaturadayTime { get; set; }
        public int? SundayTime { get; set; }
        public int Total { get; set; }
        public int Billable { get; set; }
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
            SaturadayTime = timesheet.FridayTime;
            SundayTime = timesheet.SundayTime;
            Total = (int)(timesheet.MondayTime + timesheet.TuesdayTime + timesheet.WednesdayTime + timesheet.ThursdayTime + timesheet.FridayTime + timesheet.SaturdayTime + timesheet.SundayTime);
            Billable = timesheet.Billable;
            Description = timesheet.Description;
            Approved = timesheet.Approved;
            Posted = timesheet.Posted;
        }
    }
}