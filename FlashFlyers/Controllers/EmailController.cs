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
namespace FlashFlyers.Controllers
{
    public class EmailController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public LocalRedirectResult sendEmail(int id)
        {
            // create email message
            var email = new MimeMessage();
            email.From.Add(MailboxAddress.Parse("brendon.cremin75@ethereal.email"));
            email.To.Add(MailboxAddress.Parse("jevans63@kent.edu"));
            email.Subject = "Test Email Subject";
            email.Body = new TextPart(TextFormat.Html) { Text = "<h1>Example HTML Message Body</h1>" };

            // send email
            using var smtp = new MailKit.Net.Smtp.SmtpClient();
            smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
            smtp.Authenticate("brendon.cremin75@ethereal.email", "BKw63Nr9qJSFEZbwQ7");
            smtp.Send(email);
            smtp.Disconnect(true);
            string idStr = id.ToString();
            string s = "/" + idStr;
            return LocalRedirect(s);
        }
    }
}
