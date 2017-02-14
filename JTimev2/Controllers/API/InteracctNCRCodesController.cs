using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JTimev2.DTO;

namespace JTimev2.Controllers.API
{
    public class InteracctNCRCodesController : ApiController
    {

        private InteracctDataDbContext _context;

        public InteracctNCRCodesController()
        {
            _context = new InteracctDataDbContext();
        }

        public IHttpActionResult GetNCRCodes()
        {
            var NCRCodes = _context.GetNCRCodes();

            IEnumerable<InteracctNCRCodesDto> NCRCodesList = NCRCodes.Select(x => new InteracctNCRCodesDto
            {
                Id = x.Code__NCR_,
                NCRCode = x.Code__NCR_,
                NCRCodeDesc = x.Non_Charge_Reason__NCD_
            }).ToList();

            return Ok(NCRCodesList);
        }

    }
}
