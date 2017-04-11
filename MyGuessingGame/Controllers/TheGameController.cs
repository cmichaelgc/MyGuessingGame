using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyGuessingGame.Controllers
{
    public class TheGameController : Controller
    {
        // GET: TheGame
        public ActionResult Index()
        {
            return View();
        }
    }
}