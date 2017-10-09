using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AddressMvc.Models;

namespace AddressMvc.Controllers
{
    public class ContactTypesController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ContactTypes
        public async Task<ActionResult> Index()
        {
            return View(await db.ContactTypes.ToListAsync());
        }

        // GET: ContactTypes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactType contactType = await db.ContactTypes.FindAsync(id);
            if (contactType == null)
            {
                return HttpNotFound();
            }
            return View(contactType);
        }

        // GET: ContactTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ContactTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,Name")] ContactType contactType)
        {
            if (ModelState.IsValid)
            {
                db.ContactTypes.Add(contactType);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(contactType);
        }

        // GET: ContactTypes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactType contactType = await db.ContactTypes.FindAsync(id);
            if (contactType == null)
            {
                return HttpNotFound();
            }
            return View(contactType);
        }

        // POST: ContactTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,Name")] ContactType contactType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contactType).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(contactType);
        }

        // GET: ContactTypes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContactType contactType = await db.ContactTypes.FindAsync(id);
            if (contactType == null)
            {
                return HttpNotFound();
            }
            return View(contactType);
        }

        // POST: ContactTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ContactType contactType = await db.ContactTypes.FindAsync(id);
            db.ContactTypes.Remove(contactType);
            await db.SaveChangesAsync();
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
