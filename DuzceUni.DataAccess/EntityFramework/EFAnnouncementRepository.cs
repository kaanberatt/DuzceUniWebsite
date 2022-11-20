using DataAccessLayer.Repositories;
using DuzceUni.DataAccess.Abstract;
using DuzceUni.Entity.Concrete;

namespace DuzceUni.DataAccess.EntityFramework
{
    public class EFAnnouncementRepository:GenericRepository<Announcement>,IAnnouncementDAL
    {
        
    }
}