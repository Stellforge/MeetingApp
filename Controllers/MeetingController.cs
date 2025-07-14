using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class MeetingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Apply(UserInfo model)
        {
            if (ModelState.IsValid) 
            { 
            Repostiry.CreatedUser(model);
            ViewBag.UserCount = Repostiry.Users.Where(i => i.WillAttend == true).Count();
            return View("Thanks", model);
            }
            else
            {
                return View(model);   
                    }
        }

        public IActionResult Thanks()
        {
            return View();
        }

        [HttpGet]
        public IActionResult List()
        {
            return View(Repostiry.Users);
        }

        public IActionResult Details(int id)
        {
            return View(Repostiry.GetById(id));
        }


    }
}
