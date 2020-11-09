using MailKit.Security;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Hosting;
using MimeKit;
using MimeKit.Text;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace FlashFlyers.Controllers
{
    public class DelaySend : IHostedService
    {
        //Dictionary<string, int> eventRe = new Dictionary<string, int>();
        public Task StartAsync(CancellationToken cancellationToken)
        {
            //eventRe.Add("joe@mail.com", 112233);
            //eventRe.Add("bob@mail.com", 112233);
            Task.Run(TaskRoutine, cancellationToken);
            return Task.CompletedTask;
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            Console.WriteLine("Sync Task stopped");
            return null;
        }

        String[] str = new String[] { "joe@mail.com", "bob@mail.com"};

        public void TaskRoutine()
        {
            // Wait 1 minute till next execution
            DateTime nextStop = DateTime.Now.AddSeconds(10);
            var timeToWait = nextStop - DateTime.Now;
            var millisToWait = timeToWait.TotalMilliseconds;
            Thread.Sleep((int)millisToWait);

            for (int i = 0; i < str.Length; i++)
            {
                // create email message
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse("brendon.cremin75@ethereal.email"));
                email.To.Add(MailboxAddress.Parse(str[i]));
                email.Subject = "Test Email Subject";
                email.Body = new TextPart(TextFormat.Html) { Text = "<h1>Example HTML Message Body</h1>" };

                // send email
                using var smtp = new MailKit.Net.Smtp.SmtpClient();
                smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
                smtp.Authenticate("brendon.cremin75@ethereal.email", "BKw63Nr9qJSFEZbwQ7");
                smtp.Send(email);
                smtp.Disconnect(true);
            }
        }
    }
}
