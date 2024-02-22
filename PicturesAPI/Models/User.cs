using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace PicturesAPI.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
    }
}
