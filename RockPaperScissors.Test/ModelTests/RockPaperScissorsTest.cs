using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;
namespace RockPaperScissors.Controllers
{
  [TestClass]
  public class RockPaperScissorsTest
  {
    [TestMethod]
    public void PlayerOneRock_PlayerTwoRock_True()
    {
      RockPaperScissors testRockPaperScissors = new RockPaperScissors();
      Assert.AreEqual(true, testRockPaperScissors.GetWinner("rock", "rock"));
    }
    [TestMethod]
    public void PlayerOneRock_PlayerTwoScissors_True()
    {
      RockPaperScissors testRockPaperScissors = new RockPaperScissors();
      Assert.AreEqual(true, testRockPaperScissors.GetWinner("rock", "scissors"));
    }
    [TestMethod]
    public void PlayerOneRock_PlayerTwoPaper_False()
    {
      RockPaperScissors testRockPaperScissors = new RockPaperScissors();
      Assert.AreEqual(false, testRockPaperScissors.GetWinner("rock", "paper"));
    }
    [TestMethod]
    public void PlayerOneScissors_PlayerTwoPaper_True()
    {
      RockPaperScissors testRockPaperScissors = new RockPaperScissors();
      Assert.AreEqual(true, testRockPaperScissors.GetWinner("scissors", "paper"));
    }
    [TestMethod]
    public void PlayerOnePaper_PlayerTwoScissors_True()
    {
      RockPaperScissors testRockPaperScissors = new RockPaperScissors();
      Assert.AreEqual(false, testRockPaperScissors.GetWinner("paper", "scissors"));
    }
    [TestMethod]
    public void PlayerOne_Or_PlayerTwo_Null_True()
    {
      RockPaperScissors testRockPaperScissors = new RockPaperScissors();
      Assert.AreEqual(true, testRockPaperScissors.GetWinner(null, null));
    }
  }
}
