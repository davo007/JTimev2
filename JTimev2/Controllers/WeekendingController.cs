using JTimev2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JTimev2.Controllers
{
    public class WeekendingController : Controller
    {
        private ApplicationDbContext _context;

        public WeekendingController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Weekending
        public ActionResult Index()
        {
            var model = _context.Weekendings.ToList();
            return View(model);
        }
    }
}