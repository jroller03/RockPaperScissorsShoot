using System.Collections.Generic;
using System.IO;
using System;
namespace RockPaperScissorsApp.Models
{
  public class RockPaperScissors
  {
    private string _playerOne = null;
    private string _playerTwo = null;
    private string _winStatement = "";

    public RockPaperScissors(string PlayerOne, string PlayerTwo, string winStatement)
    {
      _playerOne = PlayerOne;
      _playerTwo = PlayerTwo;
      _winStatement = winStatement;
    }
    public string GetPlayerOne()
    {
      return _playerOne;
    }

    public void SetPlayerOne(string newPlayerOne)
    {
      _playerOne = newPlayerOne;
    }
    public string GetPlayerTwo()
    {
      return _playerTwo;
    }

    public void SetPlayerTwo(string newPlayerTwo)
    {
      _playerTwo = newPlayerTwo;
    }
    public string GetWinStatement()
    {
      return _winStatement;
    }

    public void SetWinStatement(string newWinStatement)
    {
      _winStatement = newWinStatement;
    }

    public string GetWinner(string PlayerOne, string PlayerTwo)
    {
      if (PlayerOne == null || PlayerTwo == null)
      {
        Console.WriteLine("Both players must select an option");
        SetWinStatement("Both players must select an option");
        return "Both players must select an option";
      }
      else if (PlayerOne == PlayerTwo)
      {
        Console.WriteLine("It's a tie!");
        SetWinStatement("It's a tie!");
        return "It's a tie!";
      }
      else if (PlayerOne == "rock" && PlayerTwo == "scissors" || PlayerOne == "paper" && PlayerTwo == "rock" || PlayerOne == "scissors" && PlayerTwo == "paper")
      {
        Console.WriteLine("PlayerOne Wins!");
        SetWinStatement("PlayerOne Wins!");
        return "PlayerOne Wins!";
      }
      else
      {
        Console.WriteLine("PlayerTwo Wins!");
        SetWinStatement("PlayerTwo Wins!");
        return "PlayerTwo Wins!";
      }
    }
  }
}
