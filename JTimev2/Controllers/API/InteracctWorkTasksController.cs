using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using JTimev2.DTO;

namespace JTimev2.Controllers.API
{
    public class InteracctWorkTasksController : ApiController
    {
        private InteracctDataDbContext _context;

        public InteracctWorkTasksController()
        {
            _context = new InteracctDataDbContext();
        }

        
        public IHttpActionResult GetWorkTasks()
        {
            var worktasks = _context.GetWorkTasks();

            IEnumerable<InteracctWorkTasksDto> worktasksList = worktasks.Select(x => new InteracctWorkTasksDto
            {
                Id = x.Work_Task__CIT_,
                WorkTask = x.Work_Task__CIT_,
                WorkTaskDesc = x.Description__CID_
            }).ToList();

            return Ok(worktasksList);
        }
    }
}
