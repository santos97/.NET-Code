using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVC_Hotel.Models;
using MVC_Hotel.ViewModel;

namespace MVC_Hotel.Controllers
{
    public class MenusController : Controller
    {
        private MenuContext db = new MenuContext();

        // GET: Menus
        public ActionResult Index()
        {
            return View(db.menudetailes.ToList());
        }

        // GET: Menus/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Menu menu = db.menudetailes.Find(id);
            if (menu == null)
            {
                return HttpNotFound();
            }
            return View(menu);
        }

        // GET: Menus/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Menus/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Cusine_Name,Cusine_Type,Cost")] Menu menu)
        {
            if (ModelState.IsValid)
            {
                db.menudetailes.Add(menu);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(menu);
        }


        public PartialViewResult MenuEdit(int? id)
        {

            Menu menu = db.menudetailes.Find(id);
            MenuViewModel partialmenu = new MenuViewModel()
            {
                Cusine_Type = menu.Cusine_Type,
                Cost = menu.Cost,
                ID = menu.ID,
                Cusine_Name = menu.Cusine_Name
                
            };
            return PartialView("_MenuEdit", partialmenu);
        }


        // GET: Menus/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Menu menu = db.menudetailes.Find(id);
            if (menu == null)
            {
                return HttpNotFound();
            }
            return View(menu);
        }

        // POST: Menus/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Edit([Bind(Include = "ID,Cusine_Name,Cusine_Type,Cost")] Menu menu)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.Entry(menu).State = EntityState.Modified;
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }
        //    return View(menu);
        //}
        public ActionResult Edit([Bind(Include = "ID,Cusine_Name,Cusine_Type,Cost,ModifiedBy")] MenuViewModel viewmenu )
        {
            Menu menu = new Menu { 
            ID=viewmenu.ID,
            Cusine_Name=viewmenu.Cusine_Name,
            Cusine_Type=viewmenu.Cusine_Type,
            Cost=viewmenu.Cost
            };
            if (ModelState.IsValid)
            {
                db.Entry(menu).State = EntityState.Modified;
                db.SaveChanges();
                string SqlconString = ConfigurationManager.ConnectionStrings["MVCConnect"].ConnectionString;
                SqlConnection conn = new SqlConnection(SqlconString);
                conn.Open(); 
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn; 
                cmd.CommandText = "insert into Logs values (" + viewmenu.ID + ",'" + viewmenu.ModifiedBy + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                return RedirectToAction("Index");
            }
            return View(menu);
        }

        // GET: Menus/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Menu menu = db.menudetailes.Find(id);
            if (menu == null)
            {
                return HttpNotFound();
            }
            return View(menu);
        }

        // POST: Menus/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Menu menu = db.menudetailes.Find(id);
            db.menudetailes.Remove(menu);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
