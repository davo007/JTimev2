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

            if (!ModelState.IsValid)
                return BadRequest();

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

            var timesheetInDb = _context.Timesheets.SingleOrDefault(c => c.Id == id);

            if (timesheetInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(timesheetDto, timesheetInDb);

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
