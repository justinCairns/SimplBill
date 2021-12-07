using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimplBill3.Models;

namespace SimplBill3.Controllers
{
    public class BillSplitterController : Controller
    {
        private SimplBillEntities1 _db = new SimplBillEntities1();
        // GET: BillSplitter
        public ActionResult Index()
        {
                return View();  
        }

        public ActionResult orderPage()
        {  
                var userEmail = Session["userEmail"];

            return View( _db.Bills.ToList());

        }
    }
}