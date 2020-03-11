

using System;
using Microsoft.AspNetCore.Mvc;
using ProjectRpl.DAL;
using ProjectRpl.Models;

namespace ProjectRpl.Controllers {
    public class ProductController : Controller{
        private IProduct _pro;

        public ProductController (IProduct pro)
        {
            _pro = pro;
        }

        public IActionResult Index(){
            var data = _pro.GetAll();
            return View(data);
        }
        public IActionResult Details(string id)
        {
            var data = _pro.GetById(id);
            return View(data);
        }

        public IActionResult Create(){
            return View();
        }
        [HttpPost]
        public IActionResult Edit(Product pro)
        {
            try{
                _pro.Update(pro);
                ViewData["pesan"] =
                "<span class='alert alert-success'> Product Sudah Diubah</span>";
                return View("Detail", pro);

            }catch(Exception ex)
            {
                return Content($"Error: {ex.Message}");
            }
        }
        public IActionResult Delete(string Id_Product)
        {
            try{
                _pro.Delete(Id_Product);
                var data = _pro.GetAll();
                ViewData["pesan"] =
                "<span class='alert alert-success'> Product Sudah Dihapus</span>";
                return View("Index", data);

            }catch(Exception ex){
                return Content($"Error: {ex.Message}");

            }
        }

        [HttpPost]
        public IActionResult CreatePost(Product pro){

            try
            {
                _pro.Insert(pro);
                ViewData["pesan"] =
                "<span class='alert alert-success'> Data Product Sudah diTambah</span>";
                return View("Create");

            }
            catch (Exception ex)
            {
                ViewData["pesan"] =
                "<span class='alert alert-danger'> Data Gagal Ditambah, " +ex.Message+"</span>";
                return View("Create");


            }

        }

        [HttpPost]
        public IActionResult SearchNama(string keyword){
            var data = _pro.GetAllByNama(keyword);
            return View("Index",data);
        }
   

    }
}