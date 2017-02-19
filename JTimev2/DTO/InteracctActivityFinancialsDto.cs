using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JTimev2.DTO
{
    public class InteracctActivityFinancialsDto
    {
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        public decimal? TotalCost { get; set; }
        public decimal? TotalInvoices { get; set; }
        public decimal? AdjContract { get; set; }
    }
}