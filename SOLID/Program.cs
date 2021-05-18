using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class UserService
    {
        public static void Register(string email, string password)
        {
            if (!ValidateEmail(email))
                throw new ValidationException("Email is not an email");
            user user = new user(email, password);

            SendEmail(new MailMessage("mysite@nowhere.com", email) { Subject = "HEllo foo" });
        }
        public static bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
        public static bool SendEmail(MailMessage message)
        {
            SmtpClient _smtpClient = new SmtpClient();
            _smtpClient.Send(message);
            return true;
        }

        public static void Main()
        {
            Register("", "");
        }
        public class user
        {
            public string email { get; set; }
            public string password { get; set; }
            public user(string email, string password)
            {
                this.email = email;
                this.password = password;
            }
        }
    }
}