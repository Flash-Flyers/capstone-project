using System;
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

namespace FlashFlyers.Controllers
{
    // simple controller to return the view for events which have already taken place
    public class PastEventsController : Controller
    {
        private readonly StandardModel _standardDbContext;
        public PastEventsController(StandardModel standardDbContext) {
            _standardDbContext = standardDbContext;
        }
        
        // returns the index of the past events page
        public IActionResult Index() {
            return View(_standardDbContext.Events);
        }

        public IActionResult Privacy() {
            return View();
        }
        
        // returns an error view if the the location of past events is missing
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
