using DataAccessLayer.Repositories;
using DuzceUni.DataAccess.Abstract;
using DuzceUni.Entity.Concrete;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Hosting;
using Org.BouncyCastle.Asn1.Ocsp;

namespace DuzceUni.DataAccess.EntityFramework
{
    public class EFAnnouncementRepository : GenericRepository<Announcement>, IAnnouncementDAL
    {


        public async Task<string> AddUploadAsync(IFormFile file, string FolderName)
        {
            if (file != null)
            {
                string Unique = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10);
                string path = "C:\\Projects\\DuzceUniWebsite\\DuzceUni.UI\\wwwroot" + FolderName;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                string filename = string.Concat(Guid.NewGuid().ToString().Replace("-", "").Substring(0, 15), GetMimeTypes(file.ContentType));
                using var fileStream = new FileStream(Path.Combine(path, filename), FileMode.Create);
                await file.CopyToAsync(fileStream);
                return filename;
            }
            else
            {
                return file.FileName;
            }
        }
        private static string GetMimeTypes(string url)
        {
            string str = "";
            switch (url)
            {
                case "application/pdf":
                    str = ".pdf";
                    break;
                case "application/vnd.ms-excel":
                    str = ".xls";
                    break;
                case "application/vnd.ms-word":
                    str = ".doc";
                    break;
                case "application/vnd.openxmlformats-officedocument.presentationml.presentation":
                    str = ".pptx";
                    break;
                case "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet":
                    str = ".xlsx";
                    break;
                case "application/vnd.openxmlformats-officedocument.wordprocessingml.document":
                    str = ".docx";
                    break;
                case "image/gif":
                    str = ".gif";
                    break;
                case "image/jpeg":
                    str = ".jpeg";
                    break;
                case "image/jpg":
                    str = ".jpg";
                    break;
                case "image/png":
                    str = ".png";
                    break;
                case "image/svg+xml":
                    str = ".svg";
                    break;
                case "image/webp":
                    str = ".webp";
                    break;
                case "text/plain":
                    str = ".txt";
                    break;
                case "video/mp4":
                    str = ".mp4";
                    break;
            }
            return str;
        }
    }
}