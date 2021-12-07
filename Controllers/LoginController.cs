using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SimplBill3.Models;

namespace SimplBill3.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateAccount()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(SimplBill3.Models.Account userModel)
        {
            using (SimplBillEntities db = new SimplBillEntities())
            {
                var userDetails = db.Accounts.Where(x => x.Email == userModel.Email && x.Password == userModel.Password).FirstOrDefault();
                if(userDetails == null)
                {
                    userModel.LogInErrorMessage = "Incorrect email or password";
                    return View("Index", userModel);
                }
                else
                {

                    Session["userEmail"] = userDetails.Email;
                    return RedirectToAction("index", "BillSplitter");
                }
            }
            
        }
        [HttpPost]
        public ActionResult CreateAccount(SimplBill3.Models.Account userModel)
        {
            using (SimplBillEntities db = new SimplBillEntities()) 
            {
                var userEmail = db.Accounts.Where(x => x.Email == userModel.Email).FirstOrDefault();
                if (userEmail != null)
                {
                    userModel.LogInErrorMessage = "An account already exists for this email.";
                    return View("CreateAccount", userModel);
                }
                else
                {
                    db.Accounts.Add(userModel);
                    db.SaveChanges(); 
                    return RedirectToAction("Index", "Home");
                }

            }
        }
        
   
    }
}