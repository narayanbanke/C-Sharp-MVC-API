using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class loginuser
    {
        bool Login(string username, string password)
        {
            return true;
        }
        bool Register(string username, string password, string email, int mobilenumber)
        {
            return true;
        }
        void LogError(string error) 
        { 
            //some logic
        }
        void Sendemail(string emailcontent)
        {
            //some logic
        }
    }
}
