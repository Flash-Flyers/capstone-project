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
    public class EmailController : Controller
    {
        private readonly StandardModel _standardDbContext;
        //private readonly DelaySend _send;
        public EmailController(StandardModel standardDbContext/*, DelaySend send*/)
        {
            _standardDbContext = standardDbContext;
            //_send = send;
        }

        //public void Test()
        //{
        //    _send.TaskRoutine();
        //    _send.Email();
        //}
        public IActionResult Index()
        {
            return View();
        }
        public string getEmail(int i)
        {
            return "joe@mail.com";
        }

        public LocalRedirectResult scheduleEmail(int id, string date, string email)
        {
            //// create email message
            //var email = new MimeMessage();
            //email.From.Add(MailboxAddress.Parse("brendon.cremin75@ethereal.email"));
            //email.To.Add(MailboxAddress.Parse("jevans63@kent.edu"));
            //email.Subject = "Test Email Subject";
            //email.Body = new TextPart(TextFormat.Html) { Text = "<h1>Example HTML Message Body</h1>" };

            //// send email
            //using var smtp = new MailKit.Net.Smtp.SmtpClient();
            //smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
            //smtp.Authenticate("brendon.cremin75@ethereal.email", "BKw63Nr9qJSFEZbwQ7");
            //smtp.Send(email);
            //smtp.Disconnect(true);
            //string idStr = id.ToString();
            //string s = "/" + idStr;
            //return LocalRedirect(s);
            //Test();
            if (email != null)
            {
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
            return LocalRedirect(s);
        }
    }
}
