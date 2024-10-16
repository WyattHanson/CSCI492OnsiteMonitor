using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CSCI492OnsiteMonitor
{
    internal class SendEmailAlert
    {
        public static void alertEmail()
        {
            var client = new SmtpClient("live.smtp.mailtrap.io", 587)
            {
                Credentials = new NetworkCredential("api", "544bd8a957b11eeb85328821a1c90036"),
                EnableSsl = true
            };
            client.Send("hello@demomailtrap.com", "wyattjeh@gmail.com", "Hello world", "testbody");
            System.Console.WriteLine("Sent");
        }
    }
}
