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
    public class NhanVienController : Controller
    {
        // GET: Admin/NhanVien
        public ActionResult Index()
        {
<<<<<<< HEAD
=======
            //test
            DatabaseContext db = new DatabaseContext();
            var t = db.nhanViens.ToList();
            return View();
        }
        public ActionResult ThemNV()
        {
            //test
            DatabaseContext db = new DatabaseContext();
            var t = db.nhanViens.ToList();
>>>>>>> 8e548db (Sửa giao diện Admin Khách hàng và Nhân viên, thêm giao diện thêm khách hàng và nhân viên)
            return View();
        }
    }
}