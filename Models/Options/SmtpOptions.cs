using System;
using MailKit.Security;

namespace BackgroundEmailSenderSample.Models.Options
{
    public class SmtpOptions
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public SecureSocketOptions Security { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Sender { get; set; }
        public int MaxSenderCount { get; set; }
        public TimeSpan DelayOnError { get; set; }
        public TimeSpan DelayMessage { get; set; }
    }
}