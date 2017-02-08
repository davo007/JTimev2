using JTimev2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JTimev2.DTO;
using AutoMapper;

namespace JTimev2.Controllers.API
{
    public class WeekendingsController : ApiController
    {
        private ApplicationDbContext _context;

        public WeekendingsController()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetWeekendings()
        {
            var weekendingQuery = _context.Weekendings;

            var weekendingsDtos = weekendingQuery
                .ToList()
                .Select(Mapper.Map<Weekending, WeekendingDto>);

            return Ok(weekendingsDtos);
        }

    }
}
