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
    public class videometasController : Controller
    {
        private mirrorplay db = new mirrorplay();

        // GET: videometas
        public ActionResult Index()
        {
            return View(db.videometas.ToList());
        }

        // GET: videometas/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            videometa videometa = db.videometas.Find(id);
            if (videometa == null)
            {
                return HttpNotFound();
            }
            return View(videometa);
        }

        // GET: videometas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: videometas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "meta_id,post_id,meta_key,meta_value")] videometa videometa)
        {
            if (ModelState.IsValid)
            {
                db.videometas.Add(videometa);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(videometa);
        }

        // GET: videometas/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            videometa videometa = db.videometas.Find(id);
            if (videometa == null)
            {
                return HttpNotFound();
            }
            return View(videometa);
        }

        // POST: videometas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "meta_id,post_id,meta_key,meta_value")] videometa videometa)
        {
            if (ModelState.IsValid)
            {
                db.Entry(videometa).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(videometa);
        }

        // GET: videometas/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            videometa videometa = db.videometas.Find(id);
            if (videometa == null)
            {
                return HttpNotFound();
            }
            return View(videometa);
        }

        // POST: videometas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            videometa videometa = db.videometas.Find(id);
            db.videometas.Remove(videometa);
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
