using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Yoceyder.WebUI.Entity;
using Yoceyder.WebUI.Repository.Abstrack;

namespace Yoceyder.WebUI.Controllers
{
    public class ScholarshipController : Controller
    {
        private IUnitOfWork uow;

        public ScholarshipController(IUnitOfWork _uow)
        {
            uow = _uow;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create(int id)
        {
            ViewBag.idal = (id);
            return View();
        }
        [HttpPost]
        public IActionResult Create(int id, Scholarship entity)
        {
            if (ModelState.IsValid)
            {
                uow.Scholarships.SaveScholarship(entity);
                TempData["message"] = $"{entity.Burs_Id} burs başarılı bir şekilde eklendi.";
                return Redirect("~/Child/Profile/" + id);
            }
            else
            {
                return View(entity);
            }
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(uow.Scholarships.GetById(id));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id, int id2)
        {
            uow.Scholarships.DeleteScholarship(id);
            TempData["message"] = $"{id} numaralı kayıt silindi.";
            return Redirect("~/Child/Profile/" + id2);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            return View(uow.Scholarships.GetById(id));
        }
        [HttpPost]
        public IActionResult Edit(int id, Scholarship entity)
        {
            if (ModelState.IsValid)
            {
                uow.Scholarships.UpdateScholarship(entity);
                TempData["message"] = $"{entity.Burs_Miktar} tl miktarındaki burs başarılı bir şekilde güncellendi.";
                return Redirect("~/Child/Profile/" + id);
            }
            else
            {
                return View(entity);
            }
        }
    }
}