using Buoi4_VoPhamNhutHao.Models;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Buoi4_VoPhamNhutHao.Controllers
{
    public class HomeController : Controller
    {
        // GET: Order
        DataClasses1DataContext data = new DataClasses1DataContext();
        public ActionResult Index(int? page)
        {
            if (page == null) page = 1;
            var all_sach = (from s in data.Saches select s).OrderBy(m => m.masach);
            int pageSize = 3;
            int pageNum = page ?? 1;
            return View(all_sach.ToPagedList(pageNum, pageSize));
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Detail(int id)
        {
            var D_sach = data.Saches.Where(m => m.masach == id).First();
            return View(D_sach);
        }
    }
}