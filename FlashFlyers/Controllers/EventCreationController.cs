using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FlashFlyers.Models;
using Microsoft.AspNetCore.Hosting;
using System.Drawing.Imaging;
using QRCoder;

namespace FlashFlyers.Controllers
{
    public class EventCreationController : Controller
    {
        private readonly StandardModel _standardDbContext;
        public EventCreationController(StandardModel standardDbContext)
        {
            _standardDbContext = standardDbContext;
        }

        public IActionResult Index()
        {
            return View(_standardDbContext);
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

        [HttpPost]
        public async Task<IActionResult> CreateEvent(string name, string description, IFormFile flyer, string date, string time, string building, int room, string campus)
        {
            if (name == null || name.Length == 0)
                return Content("Name too short");
            if (flyer == null || Path.GetExtension(flyer.FileName) == String.Empty || Path.GetExtension(flyer.FileName) == null)
                return Content("Flyer not attached, or incorrect file extension.");

            var rand = new Random();
            int id = 0;

            while (_standardDbContext.Find<EventModel>(id) != null || id == 0)
                id = rand.Next();

            var path = String.Concat(Directory.GetCurrentDirectory(), "/wwwroot/", id.ToString(), Path.GetExtension(flyer.FileName));

            using (var stream = new FileStream(path, FileMode.Create)) {
                await flyer.CopyToAsync(stream);
            }

            //System.Diagnostics.Debug.WriteLine("FILE LENGTH ==", Path.GetExtension(flyer.FileName) == String.Empty, "Long");

            _standardDbContext.Add(new EventModel
            {
                Id = id,
                Title = name,
                Description = description,
                FileName = String.Concat(id.ToString(), Path.GetExtension(flyer.FileName)),
                Date = date,
                Time = time,
                Building = building,
                Room = room,
                Campus = campus
            });

            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(id.ToString(),
            QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
            qrCodeImage.Save(Directory.GetCurrentDirectory() + "/wwwroot/" + id.ToString() + "_qr.png", ImageFormat.Png);

            _standardDbContext.SaveChanges();
            _standardDbContext.Dispose();

            return RedirectToAction("Index");
        }
    }
}
