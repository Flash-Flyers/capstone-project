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
    // this controller is used to dispay the indvidual event pages
    // it also interfaces with the Like table whenever a user "likes" a given event
    public class EventController : Controller
    {
        private readonly StandardModel _standardDbContext;
        public EventController(StandardModel standardDbContext)
        {
            _standardDbContext = standardDbContext;
        }
           
        // returns the View for the individual event specified by the EventId
        // returns an error if the EventId is invalid(null)
        public IActionResult Index(int id)
        {
            if (_standardDbContext.Find<EventModel>(id) != null)
                return View(_standardDbContext.Find<EventModel>(id));

            return Error();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        // for the Like functionality, increments the Likes by 1 and returns the the Event View
        public LocalRedirectResult Like(int id, string email)
        {
            if (email != null)
            {
                // adding a like record in the Likes table throught the standardDbContext
                // parameters include EventId, Time(current date/time stamp), unique LikeId and Email
                _standardDbContext.Add(new LikeModel
                {
                    EventId = id,
                    Time = DateTime.Now,
                    LikeId = new Random().Next(),
                    Email = email
                });
                // updates the Like count in the Events table by incrementing the Likes column by 1
                var count = _standardDbContext.Likes
                .Where(o => o.EventId == id)
                .Count();
                _standardDbContext.Find<EventModel>(id).Likes = count + 1;
            }
            _standardDbContext.SaveChanges();
            _standardDbContext.Dispose();
            string idStr = id.ToString();
            string s = "/" + idStr;
            return LocalRedirect(s);
        }
    }
}
