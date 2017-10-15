using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Fintastic;
using Fintastic.Models;

namespace Fintastic.Controllers
{
    public class BanksController : EAController
    {
   

        // GET: Banks
        public ActionResult Index()
        {
            return View("Banks",base.BaseIndex<Bank>("Banks"));
        }


        // GET: Banks/Create
        public ActionResult Create(int? id)
        {
            return View(base.BaseCreateEdit<Bank>(id, "BankID"));
        }

        // POST: Banks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BankID,_Bank,AcNo,Comment")] Bank bank)
        {
            return base.BaseSave<Bank>(bank);
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
