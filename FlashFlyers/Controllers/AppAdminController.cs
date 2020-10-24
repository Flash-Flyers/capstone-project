﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FlashFlyers.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace FlashFlyers.Controllers
{
    public class AppAdminController : Controller
    {
        private readonly StandardModel _standardDbContext;
        public AppAdminController(StandardModel standardDbContext)
        {
            _standardDbContext = standardDbContext;
        }

        public IActionResult Index()
        {
            return View(_standardDbContext.Events);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Modify()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult DeleteEvent(int id)
        {
            var Event = new EventModel { Id = id };
            _standardDbContext.Remove(Event);
            _standardDbContext.SaveChanges();
            _standardDbContext.SaveChanges();
            _standardDbContext.Dispose();
            return RedirectToAction("Index");
        }
    }
}
