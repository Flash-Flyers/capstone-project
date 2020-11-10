using FlashFlyers.Models;
using MailKit.Security;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Hosting;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FlashFlyers.Models
{
    public class DelaySend : IHostedService
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public DelaySend(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        public Task StartAsync(CancellationToken cancellationToken)
        {
            Task.Run(TaskRoutine, cancellationToken);
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Sync Task stopped");
            return null;
        }

        public void TaskRoutine()
        {
            string twoDays = DateTime.Now.AddHours(48).ToString("yyyy-MM-dd");
            while (true)
            {
                // getting scope for database context since this is a singleton class
                using (var scope = _serviceScopeFactory.CreateScope())
                {
                    var dbContext = scope.ServiceProvider.GetRequiredService<StandardModel>();

                    // looks through database table "EmailReminder" for events with Date occuring 2 days from current date
                    var upcomingDates = dbContext.EmailReminder.Where(p => p.Date == twoDays);
                    foreach (var emailRow in upcomingDates)
                    {
                        // creates an email message using MimeMessage
                        // using ethereal email as placeholder email service
                        // this can be set up with any email service KSU wants to use
                        var email = new MimeMessage();
                        email.From.Add(MailboxAddress.Parse("brendon.cremin75@ethereal.email"));
                        // looks for every email subcribed to an upcoming event(events occuring 2 days from current date)
                        email.To.Add(MailboxAddress.Parse(emailRow.Email));
                        email.Subject = DateTime.Now.ToString();
                        email.Body = new TextPart(TextFormat.Html) 
                        { 
                            Text = "This is a reminder for an event you subcribed to. It will occur on " + twoDays 
                        };
                        // send the email using smtp
                        // using ethereal email as placeholder email service
                        // this can be set up with any email service KSU wants to use
                        using var smtp = new MailKit.Net.Smtp.SmtpClient();
                        smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
                        smtp.Authenticate("brendon.cremin75@ethereal.email", "BKw63Nr9qJSFEZbwQ7");
                        smtp.Send(email);
                        smtp.Disconnect(true);
                    }
                    // checks to send reminders Every 24 Hours
                    DateTime nextStop = DateTime.Now.AddHours(24);
                    var timeToWait = nextStop - DateTime.Now;
                    var millisToWait = timeToWait.TotalMilliseconds;
                    Thread.Sleep((int)millisToWait);
                }
            }
        }
    }
}
