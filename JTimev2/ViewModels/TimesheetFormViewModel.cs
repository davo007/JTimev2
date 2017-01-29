using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JTimev2.Models;

namespace JTimev2.ViewModels
{
    public class TimesheetFormViewModel
    {
        public IEnumerable<Weekending> Weekending { get; set; }
        public Timesheet timesheet { get; set; }
    }
}