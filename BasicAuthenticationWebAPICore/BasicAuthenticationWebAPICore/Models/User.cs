using System.ComponentModel.DataAnnotations;

namespace BasicAuthenticationWebAPICore.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; } //To avoid the int at(0) exception we are commenting the id now the users list will contain username at (0) and Password at (1) or int was comming at (0)

        public string UserName { get; set; }

        public string UserPassword { get; set; }
    }
}
