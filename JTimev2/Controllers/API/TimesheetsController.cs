using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using JTimev2.Models;
using AutoMapper;
using JTimev2.DTO;

namespace JTimev2.Controllers.API
{
    public class TimesheetsController : ApiController
    {

        private ApplicationDbContext _context;

        public TimesheetsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/timesheets
        public IHttpActionResult GetTimesheets()
        {
            var timesheetQuery = _context.Timesheets
                .Include(c => c.Weekending);

            var timesheetDtos = timesheetQuery
                .ToList()
                .Select(Mapper.Map<Timesheet, TimesheetDto>);

            return Ok(timesheetQuery);
        }
    }
}
