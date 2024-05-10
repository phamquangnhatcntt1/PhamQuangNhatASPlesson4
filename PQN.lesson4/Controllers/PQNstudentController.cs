using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PQN.lesson4.Controllers
{
    public class PQNstudentController : Controller
    {
        // GET: PQNstudent  
        /// <summary>
        /// author: Phạm Quang Nhất
        /// class: K22CNTT1
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            ViewBag.fullname = "Phạm Quang Nhất";
            ViewData["Birthday"] = "21/05/2004";
            TempData["Phone"] = 0817842585;
            return View();
        }
        public ActionResult Details()
        {
            string pqnstr = "";
            pqnstr += "Phạm Quang Nhất -index";
            pqnstr += "Mã :2210900115";
            pqnstr += "gmail: phamquangnhatdz2105@gmail.com";
            ViewBag.details = pqnstr;

            return View("chitiet");
        }
        public ActionResult NgonNguRazor()
        {
            string[] names = { "Trần Văn A", "Nguyễn Thị B", "Lê Đại C", "Trịnh Lê D" };
            ViewBag.names = names;
            return View();
        }
        public ActionResult AddNewStudent()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewStudent(FormCollection form)
        {
            string fullname = form["Fullname"];
            string masv = form["maSV"];
            string TaiKhoan = form["TaiKhoan"];
            string MatKhau = form["MatKhau"];
            string pqnstr = "<h3>" + fullname + "</h3>";
            pqnstr += "<p>" + masv;
            pqnstr += "<p>" + TaiKhoan;
            pqnstr += "<p>" + MatKhau;

            ViewBag.info = pqnstr;
            return View("Ketqua");
        }
    }
}