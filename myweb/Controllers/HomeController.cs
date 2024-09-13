using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace myweb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        // mỗi controller có nhiều view
        // mỗi view chỉ có 1 controller
        public ActionResult Index()
        {
            return View();
        }
        // thêm 1 view để hiện tên có tên là hienten
        public ActionResult hienten()
        {
            return View();
        }
    }
}