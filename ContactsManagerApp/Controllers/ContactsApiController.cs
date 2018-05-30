using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ContactsManagerApp.Models;

namespace ContactsManagerApp.Controllers
{
    public class ContactsApiController : ApiController
    {
        private ContactsManagerAppContext db = new ContactsManagerAppContext();

        // GET: api/Contacts
        public IQueryable<Contact> GetContact()
        {
            return db.Contact;
        }

        // GET: api/Contacts/5
        [ResponseType(typeof(Contact))]
        public IHttpActionResult GetContact(int id)
        {
            Contact Contact = db.Contact.Find(id);
            if (Contact == null)
            {
                return NotFound();
            }

            return Ok(Contact);
        }

        // PUT: api/Contacts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutContact(int id, Contact Contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != Contact.ContactID)
            {
                return BadRequest();
            }

            db.Entry(Contact).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContactExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Contacts
        [ResponseType(typeof(Contact))]
        public IHttpActionResult PostContact(Contact Contact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
                      
            db.Contact.Add(Contact);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = Contact.ContactID }, Contact);
        }

        // DELETE: api/Contacts/5
        [ResponseType(typeof(Contact))]
        public IHttpActionResult DeleteContact(int id)
        {
            Contact Contact = db.Contact.Find(id);
            if (Contact == null)
            {
                return NotFound();
            }

            db.Contact.Remove(Contact);
            db.SaveChanges();

            return Ok(Contact);
        }        

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ContactExists(int id)
        {
            return db.Contact.Count(e => e.ContactID == id) > 0;
        }
    }
}