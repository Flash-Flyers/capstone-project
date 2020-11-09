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

namespace FlashFlyers.Models
{
    public class DelaySend : IHostedService
    {
        //private readonly StandardModel _standardDbContext;
        //public DelaySend(StandardModel standardDbContext)
        //{
        //    _standardDbContext = standardDbContext;
        //}
        //private readonly ILogger<DelaySend> _logger;
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

        //public String[] str = new String[] { "joe@mail.com", "bob@mail.com"};
        int id = 858821921;
        public void TaskRoutine()
        {
            using (var scope = _serviceScopeFactory.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<StandardModel>();

                DateTime nextStop = DateTime.Now.AddSeconds(5);
                var timeToWait = nextStop - DateTime.Now;
                var millisToWait = timeToWait.TotalMilliseconds;
                Thread.Sleep((int)millisToWait);
                //for (int i = 0; i < str.Length; i++)
                //{
                // create email message
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse("brendon.cremin75@ethereal.email"));
                email.To.Add(MailboxAddress.Parse(dbContext.EmailReminder.Find(id).Email));
                email.Subject = "Test Email Subject";
                email.Body = new TextPart(TextFormat.Html) { Text = "<h1>Example HTML Message Body</h1>" };

                // send email
                using var smtp = new MailKit.Net.Smtp.SmtpClient();
                smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
                smtp.Authenticate("brendon.cremin75@ethereal.email", "BKw63Nr9qJSFEZbwQ7");
                smtp.Send(email);
                smtp.Disconnect(true);
                //}
            }
        }
    }
}
