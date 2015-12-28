using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ezzay.Models;

namespace Ezzay.Controllers
{
    public class TutorController : Controller
    {
        private SchoolContext db = new SchoolContext();

        //
        // GET: /Tutor/

        public ActionResult Index()
        {
            return View(db.Tutors.ToList());
        }

        //
        // GET: /Tutor/Details/5

        public ActionResult Details(int id = 0)
        {
            Tutor tutor = db.Tutors.Find(id);
            if (tutor == null)
            {
                return HttpNotFound();
            }
            return View(tutor);
        }

        //
        // GET: /Tutor/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Tutor/Create

        [HttpPost]
        public ActionResult Create(Tutor tutor)
        {
            if (ModelState.IsValid)
            {
                db.Tutors.Add(tutor);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tutor);
        }

        //
        // GET: /Tutor/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Tutor tutor = db.Tutors.Find(id);
            if (tutor == null)
            {
                return HttpNotFound();
            }
            return View(tutor);
        }

        //
        // POST: /Tutor/Edit/5

        [HttpPost]
        public ActionResult Edit(Tutor tutor)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tutor).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tutor);
        }

        //
        // GET: /Tutor/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Tutor tutor = db.Tutors.Find(id);
            if (tutor == null)
            {
                return HttpNotFound();
            }
            return View(tutor);
        }

        //
        // POST: /Tutor/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Tutor tutor = db.Tutors.Find(id);
            db.Tutors.Remove(tutor);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}