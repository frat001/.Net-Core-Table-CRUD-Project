using Microsoft.AspNetCore.Mvc;
using BusinessLayer.Tables;

namespace tabloyenikayit.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {                   
            return View();
        }
    }
}
