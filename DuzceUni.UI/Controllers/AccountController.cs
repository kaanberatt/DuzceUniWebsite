using DuzceUni.Core.Hashing;
using DuzceUni.DataAccess.Concrete;
using DuzceUni.Entity.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace DuzceUni.UI.Controllers
{
    [AllowAnonymous]
    public class AccountController:Controller
    {
        [Route("/cms/account/login/")]
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [Route("/cms/account/login/")]
        [HttpPost]
        public async Task<IActionResult> Login(Admin admin)
        {
            Context context = new Context();
            admin.AdminPasswordHash = HashingHelper.HashPassword(admin.AdminPassword);
            var datavalues = context.Admins.FirstOrDefault(x => x.AdminMail == admin.AdminMail && x.AdminPasswordHash == admin.AdminPasswordHash);
            if (datavalues != null)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,"user")
                };
                var userIdentity = new ClaimsIdentity(claims, "user");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);
                ViewBag.message = "Giriş Başarılı";
                return RedirectToAction("Index", "Announcement");
            }
            else
            {
                ViewBag.message = "E-Mail Adresiniz veya Parolanız hatalı lütfen tekrar deneyiniz";
                return View();
            }
            return View();
        }
    }
}