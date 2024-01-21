using System.ComponentModel.DataAnnotations;

namespace Imtahan.ViewModels.Auth
{
    public class RegisterVm
    {
        [MaxLength(16), MinLength(3)]
        public string FirstName { get; set; }
        [MaxLength(16), MinLength(3)]
        public string LastName { get; set; }
        [MaxLength(16), MinLength(3)]
        public string UserName { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [MinLength(6), MaxLength(16), DataType(DataType.Password), Compare(nameof(ConfirmPassword))]

        public string Password { get; set; }
        [MinLength(6), MaxLength(16), DataType(DataType.Password)]

        public string ConfirmPassword { get; set; }
    }
}
