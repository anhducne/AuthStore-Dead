using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AuthStore.Models;
namespace AuthStore.Controllers
{
    public class HomeController : Controller
    {
        AuthenEntities db = new AuthenEntities();
        // GET: Home
        public ActionResult Index()
        {
            // lan luot tao viewbag de lay list so tu csdl
            //List Hang Dong Xuan moi nhat
            var lstHDXM = db.SanPham.Where(n => n.MaLoaiSP == 1 && n.Moi == 1 && n.DaXoa == false);
            ViewBag.ListHDXM = lstHDXM;
            //List Hang Thu Dong moi nhat
            var lstHTDM = db.SanPham.Where(n => n.MaLoaiSP == 2 && n.Moi == 1 && n.DaXoa == false);
            ViewBag.ListHTDM = lstHTDM;
            //List Hang He Thu moi nhat
            var lstHHTM = db.SanPham.Where(n => n.MaLoaiSP == 3 && n.Moi == 1 && n.DaXoa == false);
            ViewBag.ListHHTM = lstHHTM;
            //List Hang Demo moi nhat
            var lstUnknow = db.SanPham.Where(n => n.MaLoaiSP == 5 && n.Moi == 1 && n.DaXoa == false);
            ViewBag.ListUn = lstUnknow;
            return View();
        }
        public ActionResult BannerPartial()
        {
            return PartialView();
        }

        public ActionResult ContentBotPartial()
        {
            return PartialView();
        }
        public ActionResult MenuPartial()
        {
            var lstSP = db.SanPham;
            return PartialView(lstSP);
        }


    }
}