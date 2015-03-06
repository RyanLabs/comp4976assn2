using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using comp4976assn2.Models;

namespace comp4976assn2.Controllers
{
    //[Authorize]
    public class AdminController : Controller
    {

        ApplicationDbContext ctx = new ApplicationDbContext();

        //
        // GET: /Admin/Index
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Admin/AddRole
        public ActionResult Roles()
        {
            var roles = ctx.Roles
                .OrderBy(c => c.Name)
                .Select(n => n.Name);
            ViewBag.Roles = roles;
            return View();
        }

        //
        // POST: /Admin/AddRole
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Roles(AddRoleViewModel model)
        {
            /*if (ModelState.IsValid)
            {
                var result = new ApplicationUser() { Roles = model.RoleName };
                if (result.Succeeded)
                {
                    return RedirectToAction("AddRole", "Admin");
                }
                else
                {
                    AddErrors(result);
                }
            }*/

            // If we got this far, something failed, redisplay form
            return View();
        }

        //
        // GET: /Admin/AddUser
        public ActionResult Users()
        {
            var users = ctx.Users
                .OrderBy(c => c.UserName)
                .Select(n => n.UserName);
            ViewBag.Users = users;
            return View();
        }

        //
        // GET: /Admin/AddUserToRole
        public ActionResult UserRoles()
        {
            return View();
        }
    }
}