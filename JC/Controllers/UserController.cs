using FoodCart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JC.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public ActionResult Login(User model, string returnUrl)
        {

            using (JCEntities entities = new JCEntities())
            {
                string username = model.username;
                string password = model.password;

                // Now if our password was enctypted or hashed we would have done the
                // same operation on the user entered password here, But for now
                // since the password is in plain text lets just authenticate directly

                var v = entities.users.Where(a => a.username.Equals(username) && a.password.Equals(password)).FirstOrDefault();

                // User found in the database
                if (v != null)
                {
                    Session["username"] = v.username.ToString();
                    Session["fullname"] = v.name.ToString();
                    
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return Content("wrong!");
                }
            }
            
        }

        public ActionResult Logout()
        {
            Session.Remove("username");
            Session.Remove("fullname");           
            return RedirectToAction("Index", "Home");
        }


    }
}