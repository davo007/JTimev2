using JTimev2.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace JTimev2.Controllers
{
    public class RolesAdminController : Controller
        {
            public RolesAdminController()
            {
            }

            public RolesAdminController(ApplicationUserManager userManager,
                ApplicationRoleManager roleManager)
            {
                UserManager = userManager;
                RoleManager = roleManager;
            }

            private ApplicationUserManager _userManager;
            public ApplicationUserManager UserManager
            {
                get
                {
                    return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
                }
                set
                {
                    _userManager = value;
                }
            }

            private ApplicationRoleManager _roleManager;
            public ApplicationRoleManager RoleManager
            {
                get
                {
                    return _roleManager ?? HttpContext.GetOwinContext().Get<ApplicationRoleManager>();
                }
                private set
                {
                    _roleManager = value;
                }
            }

            //
            // GET: /Roles/
            public ActionResult Index()
            {
                return View(RoleManager.Roles);
            }

            //
            // GET: /Roles/Details/5
            public async Task<ActionResult> Details(string id)
            {
                if (id == null)
                {
                    return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
                }
                var role = await RoleManager.FindByIdAsync(id);
                // Get the list of Users in this Role
                var users = new List<ApplicationUser>();

                // Get the list of Users in this Role
                foreach (var user in UserManager.Users.ToList())
                {
                    if (await UserManager.IsInRoleAsync(user.Id, role.Name))
                    {
                        users.Add(user);
                    }
                }

                ViewBag.Users = users;
                ViewBag.UserCount = users.Count();
                return View(role);
            }
            // GET: RolesAdmin
        //    public ActionResult Index()
        //{
        //    return View();
        //}
    }
}