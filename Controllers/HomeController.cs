using Microsoft.AspNetCore.Mvc;

namespace NPBookManagement.Controllers
{
    public sealed class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
