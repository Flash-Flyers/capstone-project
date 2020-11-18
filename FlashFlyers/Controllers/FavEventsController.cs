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
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.AspNetCore.Identity;

namespace FlashFlyers.Controllers
{
    // this controller class handles the favorited events functionality
    // it required the user is authenticated and looks at the standard model for events which the 
    // user has saved for future reference.
    public class FavEventsController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly StandardModel _standardDbContext;
        public FavEventsController(StandardModel standardDbContext, UserManager<ApplicationUser> userManager)
        {
            _standardDbContext = standardDbContext;
            _userManager = userManager;
        }
        
        // user must be authenticated in order to access favorite events feature
        public IActionResult Index()
        {
            if (User.Identity.IsAuthenticated)
            {
                List<int> event_ids = _standardDbContext.Users.Find(_userManager.GetUserId(User)).SavedEvents;
                if (event_ids == null)
                    return View(new List<EventModel>());
                List<EventModel> events = new List<EventModel>();
                for (int i = 0; i < event_ids.Count; ++i)
                    if (_standardDbContext.Find<EventModel>(event_ids[i]) != null)
                        events.Add(_standardDbContext.Find<EventModel>(event_ids[i]));
                return View(events);
            }
            else
                return View(new List<EventModel>());
        }
        
        // this function stores the saved event in a list unique to each user
        public IActionResult Save(int id)
        {
            if (_standardDbContext.Find<EventModel>(id) == null)
                return Error();

            if (User.Identity.IsAuthenticated)
            {
                List<int> event_ids = _standardDbContext.Users.Find(_userManager.GetUserId(User)).SavedEvents;

                if (event_ids == null)
                    event_ids = new List<int>();

                if (!event_ids.Contains(id))
                    event_ids.Add(id);
                else event_ids.Remove(id);

                _standardDbContext.SaveChanges();
                _standardDbContext.Dispose();
                return Redirect("~/FavEvents");
            }
            return Error();
        }
        
        // error handling and display
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
