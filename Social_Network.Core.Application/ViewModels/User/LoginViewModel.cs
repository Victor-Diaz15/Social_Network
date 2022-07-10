using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Core.Application.ViewModels.User
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Tiene que indicar un usuario")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Tiene que indicar una contraseña")]
        public string Password { get; set; }
    }
}
