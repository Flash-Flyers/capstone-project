using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlashFlyers.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FlashFlyers.Controllers
{
    // this controller class handles admin role assignment
    // it interfaces with the database in order to assign and modify user roles
    //[Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly UserManager<ApplicationUser> userManager;

        public AdminController(RoleManager<IdentityRole> roleManager, UserManager<ApplicationUser> userManager)
        {
            this.roleManager = roleManager;
            this.userManager = userManager;
        }//constructor injection

        [HttpGet]
        public IActionResult CreateRole()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateRole(CreateRoleViewModel model)
        {
            if (ModelState.IsValid)
            {
                IdentityRole identityRole = new IdentityRole
                {
                    Name = model.RoleName
                };
                IdentityResult result = await roleManager.CreateAsync(identityRole); //using the injected rolemanager to add role to the db
                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles", "Admin");
                }
                foreach (IdentityError error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult ListRoles()
        {
            var roles = roleManager.Roles;
            return View(roles);
        }
        [HttpGet]
        public async Task<IActionResult> EditRole(string id)
        {
            var theRole = await roleManager.FindByIdAsync(id);

            if(theRole == null)//if the role is not in the database return error
            {
                ViewBag.ErrorMessage = $"Role with Id = {id} cannont be found";
                return View("NotFound");
            }
            var model = new EditRoleModel
            {
                Id = theRole.Id,
                RoleName = theRole.Name
            };
            foreach (var user in userManager.Users)
            {//want to know if the user is in the role
                if (await userManager.IsInRoleAsync(user, theRole.Name))//method returns true if user is in the role
                {
                    model.Users.Add(user.UserName);//adding username to list of usernames that is with role
                }
            }
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> EditRole(EditRoleModel model)
        {
            var theRole = await roleManager.FindByIdAsync(model.Id);

            if (theRole == null)//if the role is not in the database return error
            {
                ViewBag.ErrorMessage = $"Role with Id = {model.Id} cannont be found";
                return View("NotFound");
            }
            else
            {
                theRole.Name = model.RoleName;
                var didUpdate = await roleManager.UpdateAsync(theRole);

                if (didUpdate.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }
                foreach (var error in didUpdate.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View(model);
            } 
        }
        [HttpGet]
        public async Task<IActionResult> EditUsersInRole(string roleId)//gets id from url
        {
            ViewBag.roleId = roleId;

            var role = await roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
                return View("NotFound");
            }

            var model = new List<UserRoleModel>();

            foreach (var user in userManager.Users)//looping through all users and creating a userroleviewmodel for them
            {
                var userRoleModel = new UserRoleModel
                {
                    UserId = user.Id,
                    UserName = user.UserName
                };

                if (await userManager.IsInRoleAsync(user, role.Name)) //checking to see if user is already in the role
                {
                    userRoleModel.IsSelected = true;
                }
                else
                {
                    userRoleModel.IsSelected = false;
                }

                model.Add(userRoleModel);
            }

            return View(model);
        }
        [HttpPost]
        public async Task<IActionResult> EditUsersInRole(List<UserRoleModel> model, string roleId)
        {
            var role = await roleManager.FindByIdAsync(roleId);

            if (role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {roleId} cannot be found";
                return View("NotFound");
            }

            for (int i = 0; i < model.Count; i++)
            {
                var user = await userManager.FindByIdAsync(model[i].UserId);

                IdentityResult result = null;

                if (model[i].IsSelected && !(await userManager.IsInRoleAsync(user, role.Name)))
                {
                    result = await userManager.AddToRoleAsync(user, role.Name);
                }
                else if (!model[i].IsSelected && await userManager.IsInRoleAsync(user, role.Name))
                {
                    result = await userManager.RemoveFromRoleAsync(user, role.Name);
                }
                else
                {
                    continue;
                }

                if (result.Succeeded)
                {
                    if (i < (model.Count - 1))
                        continue;
                    else
                        return RedirectToAction("EditRole", new { Id = roleId });
                }
            }

            return RedirectToAction("EditRole", new { Id = roleId });
        }
        public async Task<IActionResult> DeleteRole(string id)
        {
            var role = await roleManager.FindByIdAsync(id);

            if(role == null)
            {
                ViewBag.ErrorMessage = $"Role with Id = {id} cannot be found";
                return View("Not Found");
            }
            else
            {
                var result = await roleManager.DeleteAsync(role);

                if (result.Succeeded)
                {
                    return RedirectToAction("ListRoles");
                }
                foreach(var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View("ListRoles");
            }
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
