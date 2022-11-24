using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DuzceUni.UI.Models;
using DuzceUni.Business.Concrete;
using DuzceUni.DataAccess.EntityFramework;
using Microsoft.AspNetCore.Authorization;

namespace DuzceUni.UI.Controllers;

[AllowAnonymous]
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private AnnouncementManager announcementManager = new AnnouncementManager(new EFAnnouncementRepository());

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var values = announcementManager.TGetList().Where(x => x.BlogStatus == true).ToList();
        return View(values);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
