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

        private void Like(int id, string name, string description, IFormFile flyer, string date, string time, string building, int room, int likes/*, string campus*/)
        {
            var Event = new EventModel { Id = id };
            _standardDbContext.Remove(Event);
            _standardDbContext.Update(new EventModel
            {
                Id = id,
                Title = name,
                Description = description,
                FileName = String.Concat(id.ToString(), Path.GetExtension(flyer.FileName)),
                Date = date,
                Time = time,
                Building = building,
                Room = room,
                Likes = ++likes
                //Campus = campus
            });
        }
    }
}
