using DuzceUni.DataAccess.Abstract;
using DuzceUni.Entity.Concrete;
using Microsoft.AspNetCore.Http;

namespace DuzceUni.Business.Abstact
{
    public interface IAnnouncementService:IGenericService<Announcement>
    {

        Task<string> AddUploadAsync(IFormFile file, string FolderName);
    }
}