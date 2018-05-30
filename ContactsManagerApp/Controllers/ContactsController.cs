using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactsManagerApp.Client;
using ContactsManagerApp.Models;

namespace ContactsManagerApp.Controllers
{
    public class ContactsController : Controller
    {
        // GET: Contacts
        public ActionResult Index()
        {
            ContactsClient contacts = new ContactsClient();
            IEnumerable<Contact> contactsList = contacts.FindAll();            
            return View(contactsList);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            ContactsClient contacts = new ContactsClient();
            contacts.Create(contact);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ContactsClient contacts = new ContactsClient();
            Contact  contact = contacts.Find(id);
            return View("Edit", contact);
        }

        [HttpPost]
        public ActionResult Edit(Contact contact)
        {
            ContactsClient contacts = new ContactsClient();
            contacts.Edit(contact);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            ContactsClient contacts = new ContactsClient();
            Contact contact = contacts.Find(id);
            return View("Delete", contact);
        }

        [HttpPost]
        public ActionResult Delete(Contact contact)
        {
            ContactsClient contacts = new ContactsClient();
            contacts.Delete(contact.ContactID);
            return RedirectToAction("Index");
        }
        

    }
}