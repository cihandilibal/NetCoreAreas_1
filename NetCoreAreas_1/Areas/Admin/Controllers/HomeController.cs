using Microsoft.AspNetCore.Mvc;

namespace NetCoreAreas_1.Areas.Admin.Controllers
{
    //Area'lar Attribute olarak tanımlanmadan calıstırılamaz.
    // yani, [Area("Admin")]

    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
