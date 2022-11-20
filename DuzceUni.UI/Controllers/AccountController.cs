using DuzceUni.Core.Hashing;
using DuzceUni.DataAccess.Concrete;
using DuzceUni.Entity.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace DuzceUni.UI.Controllers
{
    public class AccountController:Controller
    {
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(Admin admin)
        {
            Context context=new Context();
            admin.AdminPasswordHash = HashingHelper.HashPassword(admin.AdminPasswordHash);
            var datavalues = context.Admins.FirstOrDefault(x=>x.AdminMail==admin.AdminMail && x.AdminPasswordHash==admin.AdminPasswordHash);
            return RedirectToAction("Index","Home");
        }
    }
}