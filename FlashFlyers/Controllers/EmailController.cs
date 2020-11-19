using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MailKit;
using MimeKit;
using MimeKit.Text;
using System.Net.Mail;
using MailKit.Security;
using MailKit.Net;
using MailKit.Net.Smtp;
using System.Net.Mime;
using System.Threading;
using System.ComponentModel;
using System.Collections;
using Microsoft.Extensions.Hosting;
using System.Web;
using Microsoft.Extensions.Hosting.Internal;
using System.Runtime.CompilerServices;
using FlashFlyers.Models;

namespace FlashFlyers.Controllers
{
    // this controller class will write to the database when a user
    // clicks on the link to schedule an email reminder
    public class EmailController : Controller
    {
        private readonly StandardModel _standardDbContext;
        public EmailController(StandardModel standardDbContext)
        {
            _standardDbContext = standardDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        
        // this LocalRedirectResult method will Add to the Email Reminder table
        // it stores the EmailReminderId, the EventId, Date, and Email
        // these are all passed from the asp-action in the Event View, "Event.html"
        public LocalRedirectResult scheduleEmail(int id, string date, string email)
        {
            if (email != null)
            {
                // adds parameters to the Email Reminder table
                _standardDbContext.Add(new EmailReminderModel
                {
                    EmailReminderId = new Random().Next(),
                    EventId = id,
                    Date = date,
                    Email = email
                });
            }
            _standardDbContext.SaveChanges();
            _standardDbContext.Dispose();
            string idStr = id.ToString();
            string s = "/" + idStr;
            //return to the View
            return LocalRedirect(s);
        }
    }
}
