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
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json.Linq;
//using DataTables;


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
        //[HttpPost]
        public IHttpActionResult GetTimesheets()
        //public IEnumerable<TimesheetDto> GetTimesheets()
        {
            var timesheetQuery = _context.Timesheets
                .Include(c => c.Weekending);

            //if (query > 0)
            //    timesheetQuery = timesheetQuery.Where(m => m.WeekendingId == query);

            var timesheetDtos = timesheetQuery
                .ToList()
                .Select(Mapper.Map<Timesheet, TimesheetDto>);

            return Ok(timesheetDtos);
        }

        [HttpPost]
        public IHttpActionResult NewTimesheet(Timesheet timesheet)
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            //var request = new Editor(_context, "timesheets");

            if (!ModelState.IsValid)
                return BadRequest();

            timesheet.Weekending = _context.Weekendings.SingleOrDefault(x => x.Id == timesheet.WeekendingId);

            if (timesheet.MondayTime == null)
            {
                timesheet.MondayTime = 0;
            }

            if (timesheet.TuesdayTime == null)
            {
                timesheet.TuesdayTime = 0;
            }

            if (timesheet.WednesdayTime == null)
            {
                timesheet.WednesdayTime = 0;
            }

            if (timesheet.ThursdayTime == null)
            {
                timesheet.ThursdayTime = 0;
            }

            if (timesheet.FridayTime == null)
            {
                timesheet.FridayTime = 0;
            }

            if (timesheet.SaturdayTime == null)
            {
                timesheet.SaturdayTime = 0;
            }

            if (timesheet.SundayTime == null)
            {
                timesheet.SundayTime = 0;
            }

            _context.Timesheets.Add(timesheet);
            _context.SaveChanges();

            string output = JsonConvert.SerializeObject(timesheet);

            var json = "{data : [ " + output + "]}";

            //return Ok(timesheet);
            //return Created(new Uri(Request.RequestUri + "/" + timesheet.Id), timesheet);
            return Ok(JsonConvert.DeserializeObject(json));
            //return Json(timesheet);
        }

        [HttpPut]
        public IHttpActionResult UpdateTimesheet(int id, TimesheetDto timesheetDto)
        {
            JsonConvert.DefaultSettings = () => new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };

            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            if (timesheetDto.MondayTime == null)
            {
                timesheetDto.MondayTime = 0;
            }

            if (timesheetDto.TuesdayTime == null)
            {
                timesheetDto.TuesdayTime = 0;
            }

            if (timesheetDto.WednesdayTime == null)
            {
                timesheetDto.WednesdayTime = 0;
            }

            if (timesheetDto.ThursdayTime == null)
            {
                timesheetDto.ThursdayTime = 0;
            }

            if (timesheetDto.FridayTime == null)
            {
                timesheetDto.FridayTime = 0;
            }

            if (timesheetDto.SaturdayTime == null)
            {
                timesheetDto.SaturdayTime = 0;
            }

            if (timesheetDto.SundayTime == null)
            {
                timesheetDto.SundayTime = 0;
            }

            var timesheetInDb = _context.Timesheets.SingleOrDefault(c => c.Id == id);

            if (timesheetInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            

            Mapper.Map(timesheetDto, timesheetInDb);

            timesheetInDb.Weekending = _context.Weekendings.SingleOrDefault(x => x.Id == timesheetDto.WeekendingId);

            _context.SaveChanges();

            string output = JsonConvert.SerializeObject(timesheetInDb);

            var json = "{data : [ " + output + "]}";
                        
            return Ok(JsonConvert.DeserializeObject(json));
            
        }

        [HttpDelete]
        public void Delete(int id)
        {
            var timesheetInDb = _context.Timesheets.SingleOrDefault(c => c.Id == id);

            if (timesheetInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Timesheets.Remove(timesheetInDb);
            _context.SaveChanges();
        }
    }
}
