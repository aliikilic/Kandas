using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos
{
    public class UserRegisterationDto
    {
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Password { get; set; }
       
        [Compare("Password", ErrorMessage = "Şifreler Uyuşmuyor")]
        public string? ConfirmPassword { get; set; }
        public ICollection<string>? Roles { get; set; }
    }
}
