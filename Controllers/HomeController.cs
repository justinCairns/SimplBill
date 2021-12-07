using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimplBill3.Models;

namespace SimplBill3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult TipCalculator()
        {
            TipCalculator obj = new TipCalculator();
            obj.total = Convert.ToDecimal(25.00);
            obj.tipPercentage = Convert.ToDecimal(15);
            obj.tipAmount = Convert.ToDecimal(3.75);
            obj.newTotal = Convert.ToDecimal(28.75);

            return View(obj);
        }

        public ActionResult CalculateTip(decimal total, int tipPercentage)
        {
            TipCalculator obj = new TipCalculator();
            obj.total = decimal.Round(total, 2, MidpointRounding.AwayFromZero);
            obj.tipPercentage = tipPercentage;
            obj.percentageConvert = tipPercentage * 0.01M;
            obj.tipAmount = decimal.Round((total * obj.percentageConvert), 2, MidpointRounding.AwayFromZero);
            obj.newTotal = obj.total + obj.tipAmount;

            return View(obj);
        }
    }
}