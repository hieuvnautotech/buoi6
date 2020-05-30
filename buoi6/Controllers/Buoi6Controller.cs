using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using buoi6.Models;
using Microsoft.AspNetCore.Mvc;
using buoi6.Models;
namespace buoi6.Controllers
{
    public class Buoi6Controller : Controller
    {
        public IActionResult TruyenDuLieu1() 
        {
            ViewBag.NgayThanhLap = new DateTime(2003, 3, 10);
            ViewBag.Ten = "Nhat Nghe";
            ViewData["Tuoi"]= 17;
            ViewData["DienThoai"] = "123123123123";

            ViewBag.Sanpham = new HangHoa
            {
                MaHH = 1, TenHH = "bia sai gon", DonGia = 12000, GiamGia = 3
            };

            return View();
        }

        [Route("/dien-thoai/{tenDienThoai}")]
        public IActionResult ChiTiet(string tenDienThoai) 
        {
            return Content(tenDienThoai);
        }
        [Route("/{loai}/{sanpham}")]
        public IActionResult ChiTiet(string loai,string sanpham)
        {
            return Content($"{loai} - {sanpham}");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}