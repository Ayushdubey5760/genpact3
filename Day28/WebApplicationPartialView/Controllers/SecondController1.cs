using Microsoft.AspNetCore.Mvc;

namespace WebApplicationPartialView.Controllers
{
    public class SecondController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult PartialAction()
        {
            return View("OurPView");
        }
    }
}
