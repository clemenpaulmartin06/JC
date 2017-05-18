using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JC.Controllers
{
    public class LedgerController : Controller
    {

        JCEntities db = new JCEntities();

        // GET: Ledger
        public ActionResult Index()
        {


            if (Session["username"] != null)
            {
                ViewBag.listLedger = db.view_ledger(Session["username"].ToString());
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }



        }

        // GET: Ledger/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Ledger/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ledger/Create
        [HttpPost]
        public ActionResult Create(string description, decimal earned, decimal used)
        {


            if (Session["username"] != null)
            {


                try
                {
                    db.insert_ledger(Session["username"].ToString(), earned, used, description);

                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }


        }

        // GET: Ledger/Edit/5
        public ActionResult Edit(int id)
        {

            if (Session["username"] != null)
            {
                ViewBag.listData = db.view_data(Session["username"].ToString(), id).ToList();
                return View();

            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }

        // POST: Ledger/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, string description, decimal earned, decimal used)
        {
            try
            {
                // TODO: Add update logic here



                if (Session["username"] != null)
                {
                    db.update_data(Session["username"].ToString(), id, description, earned, used);
                    return RedirectToAction("Index");

                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }


            }
            catch
            {
                return View();
            }
        }

        // GET: Ledger/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Ledger/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here


                if (Session["username"] != null)
                {
                    db.delete_data_ledger(id);
                    return RedirectToAction("Index");

                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }

            }
            catch
            {
                return View();
            }
        }
    }
}
