using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlashFlyers.Models;
using Microsoft.AspNetCore.Mvc;

namespace FlashFlyers.Controllers
{
    public class AccountCreationController : Controller
    {
        private readonly StandardModel _standardDbContext;
        public AccountCreationController(StandardModel standardDbContext)
        {
            _standardDbContext = standardDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateAccount(string email, string username, string password, List<string> preferences)
        {
            if (email == null || username == null || password == null)
            {
                return RedirectToAction("Index");
            }

            _standardDbContext.Add(new AccountModel
            {
                Email = email,
                Username = username,
                Password = password,
                Preferences = preferences
            });
            _standardDbContext.SaveChanges();
            _standardDbContext.Dispose();
            return RedirectToAction("Index");
        }
    }
}
