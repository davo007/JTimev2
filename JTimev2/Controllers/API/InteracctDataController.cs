﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JTimev2.DTO;

namespace JTimev2.Controllers.API
{
    public class InteracctDataController : ApiController
    {
        private InteracctDataDbContext _context;

        public InteracctDataController()
        {
            _context = new InteracctDataDbContext();
        }

        public IHttpActionResult GetJobNumbers()
        {
            var JobNumbers = _context.GetJobNumbers();

            IEnumerable<InteracctJobNumberDto> JobNumbersList = JobNumbers.Select(x => new InteracctJobNumberDto
            {

                Id = (int)x.Job_No__JOB_,
                JobNumber = (int)x.Job_No__JOB_

            }).ToList();

            return Ok(JobNumbersList);

        }

        public IHttpActionResult GetPackages(int JobNumber)
        {
            var Packages = _context.GetPackages(JobNumber);

            IEnumerable<InteracctPackagesDto> PackageList = Packages.Select(x => new InteracctPackagesDto
            {
                Id = x.Code__SJC_,
                Name = x.Code__SJC_
            }).ToList();

            return Ok(PackageList);
        }

        public IHttpActionResult GetActivities(int JobNumber, string Package)
        {
            var Activities = _context.GetActivities(JobNumber, Package);

            IEnumerable<InteracctActivitiesDto> ActivitiesList = Activities.Select(x => new InteracctActivitiesDto
            {
                Id = x.Activity__CGR_,
                Name = x.Activity__CGR_
            }).ToList();

            return Ok(ActivitiesList);
        }

    }
}
