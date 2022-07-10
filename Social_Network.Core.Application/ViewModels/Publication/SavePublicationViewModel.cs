using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Core.Application.ViewModels.Publication
{
    public class SavePublicationViewModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Tiene que indicar un contenido para la publicacion")]
        public string PublicationContent { get; set; }
        public string PhotoPublicationUrl { get; set; }
        public DateTime Created { get; set; }

        [DataType(DataType.Upload)]
        public IFormFile PhotoPublicationFile { get; set; }
        public int UserId { get; set; }
    }
}
