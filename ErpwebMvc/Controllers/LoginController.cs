using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ErpwebMvc.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// 修改密码
        /// </summary>
        /// <returns></returns>
        public IActionResult UptUserinfo()
        {
            return View();
        }
        /// <summary>
        /// 日志
        /// </summary>
        /// <returns></returns>
        public IActionResult LoginLogsShow()
        {
            return View();
        }
        public IActionResult Logins()
        {
            return View();
        }
        public IActionResult Show()
        {
            return View();
        }
    }
}
