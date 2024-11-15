using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
<<<<<<< HEAD
=======
using Web_ThietBiGiaoDuc.Models;
>>>>>>> 8e548db (Sửa giao diện Admin Khách hàng và Nhân viên, thêm giao diện thêm khách hàng và nhân viên)

namespace Web_ThietBiGiaoDuc.Areas.Admin.Controllers
{
    public class KhachHangController : Controller
    {
        // GET: Admin/KhachHang
        public ActionResult Index()
        {
<<<<<<< HEAD
=======
            //test
            DatabaseContext db = new DatabaseContext();
            var t = db.khachHangs.ToList();
            return View();
        }
        public ActionResult ThemKH()
        {
>>>>>>> 8e548db (Sửa giao diện Admin Khách hàng và Nhân viên, thêm giao diện thêm khách hàng và nhân viên)
            return View();
        }
    }
}