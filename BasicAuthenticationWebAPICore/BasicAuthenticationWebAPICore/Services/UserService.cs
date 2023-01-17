using BasicAuthenticationWebAPICore.Models;
using System;
using System.Linq;

namespace BasicAuthenticationWebAPICore.Services
{
    public class UserService : IUserService
    {
        private UserContext _context;
        public UserService(UserContext context)
        {
            _context = context;
        }

        public bool ValidateCredentials(string username, string password)
        {
            try
            {
                //Below is the way to access the username even if we don't know the Id
                /*var uname = (from us in _context.Users
                             where us.UserName == username
                             select us).ToList();
                foreach (var item in uname)
                {
                    if ((username == item.UserName) && (password == item.UserPassword))
                    { return true; }

                }
                return false;*/



                // Below is the way to access the username even if we don't know the Id and this way is just a optimization of the above commented code
                var _temp = (from us in _context.Users
                             where (us.UserName == username && us.UserPassword== password)
                             select us);
                if(_temp.Any())
                {
                    return true;   
                }
                return false;
                
            }
            catch(Exception ex) 
            { 
                Console.WriteLine("Error ....: "+ex.Message);
                return false; 
            }

        }
        /*public bool ValidateCredentials(string username, string password)
        {
            return username.Equals("Admin") && password.Equals("password");
        }*/

    }
}
