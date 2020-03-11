using Microsoft.AspNetCore.Mvc;

namespace ProjectRpl.Controllers {
    public class TampilController : Controller{
        public IActionResult Index(){
            return View();
        }
    }
}