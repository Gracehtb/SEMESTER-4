using Microsoft.AspNetCore.Mvc;
using ProjectRpl.DAL;

namespace ProjectRpl.Controllers
{
    public class HomeController : Controller
    {
        private IProduct _pro;

        public HomeController(IProduct pro)
        {
            _pro = pro;
        }
        public IActionResult Index()
        {
            var data = _pro.GetAll();
            return View(data);
            // }
            // public IActionResult Tampil(){
            //     return View();
            // }
            // // public IActionResult Index1(){
            // //     return View();
            // // }
        }


    }
}