using Microsoft.AspNetCore.Http;
using Social_Network.Core.Application.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Social_Network.Infrastructure.Shared.Services
{
    public class UploadFileService : IUploadFileService
    {
        public string UploadFile(IFormFile file, string _basePath, bool isEditMode = false, string imgUrl = "")
        {
            if (isEditMode && file == null)
            {
                return imgUrl;
            }
            else if (file == null)
            {
                return imgUrl;
            }

            //get directory path
            string basePath = _basePath;
            string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot{basePath}");

            //Create a folder if not exist
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }

            //get file path
            Guid guid = Guid.NewGuid();
            FileInfo fileInfo = new(file.FileName);
            string fileName = guid + fileInfo.Extension;

            string fileNameWithPath = Path.Combine(path, fileName);

            using (var stream = new FileStream(fileNameWithPath, FileMode.Create))
            {
                file.CopyTo(stream);
            }

            if (isEditMode)
            {
                string[] oldImgPart = imgUrl.Split("/");
                string oldImgPath = oldImgPart[^1];
                string completeImgPath = Path.Combine(path, oldImgPath);

                if (System.IO.File.Exists(completeImgPath))
                {
                    System.IO.File.Delete(completeImgPath);
                }
            }

            return $"{basePath}/{fileName}";
        }
    }
}
