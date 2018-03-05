using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Presentation.WebApplication.ServiceWereHouse;

namespace Presentation.WebApplication.Controllers
{
    public class WereHouseController : Controller
    {
        private readonly IServiceWereHouse _serviceWereHouse;

        public WereHouseController(IServiceWereHouse serviceWereHouse) 
        {
            _serviceWereHouse = serviceWereHouse;
        }

        public ActionResult WereHouse()
        {
            return View();
        }


        public ActionResult Products()
        {
            var products = _serviceWereHouse.GetAllProducts();

            return View();
        }

        [HttpGet]
        public JsonResult productos()
        {
            var products = _serviceWereHouse.GetAllProducts().ToList();

            return Json(products, JsonRequestBehavior.AllowGet);
        }
       
    }
}