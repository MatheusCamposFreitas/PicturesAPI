using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PicturesAPI.Data.Dtos
{
    public class CreateUserDto
    {
        [Required, StringLength(30, MinimumLength = 2)]
        public string UserName { get; set; }

        [Required, StringLength(40, MinimumLength = 2)]
        public string FullName { get; set; }

        [Required, EmailAddress(ErrorMessage = "Invalid e-mail")]
        public string Email { get; set; }

        [Required, StringLength(14, MinimumLength = 8), DefaultValue("String@123")]
        public string Password { get; set; }
    }
}
