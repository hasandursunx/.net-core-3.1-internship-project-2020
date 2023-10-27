using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Yoceyder.WebUI.Entity;
using Yoceyder.WebUI.Models.ViewModels;
using Yoceyder.WebUI.Repository.Abstrack;

namespace Yoceyder.WebUI.Controllers
{
    public class ChildController : Controller
    {
        private IUnitOfWork uow;

        public ChildController(IUnitOfWork _uow)
        {
            uow = _uow;
        }

        [HttpGet]
        public IActionResult Create(int id)
        {
            ViewBag.idal = (id);
            return View();
        }
        [HttpPost]
        public IActionResult Create(int id, Child entity)
        {
            if (ModelState.IsValid)
            {
                uow.Children.SaveChild(entity);
                TempData["message"] = $"{entity.Cocuk_AdiSoyadi} yardım başarılı bir şekilde eklendi.";
                return Redirect("~/Parents/Profile/" + id);
            }
            else
            {
                return View(entity);
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(uow.Children.GetById(id));
        }
        [HttpPost]
        public IActionResult Edit(int id ,Child entity)
        {
            if (ModelState.IsValid)
            {
                uow.Children.UpdateChild(entity);
                TempData["message"] = $"{entity.Cocuk_AdiSoyadi} kayıt başarılı bir şekilde güncellendi.";
                return Redirect("~/Child/Profile/" + id);
            }
            return View(entity);
        }

        [HttpGet]
        public IActionResult Profile(int id)
        {
            Child childs = new Child();
            childs = uow.Children.GetById(id);
            var sch = uow.Scholarships.GetAll().Where(k => k.Burs_Cocuk_Id == id);
            CSViewModel cs = new CSViewModel();
            cs.Child = childs;
            cs.Scholarship = sch;
            return View(cs);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(uow.Children.GetById(id));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id,int id2)
        {
            uow.Children.DeleteChild(id);
            TempData["message"] = $"{id} numaralı kayıt silindi.";

            return Redirect("~/Parents/Profile/" + id2);
        }
    }
}