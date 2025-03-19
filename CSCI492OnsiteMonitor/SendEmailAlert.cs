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
                Credentials = new NetworkCredential("api", "804a1038ef9b4f1685d97f26c1b65dff"),
                EnableSsl = true
            };
            
            client.Send("hello@demomailtrap.co", "onsitemonitoralert@gmail.com", "The system is ON FIRE!!!", "Yup, automatically turning off the system. The heat has began to get to over 5,000 degrees.");
            System.Console.WriteLine("Sent");
        }
    }
}
