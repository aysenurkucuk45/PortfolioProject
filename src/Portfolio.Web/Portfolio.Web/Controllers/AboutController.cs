using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Web.Controllers
{
    public class AboutController : Controller
    {
        
            [HttpGet]
            public IActionResult Index() => View();
        
    }
}
