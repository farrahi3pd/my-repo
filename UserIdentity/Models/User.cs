using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;


namespace UserIdentity.Models
{
    public class User : IdentityUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }

    }

}
