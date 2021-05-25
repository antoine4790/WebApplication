using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Test = "Coucou";
            TempData["Caca"] = "CHocho";
            Session["President"] = "Trouducul";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            ViewBag.Test = "Coucou";
            TempData["Caca"] = "CHocho";
            Session["President"] = "Trouducul";
            return RedirectToAction("Contact");
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult MyMessages()
        {
            ViewBag.Message = new Message { Emetteur = "caca", Contenu = "contenu1", Date = DateTime.Now };
            return View();
        }

        [HttpPost]
        public ActionResult MyMessages(Message m)
        {
            ViewBag.Message = m;
            return View();
        }

        public ActionResult MyListString()
        {
            ViewBag.Liste = new List<string> { "coucou", "caca", "jiji" };
            return View();
        }

        [HttpPost]
        public ActionResult MyListString(List<string> vals)
        {
            ViewBag.Liste = vals;
            return View();
        }

        public ActionResult MyListMessages()
        {
            ViewBag.ListeMessages = new List<Message> { new Message (){ Emetteur = "caca", Contenu = "contenu1", Date = DateTime.Now } };
            return View();
        }

        [HttpPost]
        public ActionResult MyListMessages(List<Message> vals)
        {
            ViewBag.Liste = vals;
            return View();
        }
    }
}