using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using static SRP_Solve.EmailService;

namespace SRP_Solve
{
    public class UserService
    {
        EmailService _emailService;
        // DbContext _dbContext;
        //public UserService(EmailService aEmailService, DbContext aDbContext)
        //{
        //    _emailService = aEmailService;
        //   // _dbContext = aDbContext;
        //}
        public   void Register(string email, string password)
        {
            

            if (!_emailService.ValidateEmail(email))
                throw new ValidationException("Email is not an email");
            Userinfo user = new Userinfo(email, password);
          //  _dbContext.Save(user);
            _emailService.SendEmail(new MailMessage("myname@mydomain.com", email) { Subject = "Hi. How are you!" });

        }
       

        public static void Main()
        {
             
        }
       
    }
    public class EmailService
    {
        SmtpClient _smtpClient;
        public EmailService(SmtpClient aSmtpClient)
        {
            _smtpClient = aSmtpClient;
        }
        public bool ValidateEmail(string email)
        {
            return email.Contains("@");
        }
        public bool SendEmail(MailMessage message)
        {
            _smtpClient.Send(message);
            return true;
        }
        public class Userinfo
        {
            public string email { get; set; }
            public string password { get; set; }
            public Userinfo(string email, string password)
            {
                this.email = email;
                this.password = password;
            }
        }
    }
}