using UserIdentity.Models;

namespace UserIdentity.Controllers
{
    public class UserLoginModel
    {
        public User UserName { get; internal set; }
        public string Password { get; internal set; }
    }
}