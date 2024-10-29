using Microsoft.AspNetCore.Mvc;

namespace SignalRUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
