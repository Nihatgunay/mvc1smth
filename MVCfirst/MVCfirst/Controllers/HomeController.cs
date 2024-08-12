using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MVCfirst.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int? id)
        {
            if (id is null || id <= 0)
                return RedirectToAction(nameof(Error));
            return View();
        }
        
        public IActionResult Error()
        {
            return View();
        }
    }
}
