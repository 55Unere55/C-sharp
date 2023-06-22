using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance1.Models;

namespace CarInsurance1.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities1 db = new InsuranceEntities1();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
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
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAdress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
          
                // Start with a base quote of $50 / month
                double quote = 50;
                int age = DateTime.Now.Year - insuree.DateOfBirth.Year;
                if (age < 18)
                {
                    quote += 100;

                    //if insuree is between 19 - 25
                    if (age >= 19 && age <= 25)
                    {
                        quote += 50;

                    }
                    //if insuree is 25 or over 
                    if (age > 25)
                    {
                        quote += 25;
                    }
                    //if CarYear is older then 2000
                    if (insuree.CarYear < 2000)
                    {
                        quote += 25;
                    }
                    //if CarYear is younger then 2015
                    if (insuree.CarYear > 2015)
                    {
                        quote += 25;
                    }
                    //if Car Make is a Porsche 
                    if (insuree.CarMake == "Porsche")
                    {
                        quote += 25;
                    }
                    //if Car is a Porsche - 911Carrera
                    if (insuree.CarMake == "Porsche" && insuree.CarModel == "911Carrera")
                    {
                        quote += 25;
                    }
                    //if there are Speeding Tickets
                    if (insuree.SpeedingTickets > 0)
                    {
                        quote += insuree.SpeedingTickets * 10;
                    }
                    //if any DUI on Hand
                    if (insuree.DUI == true)
                    {
                        quote *= 1.25;
                    }
                    //check for full Coverage
                    if (insuree.CoverageType.FullCoverage)
                    {
                        bool FullCoverage = true;
                        quote *= 1.50;
                    }
                    else (!insuree.CoverageType.FullCoverage;)
                        {
                        bool FullCoverage = false;
                        }
                 
            
                }
                     db.Insurees.Add(insuree);
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
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAdress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
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
