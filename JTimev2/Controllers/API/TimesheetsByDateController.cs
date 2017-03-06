using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JTimev2.Models;
using AutoMapper;
using JTimev2.DTO;
using System.Data.Entity;
using Microsoft.AspNet.Identity;

namespace JTimev2.Controllers.API
{
    public class TimesheetsByDateController : ApiController
    {

        private ApplicationDbContext _context;

        public TimesheetsByDateController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult GetTimesheets(int id)
        //public IEnumerable<TimesheetDto> GetTimesheets()
        {

            var loggedInId = User.Identity.GetUserId();

            var timesheetQuery = _context.Timesheets
                .Include(c => c.Weekending)
                .Where(c => c.EmployeeId == loggedInId);

            if (id > 0)
                timesheetQuery = timesheetQuery.Where(m => m.WeekendingId == id);

            var timesheetDtos = timesheetQuery
                .ToList()
                .Select(Mapper.Map<Timesheet, TimesheetDto>);

            return Ok(timesheetDtos);
        }

        [HttpPut]
        public IHttpActionResult CopyTimesheets(int id)
        {
            var loggedInId = User.Identity.GetUserId();

            var timesheetQuery = _context.Timesheets
                .Include(c => c.Weekending)
                .Where(c => c.WeekendingId == (id - 1))
                .Where(c => c.EmployeeId == loggedInId)
                .ToList();
                //;

            foreach (Timesheet timesheet in timesheetQuery)
            {
                Timesheet ts = new Timesheet();
                
                Mapper.Map(timesheet, ts);

                ts.Weekending = _context.Weekendings.SingleOrDefault(c => c.Id == id);
                ts.WeekendingId = (byte)id;

                _context.Timesheets.Add(ts);
                _context.SaveChanges();
            }

            return Ok();
        }
    }
}
