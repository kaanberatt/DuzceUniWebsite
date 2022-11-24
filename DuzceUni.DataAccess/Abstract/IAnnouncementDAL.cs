using DuzceUni.Entity.Concrete;
using Microsoft.AspNetCore.Http;

namespace DuzceUni.DataAccess.Abstract
{
    public interface IAnnouncementDAL:IGenericDAL<Announcement>
    {
        Task<string> AddUploadAsync(IFormFile file, string FolderName);
    }
}