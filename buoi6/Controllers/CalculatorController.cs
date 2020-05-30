using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace buoi6.Controllers
{
    public class CalculatorController : Controller
    {
        [HttpGet]
        public IActionResult Calculate() 
        {
            return View();
        }
        [HttpPost]
        public IActionResult Calculate(double ToanHang1, double ToanHang2, string PhepToan) 
        {
            double KetQua = 0;
            switch (PhepToan) 
            {
                case "+": KetQua = ToanHang1 + ToanHang2;
                    break;
                case "-": KetQua = ToanHang1 - ToanHang2;
                    break;
                case "*": KetQua = ToanHang1 * ToanHang2;
                    break;
                case "/": KetQua = ToanHang1 / ToanHang2;
                    break;
                case "^": KetQua = Math.Pow(ToanHang1 ,ToanHang2);
                    break;
                    

            }

            ViewBag.A = ToanHang1;
            ViewBag.B = ToanHang2;
            ViewBag.C = PhepToan;
            ViewBag.D = KetQua;


            return View("Index");
            //return Content($"{ToanHang1}{PhepToan}{ToanHang2}={KetQua}");
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}