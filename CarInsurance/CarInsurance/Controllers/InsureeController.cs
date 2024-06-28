using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5

        //public ActionResult Calculate(int id)
        //{
        //    Insuree insuree = db.Insurees.Find(id);
        //    decimal total = 0;
        //    DateTime yearBorn = insuree.DateOfBirth;
        //    DateTime currentDate = DateTime.Now;
            
        //    int currentAge = DateTime.Compare(yearBorn, currentDate);
            
        //    if (currentAge <= 18)
        //    {
        //        total += 100;
        //    }
        //    else if (currentAge > 18 && currentAge <= 25)
        //    {
        //        total += 50;
        //    }
        //    else if (currentAge > 25)
        //    {
        //        total+= 25;
        //    }
        //    else if (insuree.CarYear < 2000)
        //    {
        //        total += 25;
        //    }
        //    else if (insuree.CarYear > 2015)
        //    {
        //        total += 25;
        //    }
        //    else if (insuree.CarMake == "Porshe")
        //    {
        //        total += 25;
        //    }
        //    else if (insuree.CarMake == "Porshe" && insuree.CarModel == "911 Carrera")
        //    {
        //        total += 25;
        //    }
        //    else if (insuree.SpeedingTickets > 0)
        //    {
        //        total += insuree.SpeedingTickets * 10;
        //    }
        //    else if (insuree.DUI == true)
        //    {
        //        total += total * Convert.ToDecimal(1.25);
        //    }
        //    else if(insuree.CoverageType == true)
        //    {
        //        total += total * Convert.ToDecimal(1.5);
        //    }
        //    else
        //    {
        //        total = 50;
        //    }

        //    insuree.Quote = total;
        //    db.SaveChanges();

        //    return RedirectToAction("Index");
            
        //}

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {

            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Insurees.Add(insuree);
                //Insuree insuree = db.Insurees.Find(id);
                decimal total = 0;
                DateTime yearBorn = insuree.DateOfBirth;
                DateTime currentDate = DateTime.Now;

                int currentAge = currentDate.Year - yearBorn.Year;

                if (currentAge <= 18)
                {
                    total += 100;
                }
                else if (currentAge > 18 && currentAge <= 25)
                {
                    total += 50;
                }
                else if (currentAge > 25)
                {
                    total += 25;
                }
                    if (insuree.CarYear < 2000)
                    {
                        total += 25;
                    }
                    else if (insuree.CarYear > 2015)
                    {
                        total += 25;
                    }
                        if (insuree.CarMake == "Porshe")
                        {
                            total += 25;
                        }
                        else if (insuree.CarMake == "Porshe" && insuree.CarModel == "911 Carrera")
                        {
                            total += 25;
                        }
                            if (insuree.SpeedingTickets > 0)
                            {
                                total += insuree.SpeedingTickets * 10;
                            }
                                 if (insuree.DUI == true)
                                 {
                                     total += total * Convert.ToDecimal(1.25);
                                 }
                                 else if (insuree.CoverageType == true)
                                 {
                                     total += total * Convert.ToDecimal(1.5);
                                 }
                else
                {
                    total = 50;
                }

                insuree.Quote = total;
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
