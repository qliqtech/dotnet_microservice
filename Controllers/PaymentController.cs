using Microsoft.AspNetCore.Mvc;

namespace PlatformService.Controllers
{
    public class PaymentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
