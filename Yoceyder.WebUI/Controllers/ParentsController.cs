using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Yoceyder.WebUI.Entity;
using Yoceyder.WebUI.Models.ViewModels;
using Yoceyder.WebUI.Repository.Abstrack;

namespace Yoceyder.WebUI.Controllers
{
    public class ParentsController : Controller
    {
        private IUnitOfWork uow;

        public ParentsController(IUnitOfWork _uow )
        {
            uow = _uow;
        }


        public IActionResult Index()
        {
            return View(uow.Parents.GetAll());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = new SelectList(uow.Parents.GetAll(), "Vasi_Id", "Vasi_Adisoyadi");
            return View(uow.Parents.GetById(id));
        }
        [HttpPost]
        public IActionResult Edit(int id,Parent entity)
        {
            if (ModelState.IsValid)
            {
                uow.Parents.UpdateParent(entity);
                TempData["message"] = $"{entity.Vasi_AdiSoyadi} kayıt başarılı bir şekilde güncellendi.";
                return Redirect("~/Parents/Profile/" + id);
            }
            return View(entity);
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View(new Parent());
        }
        [HttpPost]
        public IActionResult Create(Parent entity)
        {
            
            if (ModelState.IsValid)
            {
                uow.Parents.SaveParent(entity);
                TempData["message"] = $"{entity.Vasi_AdiSoyadi} kayıt başarılı bir şekilde eklendi.";
                return RedirectToAction("Index");
            }
           
            return View(entity);
            
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(uow.Parents.GetById(id));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id)
        {
            uow.Parents.DeleteParent(id);
            TempData["message"] = $"{id} numaralı kayıt silindi.";

            return RedirectToAction("Index");

        }
        
        [HttpGet]
        public IActionResult Profile(int id)
        {
            Parent prnt = new Parent();
            prnt = uow.Parents.GetById(id); 
            var dnt = uow.Donations.GetAll().Where(k=>k.Yardim_Vasi_Id == id);
            var chl = uow.Children.GetAll().Where(k => k.Vasi_Id == id);
            PCDViewModel pcd = new PCDViewModel();
            pcd.Parent = prnt;
            pcd.Donation = dnt;
            pcd.Child = chl;

            return View(pcd);
        }

        public IActionResult Dene()
        {
            return View();
        }
    }
}