using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using RockPaperScissors.Models;
using System;

namespace RockPaperScissors.Controllers
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
          RockPaperScissors newRockPaperScissors = new RockPaperScissors ((Request.Form["player-one-answer"]), (Request.Form["player-two-answer"]), "");
          string WinStatement = newRockPaperScissors.GetWinner((Request.Form["player-one-answer"]), (Request.Form["player-two-answer"]));
          return View("Index", newRockPaperScissors);
        }
    }
}
