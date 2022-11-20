using DuzceUni.Business.Abstact;
using DuzceUni.DataAccess.Abstract;
using DuzceUni.Entity.Concrete;

namespace DuzceUni.Business.Concrete
{
    public class AnnouncementManager : IAnnouncementService
    {
        IAnnouncementDAL announcementDAL;
        public AnnouncementManager(IAnnouncementDAL _announcementDAL)
        {
            announcementDAL = _announcementDAL;
        }
        public void TAdd(Announcement t)
        {
            announcementDAL.Insert(t);
        }

        public void TDelete(Announcement t)
        {
            announcementDAL.Delete(t);
        }

        public Announcement TGetById(int id)
        {
            return announcementDAL.GetById(id);
        }

        public List<Announcement> TGetList()
        {
            return announcementDAL.GetListAll().ToList();
        }

        public void TUpdate(Announcement t)
        {
            announcementDAL.Update(t);
        }
    }
}