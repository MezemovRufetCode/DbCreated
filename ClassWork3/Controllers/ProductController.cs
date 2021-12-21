using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClassWork3.Controllers
{
    public class ProductController:Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
