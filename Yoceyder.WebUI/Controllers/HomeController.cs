using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Yoceyder.WebUI.Models;
using Yoceyder.WebUI.Repository.Abstrack;

namespace Yoceyder.WebUI.Controllers
{
    public class HomeController : Controller
    {
        public class ParentsController : Controller
        {
            private IUnitOfWork uow;

            public ParentsController(IUnitOfWork _uow)
            {
                uow = _uow;
            }

            public IActionResult Index(int id)
            {
                var index = uow.Parents.GetById(id);
                return View("Index", index);
            }
        }
    }
}
