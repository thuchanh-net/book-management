using Microsoft.AspNetCore.Mvc;

namespace NPBookManagement.Controllers
{
    public sealed class UserController : Controller
    {
        public IActionResult Login() => View();
    }
}
