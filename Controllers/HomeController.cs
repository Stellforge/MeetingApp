using System.Diagnostics;
using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;
            //ViewBag.selamlama = saat > 12 ? "İyi Günler" : "Günaydın";
            //ViewBag.Username = "Furkan Ercelebi";
            //ViewData["Username"] = "Furkan Ercelebi";

            ViewData["Selamlama"]= saat > 12 ? "İyi Günler" : "Günaydın";
            int UserCount = Repostiry.Users.Where(i => i.WillAttend == true).Count();
            var meetingInfo  = new MeetingInfo()
            {
            Id = 1,
            Location = "İstanbul, Abc Kongre Merkezi",
            Date = new DateTime(2025, 01,20, 20, 0 ,0 ),
            NumberOfPeople = UserCount,
            };

            
            return View(meetingInfo);
        }

        public IActionResult Privacy()
        {
            return View();
        }

    
    }
}
