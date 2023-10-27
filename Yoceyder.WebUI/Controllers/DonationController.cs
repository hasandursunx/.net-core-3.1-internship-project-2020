using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Yoceyder.WebUI.Entity;
using Yoceyder.WebUI.Models;
using Yoceyder.WebUI.Repository.Abstrack;

namespace Yoceyder.WebUI.Controllers
{
    public class DonationController : Controller
    {
        private IUnitOfWork uow;

        public DonationController(IUnitOfWork _uow)
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
        public IActionResult Create(int  id ,Donation entity)
        {
            if (ModelState.IsValid)
            {
                uow.Donations.SaveDonation(entity);
                TempData["message"] = $"{entity.Yardim_Tur} yardım başarılı bir şekilde eklendi.";
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
            return View(uow.Donations.GetById(id));
        }
        [HttpPost]
        public IActionResult Edit(int id, Donation entity)
        {
            if (ModelState.IsValid)
            {
                uow.Donations.UpdateDonation(entity);
                TempData["message"] = $"{entity.Yardim_Tur} yardım başarılı bir şekilde güncellendi.";
                return Redirect("~/Parents/Profile/" + id);
            }
            else
            {
                return View(entity);
            }
              
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {

            return View(uow.Donations.GetById(id));
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int id, int id2)
        {
            uow.Donations.DeleteDonation(id);
            TempData["message"] = $"{id} numaralı kayıt silindi.";
            return Redirect("~/Parents/Profile/" + id2);
        }
    }
}