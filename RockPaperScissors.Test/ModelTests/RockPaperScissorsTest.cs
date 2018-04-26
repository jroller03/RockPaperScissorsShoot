using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissorsApp.Models;
namespace RockPaperScissorsApp.Controllers
{
  [TestClass]
  public class RockPaperScissorsAppTest
  {
    [TestMethod]
    public void PlayerOneRock_PlayerTwoRock_True()
    {
      RockPaperScissorsApp testRockPaperScissorsApp = new RockPaperScissorsApp();
      Assert.AreEqual(true, testRockPaperScissorsApp.GetWinner("rock", "rock"));
    }
    [TestMethod]
    public void PlayerOneRock_PlayerTwoScissors_True()
    {
      RockPaperScissorsApp testRockPaperScissorsApp = new RockPaperScissorsApp();
      Assert.AreEqual(true, testRockPaperScissorsApp.GetWinner("rock", "scissors"));
    }
    [TestMethod]
    public void PlayerOneRock_PlayerTwoPaper_False()
    {
      RockPaperScissorsApp testRockPaperScissorsApp = new RockPaperScissorsApp();
      Assert.AreEqual(false, testRockPaperScissorsApp.GetWinner("rock", "paper"));
    }
    [TestMethod]
    public void PlayerOneScissors_PlayerTwoPaper_True()
    {
      RockPaperScissorsApp testRockPaperScissorsApp = new RockPaperScissorsApp();
      Assert.AreEqual(true, testRockPaperScissorsApp.GetWinner("scissors", "paper"));
    }
    [TestMethod]
    public void PlayerOnePaper_PlayerTwoScissors_True()
    {
      RockPaperScissorsApp testRockPaperScissorsApp = new RockPaperScissorsApp();
      Assert.AreEqual(false, testRockPaperScissorsApp.GetWinner("paper", "scissors"));
    }
    [TestMethod]
    public void PlayerOne_Or_PlayerTwo_Null_True()
    {
      RockPaperScissorsApp testRockPaperScissorsApp = new RockPaperScissorsApp();
      Assert.AreEqual(true, testRockPaperScissorsApp.GetWinner(null, null));
    }
  }
}
