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
    public class SanPhamController : Controller
    {
        // GET: Admin/SanPham
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Them()
        {
            return View();
        }
<<<<<<< HEAD
=======
        [HttpPost]
        public ActionResult Them(SanPham sp, IEnumerable<HttpPostedFileBase> HinhAnh)
        {
            return View();
        }
>>>>>>> 8e548db (Sửa giao diện Admin Khách hàng và Nhân viên, thêm giao diện thêm khách hàng và nhân viên)
        public ActionResult Sua()
        {
            return View();
        }
    }
}