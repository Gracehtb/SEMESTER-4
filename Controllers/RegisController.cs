using Microsoft.AspNetCore.Mvc;

namespace ProjectRpl.Controllers {
    public class RegisController : Controller{
        public IActionResult Index(){
            return View();
        }
    }
}