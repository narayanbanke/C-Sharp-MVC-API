using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{/// <summary>
/// single responsiblity princple
/// </summary>
    public class User : IUser, Ilogger, IEmail
    {
        public void LogError(string error)
        {
            //some logic
        }

        public bool Login(string username, string password)
        {
            if (username == password)
                return true;
            else
                return false;
        }

        public bool Register(string username, string password, string email, int mobilenumber)
        {
            return true;
        }

        public void Sendemail(string emailcontent)
        {
            //some logic
        }
    }

    interface IUser
    {
        bool Login(string username, string password);
       

        bool Register(string username, string password, string email, int mobilenumber);

    }
    interface Ilogger
    {
        void LogError(string error);
    }
    interface IEmail
    {
        void Sendemail(string emailcontent);
    }
    class Errorlogging : Ilogger
    {
        public void LogError(string error)
        {
            //some logic
        }
    }
    class order : IEmail
    {
        public void Sendemail(string emailcontent)
        {
            throw new NotImplementedException();
        }
    }
}