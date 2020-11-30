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
using FlashFlyers.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore.Internal;

namespace FlashFlyers.Controllers
{
    // standard controller for returning the View for the Homepage 
    public class HomeController : Controller
    {
        private readonly StandardModel _standardDbContext;
        public HomeController(StandardModel standardDbContext) {
            _standardDbContext = standardDbContext;
        }
        // requires standardDbContext in order to display the Events on the Homepage
        public IActionResult Index(int page_number)
        {
            if (_standardDbContext.Events.Any())
            {
                List<EventModel> events = _standardDbContext.Events.ToList();
                List<EventModel> page_events = new List<EventModel>();
                int page_length = 10;
                for (int i = 0; i < page_length; ++i)
                {
                    int index = i + (page_number * page_length);
                    if (index < events.Count())
                        page_events.Add(events[index]);
                }

                System.Diagnostics.Debug.WriteLine("Page: " + page_number + " page events count : " + page_events.Count());

                int total_pages = (int)MathF.Ceiling(events.Count / 10.0f);
                return View(new SearchResultsViewModel { PageNumber = page_number, Pages = total_pages, Events = page_events });
            }
            
            return View(new SearchResultsViewModel {Events = new List<EventModel>()});
        }
        // returns error view for error tracability
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
