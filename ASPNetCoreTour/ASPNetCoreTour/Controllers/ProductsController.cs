using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreTour.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
