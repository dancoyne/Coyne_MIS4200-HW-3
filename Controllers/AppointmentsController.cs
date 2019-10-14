using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Coyne_MIS4200.DAL;
using Coyne_MIS4200.Models;

namespace Coyne_MIS4200.Controllers
{
    public class AppointmentsController : Controller
    {
        private MIS4200_Context db = new MIS4200_Context();

        // GET: Appointments
        public ActionResult Index()
        {
            var appoitment = db.Appoitment.Include(a => a.Car).Include(a => a.Owner);
            return View(appoitment.ToList());
        }

        // GET: Appointments/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appoitment appoitment = db.Appoitment.Find(id);
            if (appoitment == null)
            {
                return HttpNotFound();
            }
            return View(appoitment);
        }

        // GET: Appointments/Create
        public ActionResult Create()
        {
            ViewBag.carId = new SelectList(db.Car, "carId", "make");
            ViewBag.ownerID = new SelectList(db.Owner, "ownerID", "firstName");
            return View();
        }

        // POST: Appointments/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "appoitmentID,appoitmentDescription,appoitmentPrice,carId,ownerID")] Appoitment appoitment)
        {
            if (ModelState.IsValid)
            {
                db.Appoitment.Add(appoitment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.carId = new SelectList(db.Car, "carId", "make", appoitment.carId);
            ViewBag.ownerID = new SelectList(db.Owner, "ownerID", "firstName", appoitment.ownerID);
            return View(appoitment);
        }

        // GET: Appointments/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appoitment appoitment = db.Appoitment.Find(id);
            if (appoitment == null)
            {
                return HttpNotFound();
            }
            ViewBag.carId = new SelectList(db.Car, "carId", "make", appoitment.carId);
            ViewBag.ownerID = new SelectList(db.Owner, "ownerID", "firstName", appoitment.ownerID);
            return View(appoitment);
        }

        // POST: Appointments/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "appoitmentID,appoitmentDescription,appoitmentPrice,carId,ownerID")] Appoitment appoitment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appoitment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.carId = new SelectList(db.Car, "carId", "make", appoitment.carId);
            ViewBag.ownerID = new SelectList(db.Owner, "ownerID", "firstName", appoitment.ownerID);
            return View(appoitment);
        }

        // GET: Appointments/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Appoitment appoitment = db.Appoitment.Find(id);
            if (appoitment == null)
            {
                return HttpNotFound();
            }
            return View(appoitment);
        }

        // POST: Appointments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Appoitment appoitment = db.Appoitment.Find(id);
            db.Appoitment.Remove(appoitment);
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
