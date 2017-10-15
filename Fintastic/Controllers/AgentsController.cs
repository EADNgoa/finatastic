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
    public class AgentsController : EAController
    {       

        // GET: Agents
        public ActionResult Index()
        {                      
            return View(base.BaseIndex<Agent>("Agents"));            
        }

        
        // GET: Agents/Create
        public ActionResult CreateEdit(int? id)
        {            
            return View(base.BaseCreateEdit<Agent>(id,"AgentID"));
        }

        // POST: Agents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AgentID,_Agent")] Agent agent)
        {
            return base.BaseSave<Agent>(agent);
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
