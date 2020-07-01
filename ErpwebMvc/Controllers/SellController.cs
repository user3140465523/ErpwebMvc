using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ErpwebMvc.Controllers
{
    public class SellController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //销量
        public ActionResult Faction()
        {
            return View();
        }
        //显示商品信息
        public ActionResult ShowGoods()
        {
            return View();
        }
        //申请加薪
        public ActionResult AddMoney()
        {
            return View();
        }
        //评级 
        public ActionResult Assess()
        {
            return View();
        }
         
        //主页
        public ActionResult SellShow()
        {
            return View();
        }

    }
}