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
    public class DanhMucController : Controller
    {
        // GET: Admin/DanhMuc
        public ActionResult Index()
        {
<<<<<<< HEAD
            return View();
=======
            DatabaseContext db = new DatabaseContext();

            var listDM = db.danhMucs.ToList();
            return View(listDM);
>>>>>>> 8e548db (Sửa giao diện Admin Khách hàng và Nhân viên, thêm giao diện thêm khách hàng và nhân viên)
        }
        public ActionResult Them()
        {
            return View();
        }
<<<<<<< HEAD
        public ActionResult Sua()
        {
            return View();
=======
        [HttpPost]
        public ActionResult Them(DanhMuc dm)
        {
            DatabaseContext db = new DatabaseContext();
            if (dm == null)
            {
                //return RedirectToAction("Index");
            }
            else
            {
                db.danhMucs.Add(dm);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
        public ActionResult Sua(string maDM)
        {
            DatabaseContext db = new DatabaseContext();
            var dm = db.danhMucs.Where(x => x.MaDM == maDM).FirstOrDefault();
            return View(dm);
        }
        [HttpPost]
        public ActionResult Sua(DanhMuc dm)
        {
            DatabaseContext db = new DatabaseContext();
            var danhMuc = db.danhMucs.Where(x => x.MaDM == dm.MaDM).FirstOrDefault();

            //update
            danhMuc.TenDanhMuc = dm.TenDanhMuc;
            danhMuc.TrangThai = dm.TrangThai;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpPost]
        public ActionResult Xoa(string maDM)
        {
            DatabaseContext db = new DatabaseContext();
            var dm = db.danhMucs.Where(x => x.MaDM == maDM).FirstOrDefault();
            dm.TrangThai = "daxoa";

            //db.danhMucs.Remove(dm);
            db.SaveChanges();
            return RedirectToAction("Index");
>>>>>>> 8e548db (Sửa giao diện Admin Khách hàng và Nhân viên, thêm giao diện thêm khách hàng và nhân viên)
        }
    }
}