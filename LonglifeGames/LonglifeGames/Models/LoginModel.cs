using System;
using System.ComponentModel.DataAnnotations;

namespace LonglifeGames.Models
{
    public class LoginModel
    {
        [Required]
        public string Login { get; set; }
        [Required]
        public string Password { get; set; }
        public string IP { get; set; }
        public string Country { get; set; }
        public string DateTime { get; set; }
        public string Actions { get; set; }
    }
}
