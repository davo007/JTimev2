﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JTimev2.Models;
using JTimev2.ViewModels;

namespace JTimev2.Controllers
{
    public class TimesheetController : Controller
    {

        private ApplicationDbContext _context;

        public TimesheetController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Timesheet
       
        public ActionResult Index()
        {
            var model = _context.Timesheets.ToList();
            return View(model);
        }


        public ActionResult Create()
        {
            var weekendings = _context.Weekendings.ToList();
            var viewModel = new TimesheetFormViewModel
            {                
                Weekending = weekendings
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Timesheet tsm)
        {
            if (!ModelState.IsValid)
            {
                return View(tsm);
            } else
            {
                tsm.EmployeeId = 1;
                //tsm.WeekendingDateId = 1;
                //tsm.WeekendingDate = DateTime.Now;
                    
                _context.Timesheets.Add(tsm);

            }

            _context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}