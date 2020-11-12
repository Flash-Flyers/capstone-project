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
    public class MyEvents : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly StandardModel _standardDbContext;
        public MyEvents(StandardModel standardDbContext, UserManager<ApplicationUser> userManager) {
            _standardDbContext = standardDbContext;
            _userManager = userManager;
        }
        public IActionResult Index() {
            if (User.Identity.IsAuthenticated) {
                List<int> event_ids = _standardDbContext.Users.Find(_userManager.GetUserId(User)).AuthoredEvents;
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

        public IActionResult UserEventDelete(int event_id) {
            ApplicationUser user = _standardDbContext.Users.Find(_userManager.GetUserId(User));
            if (_standardDbContext.Find<EventModel>(event_id) != null && user.AuthoredEvents.Contains(event_id)) {
                user.AuthoredEvents.Remove(event_id);
                _standardDbContext.Remove(_standardDbContext.Find<EventModel>(event_id));
                _standardDbContext.SaveChanges();
                return Redirect("~/MyEvents");
            }
            else
                return Error();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
