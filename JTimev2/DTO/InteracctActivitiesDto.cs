using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JTimev2.DTO
{
    public class InteracctActivitiesDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public decimal? TotalCost { get; set; }
        public decimal? AdjContract { get; set; }
        public decimal? TotalInvoices { get; set; }
    }
}