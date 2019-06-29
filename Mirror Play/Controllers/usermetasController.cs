using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Mirror_Play;

namespace Mirror_Play.Controllers
{
    public class usermetasController : Controller
    {
        private mirrorplay db = new mirrorplay();

        // GET: usermetas
        public ActionResult Index()
        {
            return View(db.usermetas.ToList());
        }

        // GET: usermetas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            usermeta usermeta = db.usermetas.Find(id);
            if (usermeta == null)
            {
                return HttpNotFound();
            }
            return View(usermeta);
        }

        // GET: usermetas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: usermetas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "umeta_id,user_id,meta_key,meta_value")] usermeta usermeta)
        {
            if (ModelState.IsValid)
            {
                db.usermetas.Add(usermeta);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usermeta);
        }

        // GET: usermetas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            usermeta usermeta = db.usermetas.Find(id);
            if (usermeta == null)
            {
                return HttpNotFound();
            }
            return View(usermeta);
        }

        // POST: usermetas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "umeta_id,user_id,meta_key,meta_value")] usermeta usermeta)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usermeta).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usermeta);
        }

        // GET: usermetas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            usermeta usermeta = db.usermetas.Find(id);
            if (usermeta == null)
            {
                return HttpNotFound();
            }
            return View(usermeta);
        }

        // POST: usermetas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            usermeta usermeta = db.usermetas.Find(id);
            db.usermetas.Remove(usermeta);
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
