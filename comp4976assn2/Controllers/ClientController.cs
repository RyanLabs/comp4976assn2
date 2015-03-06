using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using comp4976assn2.Models;

namespace comp4976assn2.Controllers
{
    public class ClientController : Controller
    {
        private ClientContext db = new ClientContext();

        // GET: /Client/
        public async Task<ActionResult> Index()
        {
            return View(await db.Clients.ToListAsync());
        }

        // GET: /Client/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientModel clientmodel = await db.Clients.FindAsync(id);
            if (clientmodel == null)
            {
                return HttpNotFound();
            }
            return View(clientmodel);
        }

        // GET: /Client/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: /Client/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include="ClientReferenceNumber,Month,Day,Surname,Firstname,PoliceFileNumber,CourtFileNumber,SwcFileNumber,RiskAssessmentAssignedTo,AbuserName,NumberChildren6,NumberChildren12,NumberChildren18,DateLastTransfered,DateClosed,DateReopened")] ClientModel clientmodel)
        {
            if (ModelState.IsValid)
            {
                db.Clients.Add(clientmodel);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(clientmodel);
        }

        // GET: /Client/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientModel clientmodel = await db.Clients.FindAsync(id);
            if (clientmodel == null)
            {
                return HttpNotFound();
            }
            return View(clientmodel);
        }

        // POST: /Client/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include="ClientReferenceNumber,Month,Day,Surname,Firstname,PoliceFileNumber,CourtFileNumber,SwcFileNumber,RiskAssessmentAssignedTo,AbuserName,NumberChildren6,NumberChildren12,NumberChildren18,DateLastTransfered,DateClosed,DateReopened")] ClientModel clientmodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clientmodel).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(clientmodel);
        }

        // GET: /Client/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClientModel clientmodel = await db.Clients.FindAsync(id);
            if (clientmodel == null)
            {
                return HttpNotFound();
            }
            return View(clientmodel);
        }

        // POST: /Client/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ClientModel clientmodel = await db.Clients.FindAsync(id);
            db.Clients.Remove(clientmodel);
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
