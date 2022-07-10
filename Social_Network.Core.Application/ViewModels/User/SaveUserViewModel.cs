using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Core.Application.ViewModels.User
{
    public class SaveUserViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Debe indicar un nombre")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Debe indicar un apellido")]
        public string LastName { get; set; }

        
        public string ProfilePictureUrl { get; set; }
        [DataType(DataType.Upload)]
        public IFormFile ProfilePicture { get; set; }

        [Required(ErrorMessage = "Debe indicar un correo electronico")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Debe indicar un numero telefonico")]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "ha introducido un formato invalido.")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "Debe indicar un nombre de usuario")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Debe indicar una contraseña")]
        public string Password { get; set; }

        [Compare(nameof(Password), ErrorMessage = "Las contraseñas deben coincidir")]
        public string ConfirmPassword { get; set; }

        public bool IsActive { get; set; }
        public bool UserExit { get; set; } = false;
    }
}
