using DuzceUni.Business.Abstact;
using DuzceUni.Business.Concrete;
using DuzceUni.DataAccess.Abstract;
using DuzceUni.DataAccess.EntityFramework;
using DuzceUni.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Authorization;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace DuzceUni.UI.Controllers
{
    public class AnnouncementController:Controller
    {
        AnnouncementManager announcementManager = new AnnouncementManager(new EFAnnouncementRepository());

        [HttpGet]
        public IActionResult Index()
        {
            var values = announcementManager.TGetList();
            return View(values); 
        }

        [HttpGet]
        public IActionResult AnnouncementAdd()
        {
            return View();
        }
        [HttpPost]
        public async  Task<IActionResult> AnnouncementAdd(Announcement announcement, IFormFile file)
        {
            try
            {
                var FileCode = await announcementManager.AddUploadAsync(file, "/file/Photos/");
                announcement.AnnouncementImage = FileCode;
                announcement.AnnouncementThumbnail = FileCode;
                announcementManager.TAdd(announcement);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            return RedirectToAction("Index", "Announcement");
        }
        public IActionResult AnnouncementDelete(int id)
        {
            var values = announcementManager.TGetById(id);
            announcementManager.TDelete(values);
            return RedirectToAction("Index","Announcement");
        }
        [HttpGet]
        public IActionResult AnnouncementEdit(int id)
        {
            var value = announcementManager.TGetById(id);
            return View(value);
        }
        [HttpPost]
        public async Task<IActionResult> AnnouncementEdit(Announcement announcement,IFormFile file)
        {
            if (file != null)
            {
                var FileCode = await announcementManager.AddUploadAsync(file, "/file/Photos/");
                announcement.AnnouncementImage = FileCode;
                announcement.AnnouncementThumbnail = FileCode;
            }
            else
            {
                announcement.AnnouncementThumbnail = announcement.AnnouncementImage;
            }
            announcementManager.TUpdate(announcement);
            return RedirectToAction("Index","Announcement");
        }
    }
}
