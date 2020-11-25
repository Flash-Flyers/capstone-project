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
using System.Drawing.Drawing2D;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace FlashFlyers.Controllers
{
    //  this controller class is meant to handle event event creation
    // it is called by the EventCreation View via an asp-action
    [Authorize]
    public class EventCreationController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly StandardModel _standardDbContext;
        public EventCreationController(StandardModel standardDbContext, UserManager<ApplicationUser> userManager)
        {
            _standardDbContext = standardDbContext;
            _userManager = userManager;
        }

        public IActionResult Index() {
            return View(_standardDbContext);
        }
        public IActionResult Testing() {
            return View(_standardDbContext);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        // this async function is used to open the database context and store an event instance using the
        // parameters passed through an html form
        // it includes logic for the tagging system, as well as calls to function createImage
        [HttpPost]
        public async Task<IActionResult> CreateEvent(string name, string description, IFormFile flyer, string date, string time, string building, int room, int likes, string category)
        {
            if (name == null || name.Length == 0)
                return Content("Name too short");
            if (flyer == null || Path.GetExtension(flyer.FileName) == String.Empty || Path.GetExtension(flyer.FileName) == null)
                return Content("Flyer not attached, or incorrect file extension.");
            
            string[] broken_string = breakString(name);

            for (int i = 0; i < broken_string.Length; ++i)
                broken_string[i] = broken_string[i].ToLower();

            int id = new Random().Next();

            while (_standardDbContext.Find<EventModel>(id) != null)
                id = new Random().Next();
            List<int> list = new List<int>(id);

            for (int i = 0; i < broken_string.Count(); ++i)
            {
                if (_standardDbContext.Find<SearchTagModel>(broken_string[i]) == null)
                {
                    _standardDbContext.Add(new SearchTagModel { tag = broken_string[i], event_id = new List<int>() });
                    _standardDbContext.Find<SearchTagModel>(broken_string[i]).event_id.Add(id);
                }
                else
                    _standardDbContext.Find<SearchTagModel>(broken_string[i]).event_id.Add(id);
            }
            System.Diagnostics.Debug.WriteLine("TIME ==", time, "DATE ==", date,/* "CAMPUS ==", campus,*/ "BUILDING ==", building);
            _standardDbContext.Add(new EventModel
            {
                Id = id,
                Approved = false,
                Author = _userManager.GetUserId(User),
                Title = name,
                Description = description,
                FileName = String.Concat(id.ToString(), Path.GetExtension(flyer.FileName)),
                Date = date,
                Time = time,
                Building = building,
                Room = room,
                Latitude = _standardDbContext.Find<LocationModel>(building).Latitude,
                Longitude = _standardDbContext.Find<LocationModel>(building).Longitude,
                Likes = 0,
                Category = category
            });
            _standardDbContext.Users.Find(_userManager.GetUserId(User)).AuthoredEvents.Add(id);
            _standardDbContext.SaveChanges();
            _standardDbContext.Dispose();

            await createImage(id, flyer);

            return RedirectToAction("Index");
        }
        // the purpose of this function is to create a quick event for easier testing
        public async Task<IActionResult> CreateEventTesting(IFormFile flyer) {
            await CreateEvent("This is a test for the event name", "This is a test description", flyer, "2021-07-22", "15:30", "Mathematical Sciences", 1, 0);
            return RedirectToAction("Testing");
        }
        
        // this function user the QRCoder API in order to generate a QR code which links to the individual event page
        private Bitmap createQR(int id) {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("https://www.flashflyerz.com/" + id.ToString(),
            QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(7, Color.FromArgb(0, 31, 85), Color.FromArgb(238, 174, 36), true);
            return qrCodeImage;
        }
        
        // function to split a string on space character
        private string[] breakString(string name) 
        {
            string[] broken_string;
            broken_string = name.Split(' ');
            return broken_string;
        }
        
        // this function is used to superimpose the QR  code on the flyer image provided by the user 
        // the image is passed from the createEvent function, so this is called every time an event is created
        private async Task createImage(int id, IFormFile flyer) {
            var path = String.Concat(Directory.GetCurrentDirectory(), "/wwwroot/", id.ToString(), Path.GetExtension(flyer.FileName));
            Image flyer_image;
            using (var stream = new FileStream(path, FileMode.Create))
            {
                await flyer.CopyToAsync(stream);
                flyer_image = Image.FromStream(stream);
            }
            Bitmap qrCodeImage = createQR(id);
            qrCodeImage.Save(Directory.GetCurrentDirectory() + "/wwwroot/" + id.ToString() + "_qr.png", ImageFormat.Png);
            Image QR = Image.FromFile(Directory.GetCurrentDirectory() + "/wwwroot/" + id.ToString() + "_qr.png");

            int outputImageWidth = flyer_image.Width;

            int outputImageHeight = flyer_image.Height;

            Bitmap outputImage = new Bitmap(outputImageWidth, outputImageHeight, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(outputImage))
            {
                graphics.DrawImage(flyer_image, new Rectangle(new Point(), flyer_image.Size),
                    new Rectangle(new Point(), flyer_image.Size), GraphicsUnit.Pixel);
                graphics.DrawImage(QR, new Rectangle(new Point(0, flyer_image.Height - QR.Height), QR.Size),
                    new Rectangle(new Point(), QR.Size), GraphicsUnit.Pixel);
            }

            Encoder myEncoder;
            EncoderParameter myEncoderParameter;
            EncoderParameters myEncoderParameters;
            myEncoder = Encoder.Quality;
            myEncoderParameters = new EncoderParameters(1);
            myEncoderParameter = new EncoderParameter(myEncoder, 50L);
            myEncoderParameters.Param[0] = myEncoderParameter;

            ImageCodecInfo myImageCodecInfo = GetEncoderInfo("image/png");
            outputImage.Save(Directory.GetCurrentDirectory() + "/wwwroot/" + id.ToString() + "_with_qr.png", myImageCodecInfo, myEncoderParameters);
        }
        
        // function to obtain image encoder info 
        private static ImageCodecInfo GetEncoderInfo(String mimeType) {
            int j;
            ImageCodecInfo[] encoders;
            encoders = ImageCodecInfo.GetImageEncoders();
            for (j = 0; j < encoders.Length; ++j)
            {
                if (encoders[j].MimeType == mimeType)
                    return encoders[j];
            }
            return null;
        }
    }
}
