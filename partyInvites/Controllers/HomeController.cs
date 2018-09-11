using partyInvites.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace partyInvites.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ViewResult Index()
        {
            //return "Hello world";
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро братишка" : "Добрый вечер брачо";
            return View();
        }

        [HttpGet]
        public ViewResult RsvpForm()
        {
            return View();
        }

        [HttpPost]
        public ViewResult RsvpForm(GuestResponse guest)
        {
            if (ModelState.IsValid)
                // Нужно отправить данные нового гостя по электронной почте 
                // организатору вечеринки.
                return View("Thanks", guest);
            else
                // Обнаружена ошибка проверки достоверности
                return View();
        }
    }
}