using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RockPaperScissorsApp.Models;
using System;

namespace RockPaperScissorsApp.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
          return View();
        }

        [HttpPost("/submit")]
        public ActionResult Submit()
        {
          RockPaperScissorsApp newRockPaperScissorsApp = new RockPaperScissorsApp ((Request.Form["player-one-answer"]), (Request.Form["player-two-answer"]), "");
          string WinStatement = newRockPaperScissorsApp.GetWinner((Request.Form["player-one-answer"]), (Request.Form["player-two-answer"]));
          return View("Index", newRockPaperScissorsApp);
        }
    }
}
