using Microsoft.AspNetCore.Mvc;
using ProjectRpl.DAL;
using ProjectRpl.Models;

namespace ProjectRpl.Controllers {
    public class LoginController : Controller{

        private ILogin _log;

        public LoginController(ILogin log)
        {
            _log = log;
            
        }
        public IActionResult Index(){
            // var data = _log.GetAll();
            return View();
    }
        [HttpPost]
           public IActionResult Login(Login log){
            // var data = _log.GetAll();
            log.username = "Admin1";
            var data = _log.GetById(log.username);
            return RedirectToAction("Index","Home");
    }

    }
}