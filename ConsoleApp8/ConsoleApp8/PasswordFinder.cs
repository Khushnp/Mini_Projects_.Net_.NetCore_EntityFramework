using Org.BouncyCastle.OpenSsl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class PasswordFinder : IPasswordFinder
    {
        private string password;

        public PasswordFinder()
        {
            this.password = "password";
            
        }


        public char[] GetPassword()
        {
            return password.ToCharArray();
        }
    }
}
