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
using Microsoft.AspNetCore.Authorization;

namespace FlashFlyers.Controllers
{
    // this controller class is meant to handle event deletion and modification
    //[Authorize(Roles ="Admin")]
    public class AppAdminController : Controller
    {
        private readonly StandardModel _standardDbContext;
        public AppAdminController(StandardModel standardDbContext) {
            _standardDbContext = standardDbContext;
        }

        public IActionResult Index() {
            return View(_standardDbContext.Events);
        }
        public IActionResult Modify() {
            return View();
        }

        public IActionResult Delete() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        // function for removing an event by its Id
        public IActionResult DeleteEvent(int id) {
            var Event = new EventModel { Id = id };
            _standardDbContext.Remove(Event);
            _standardDbContext.SaveChanges();
            _standardDbContext.Dispose();
            return RedirectToAction("Index");
        }
        
        // function for event modification by replacing the event in the database
        // works similarly to event creation except the event Id is preserved
        // this  is in order to keep the url for the event page consistent,
        // which allows for features such as QR codes and Mapbox to function properly

        public IActionResult ApproveEvent(int id)
        {
            EventModel unapproved_event = _standardDbContext.Find<EventModel>(id);
            if (unapproved_event != null)
                unapproved_event.Approved = true;
            _standardDbContext.SaveChanges();
            _standardDbContext.Dispose();
            return RedirectToAction("Index");
        }

        public IActionResult ModifyEvent(int id, string name, string description, IFormFile flyer, string date, string time, string building, int room/*, string campus*/)
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
                Latitude = _standardDbContext.Find<LocationModel>(building).Latitude,
                Longitude = _standardDbContext.Find<LocationModel>(building).Longitude,
                Likes = _standardDbContext.Find<EventModel>(id).Likes
            });

            _standardDbContext.SaveChanges();
            _standardDbContext.Dispose();
            return RedirectToAction("Index");
        }
    }
}
