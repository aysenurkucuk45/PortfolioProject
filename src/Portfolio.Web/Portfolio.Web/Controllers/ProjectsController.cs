using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Web.Controllers
{
    public class ProjectsController : Controller
    {
        [HttpGet]
        public IActionResult Index() => View();
    }
}
