using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FInalProject.Atribute;
using FInalProject.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace FInalProject.Controllers
{
    public class InitController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;
        public InitController(UserManager<IdentityUser> _userManager, RoleManager<IdentityRole> _roleManager)
        {
            userManager = _userManager;
            roleManager = _roleManager;
        }

        // GET
        public async Task<ViewResult> Index()
        {
            string superAdminEmail = "superadmin@gmail.com";
            string password = "_Aa123456";
            
            var roleNames =
                new List<string>{
                    "Admin",
                    "Client",
                    "SuperAdmin"
                }
            ;
            IdentityResult roleResult;

            foreach (var roleName in roleNames)
            {
                var roleExist = await roleManager.RoleExistsAsync(roleName);
                if (!roleExist)
                {
                    //create the roles and seed them to the database: Question 1
                    roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
                }
            }

            if (await userManager.FindByNameAsync(superAdminEmail) == null)
            {
                IdentityUser admin = new IdentityUser
                    {Email = superAdminEmail, UserName = superAdminEmail};
                IdentityResult result = await userManager.CreateAsync(admin, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, Roles.SuperAdmin.ToString());
                }
            }
            return View();
        }
        [AuthorizeRoles(Roles.SuperAdmin)]
        public ViewResult Admin()
        {
            return View();
        }
        
        [AuthorizeRoles(Roles.Client, Roles.SuperAdmin)]
        public ViewResult User()
        {
            return View();
        }
    }
}