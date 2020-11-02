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
    public class EventController : Controller
    {
        private readonly StandardModel _standardDbContext;
        public EventController(StandardModel standardDbContext)
        {
            _standardDbContext = standardDbContext;
        }

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

        public LocalRedirectResult Heart(int id)
        {

            _standardDbContext.Find<EventModel>(id).Hearts = _standardDbContext.Find<EventModel>(id).Hearts + 1;
            _standardDbContext.SaveChanges();
            _standardDbContext.Dispose();
            string idStr = id.ToString();
            string s = "/" + idStr;
            return LocalRedirect(s);
        }

        public LocalRedirectResult Like(int id, string email)
        {
            var count = _standardDbContext.Likes
            .Where(o => o.EventId == id)
            .Count();
            _standardDbContext.Find<EventModel>(id).Likes = count;
            //_standardDbContext.Find<EventModel>(id).Likes = _standardDbContext.Likes.Count();
            if (email != null)
            {
                _standardDbContext.Add(new LikeModel
                {
                    EventId = id,
                    Time = DateTime.Now,
                    LikeId = new Random().Next(),
                    Email = email
                });
            }
            //_standardDbContext.Find<EventModel>(id).Likes = _standardDbContext.Find<EventModel>(id).Likes + 1;
            _standardDbContext.SaveChanges();
            _standardDbContext.Dispose();
            string idStr = id.ToString();
            string s = "/" + idStr;
            return LocalRedirect(s);
        }
    }
}
