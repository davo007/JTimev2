using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JTimev2.DTO;

namespace JTimev2.Controllers.API
{
    public class InteracctActivityFinancialsController : ApiController
    {
        private InteracctDataDbContext _context;

        public InteracctActivityFinancialsController()
        {
            _context = new InteracctDataDbContext();
        }

        public IHttpActionResult GetActivityFinancials(int JobNumber, string Package, string Activity)
        {
            var Activities = _context.GetActivityFinancials(JobNumber, Package, Activity);

            IEnumerable<InteracctActivityFinancialsDto> ActivitiyFinancials = Activities.Select(x => new InteracctActivityFinancialsDto
            {
                TotalCost = x.Total_Costs____ESP_,
                TotalInvoices = x.Total_Invoices____SVL_,
                AdjContract = x.Adj_Contract___ACC_,


            }).ToList();

            return Ok(ActivitiyFinancials);
        }
    }
}
