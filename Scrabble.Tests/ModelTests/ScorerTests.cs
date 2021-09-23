using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using RPS.Models;
using System;

namespace RPS.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void CheckWinner_CheckDraw_Draw()
    {
      Assert.AreEqual("Draw", Game.CheckWinner("rock", "rock"));
    }
    
    [TestMethod]
    public void CheckWinner_Choice1BeatsChoice2_Player1()
    {
      Assert.AreEqual("Player 1", Game.CheckWinner("rock", "scissors"));
      Assert.AreEqual("Player 1", Game.CheckWinner("scissors", "paper"));
      Assert.AreEqual("Player 1", Game.CheckWinner("paper", "rock"));
    }
    [TestMethod]
    public void CheckWinner_Choice2BeatsChoice1_Player2()
    {
      Assert.AreEqual("Player 2", Game.CheckWinner("paper", "scissors"));
      Assert.AreEqual("Player 2", Game.CheckWinner("scissors", "rock"));
      Assert.AreEqual("Player 2", Game.CheckWinner("rock", "paper"));
    }
    
    [TestMethod]
    public void CPUPlayer_ReturnsNumber_String()
    {
      Assert.IsTrue(Game.CPUPlayer() == "rock" || Game.CPUPlayer() == "scissors" || Game.CPUPlayer() == "paper");
    }
  }
}
