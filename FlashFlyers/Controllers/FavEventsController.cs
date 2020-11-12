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

namespace FlashFlyers.Controllers
{
    public class FavEventsController : Controller
    {
        private readonly StandardModel _standardDbContext;
        public FavEventsController(StandardModel standardDbContext)
        {
            _standardDbContext = standardDbContext;
        }
        public IActionResult Index()
        {
            List<EventModel> events = new List<EventModel>();
            if (User.Identity.IsAuthenticated && _standardDbContext.Find<UserDataModel>(User.Identity.Name) != null)
            {
                var data = _standardDbContext.Find<UserDataModel>(User.Identity.Name);
                for (int i = 0; i < data.event_id.Count; ++i)
                    if (_standardDbContext.Find<EventModel>(data.event_id[i]) != null)
                        events.Add(_standardDbContext.Find<EventModel>(data.event_id[i]));
            }
            return View(events);
        }

        public IActionResult Fav(int event_id)
        {
            if (_standardDbContext.Find<EventModel>(event_id) == null)
                return Error();
            //if (User.Identity.Name.Length < 7)
            //return Error();

            UserDataModel user_data;
            if (User.Identity.IsAuthenticated)
            {
                if (_standardDbContext.Find<UserDataModel>(User.Identity.Name) == null)
                {
                    user_data = new UserDataModel() { Id = User.Identity.Name, event_id = new List<int>() };
                    _standardDbContext.Add(user_data);
                }
                else
                    user_data = _standardDbContext.Find<UserDataModel>(User.Identity.Name);

                if (!user_data.event_id.Contains(event_id))
                    user_data.event_id.Add(event_id);

                _standardDbContext.SaveChanges();
                _standardDbContext.Dispose();
                return Redirect("~/FavEvents");
            }
            return Error();
        }

        public IActionResult Unfav(int event_id)
        {
            if (_standardDbContext.Find<EventModel>(event_id) == null)
                return Error();

            UserDataModel user_data;
            if(User.Identity.IsAuthenticated)
            {
                if (_standardDbContext.Find<UserDataModel>(User.Identity.Name) != null) // if the user has created a fav list 
                    user_data = _standardDbContext.Find<UserDataModel>(User.Identity.Name); // find that favorites list 
                else
                    user_data = new UserDataModel() { Id = User.Identity.Name, event_id = new List<int>() }; // create an empty list

                if (user_data.event_id.Contains(event_id)) // if the list contains the ID of the event to unfav
                    user_data.event_id.Remove(event_id); // remove it from the list  
               
                _standardDbContext.SaveChanges();
                _standardDbContext.Dispose();
                return Redirect("~/FavEvents");
                // else the user has not created a fav list and do nothing
            }
            return Error(); // if the user was not authenticated throw an error msg. 
        }

        /*
        public IActionResult Unfav(int event_id)
        {
            if (_standardDbContext.Find<EventModel>(event_id) == null)
                return Error();

            UserDataModel user_data;
            if(User.Identity.IsAuthenticated)
            {
                if (_standardDbContext.Find<UserDataModel>(User.Identity.Name) != null) // if the user has created a fav list 
                    user_data = _standardDbContext.Find<UserDataModel>(User.Identity.Name); // find that favorites list
                else
                {
                    user_data = new UserDataModel() { Id = User.Identity.Name, event_id = new List<int>() };
                    _standardDbContext.Add(user_data);
                }

                if (user_data.event_id.Contains(event_id)) // if the list contains the ID of the event to unfav
                    user_data.event_id.Remove(event_id); // remove it from the list  
                
                _standardDbContext.SaveChanges();
                _standardDbContext.Dispose();
                return Redirect("~/FavEvents");
                // else the user has not created a fav list and do nothing
            }

            return Error(); // if the user was not authenticated throw an error msg. 

        }
         */

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
