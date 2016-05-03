using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Stanely5_3.Models;

namespace Stanely5_3.Controllers
{
    public class PropertyModelsController : Controller
    {
        private Stanely5_3Context db = new Stanely5_3Context();

        // GET: PropertyModels
        public ActionResult Index()
        {
            return View(db.PropertyModels.ToList());
        }

        // GET: PropertyModels/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropertyModel propertyModel = db.PropertyModels.Find(id);
            if (propertyModel == null)
            {
                return HttpNotFound();
            }
            return View(propertyModel);
        }

        // GET: PropertyModels/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PropertyModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "PropertyID,Title,Description,ImageSource")] PropertyModel propertyModel)
        {
            if (ModelState.IsValid)
            {
                db.PropertyModels.Add(propertyModel);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(propertyModel);
        }

        // GET: PropertyModels/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropertyModel propertyModel = db.PropertyModels.Find(id);
            if (propertyModel == null)
            {
                return HttpNotFound();
            }
            return View(propertyModel);
        }

        // POST: PropertyModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "PropertyID,Title,Description,ImageSource")] PropertyModel propertyModel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(propertyModel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(propertyModel);
        }

        // GET: PropertyModels/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PropertyModel propertyModel = db.PropertyModels.Find(id);
            if (propertyModel == null)
            {
                return HttpNotFound();
            }
            return View(propertyModel);
        }

        // POST: PropertyModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            PropertyModel propertyModel = db.PropertyModels.Find(id);
            db.PropertyModels.Remove(propertyModel);
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
