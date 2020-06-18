using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ErpwebMvc.Controllers
{
    public class list : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult lists()
        {
            return View();
        }
        public IActionResult Show()
        {
            return View();
        }
    }
}
