using MailKit.Security;
using Microsoft.Extensions.Hosting;
using MimeKit;
using MimeKit.Text;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace FlashFlyers.Controllers
{
    public class DelaySend : IHostedService
    {
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
            //Wait 1 minute till next execution
            DateTime nextStop = DateTime.Now.AddMinutes(1);
            var timeToWait = nextStop - DateTime.Now;
            var millisToWait = timeToWait.TotalMilliseconds;
            Thread.Sleep((int)millisToWait);

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

        }
    }
}
