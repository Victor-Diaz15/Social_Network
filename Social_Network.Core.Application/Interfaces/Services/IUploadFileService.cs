using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Core.Application.Interfaces.Services
{
    public interface IUploadFileService
    {
        string UploadFile(IFormFile file, string _basePath, bool isEditMode = false, string imgUrl = "");
    }
}
