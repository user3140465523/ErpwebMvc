using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ErpwebMvc.Controllers
{
    public class Boss : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult BossShow()
        {
            return View();
        }
        public IActionResult GoodsShow()
        {
            return View();
        }
        public IActionResult UserinfoShow()
        {
            return View();
        }
        public IActionResult ProduceShow()
        {
            return View();
        }
        public IActionResult ProduceAdd()
        {
            return View();
        }
        public IActionResult UserinfoAdd()
        {
            return View();
        }
        public IActionResult GoodsAdd()
        {
            return View();
        }
        
        public IActionResult UserinfoDel()
        {
            return View();
        }
        public IActionResult GoodsDel()
        {
            return View();
        }
       
        public IActionResult UserinfoUpt()
        {
            return View();
        }
        public IActionResult GoodsUpt()
        {
            return View();
        }

    }
}
