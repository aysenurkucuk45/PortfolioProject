using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Web.Controllers
{
    public class ContactController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View();
    }
}
