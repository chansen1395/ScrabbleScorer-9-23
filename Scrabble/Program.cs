using System;
using System.Collections.Generic;
using RPS.Models;


namespace RPS
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Rock, Paper, Scissors!");
      Console.WriteLine("Play against a computer or two player mode? [computer/2p/] [q to quit]");
      string mode = Console.ReadLine().ToLower();
      string choice1 = "";
      string choice2 = "";
      string[] validPlays = new string[] { "rock", "paper", "scissors" };
      
      if (mode == "q")
      {
        choice1 = "q";
      } else if (mode == "computer")
      {
      Console.WriteLine("Player 1: [rock/paper/scissors] [q to quit]");
      choice1 = Console.ReadLine().ToLower();
      choice2 = Game.CPUPlayer();
      Console.WriteLine("--------");
      Console.WriteLine("The computer has chosen: " + choice2);
      } else if (mode == "2p")
      {
      Console.WriteLine("Player 1: [rock/paper/scissors] [q to quit]");
      choice1 = Console.ReadLine().ToLower();
      Console.WriteLine("Player 2: [rock/paper/scissors] [q to quit]");
      choice2 = Console.ReadLine().ToLower();
      } else
      {
        Console.WriteLine("Please enter computer, 2p or q");
        Main();
      }
      
      
      if (choice1 == "q" || choice2 == "q")
      {
        Console.WriteLine("Goodbye");
      } else if (Array.Exists(validPlays, element => element == choice1) && Array.Exists(validPlays, element => element == choice2))
      {
        string result = Game.CheckWinner(choice1, choice2);
        if (result == "Draw")
        {
          Console.WriteLine("It was a Draw");
          Console.WriteLine("--------");
          Main();
        } else
        {
          Console.WriteLine("The winner is " + result);
          Console.WriteLine("--------");
          Main();
        }
      } else 
      {
        Console.WriteLine("Please enter rock, paper, or scissors");
        Console.WriteLine("--------");
        Main();
      }
    
    }
  }
}