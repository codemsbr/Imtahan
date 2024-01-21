using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Data.Common;

namespace Imtahan.Models
{
    public class AppUser:IdentityUser
    {
        [MaxLength(16), MinLength(3)]
        public string FirstName { get; set; }
        [MaxLength(16), MinLength(3)]
        public string LastName { get; set; }
    }
}
