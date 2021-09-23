using System;
using System.Collections.Generic;

// method that takes in a string
// scoring dictionary {a, 1}, ...
// parse each letter into a list
// for loop
// if list[index] is in the dictionary[index2] --> score += dictionary[index2]
// {"a", "b", "c"} --> 7
// return score
namespace Scorer.Models
{
  public class Game
  {
    public static int ScoreCalc(string word)
    {
      string wordLower = word.ToLower();
      string[] onePoint = {"a", "e", "i", "o", "u", "l", "n", "r", "s", "t"};
      string[] twoPoint = {"d", "g"};
      string[] threePoint = {"b", "c", "m", "p"};
      string[] fourPoint = {"f", "h", "v", "w", "y"};
      string[] fivePoint = {"k"};
      string[] eightPoint = {"j", "x"};
      string[] tenPoint = {"q", "z"};
      int totalScore = 0;

      if (Array.Exists(onePoint, element => element == wordLower))
      {
        totalScore += 1;
      }
      else if (Array.Exists(twoPoint, element => element == wordLower))
      {
        totalScore += 2;
      }
      else if (Array.Exists(threePoint, element => element == wordLower))
      {
        totalScore += 3;
      }
      else if (Array.Exists(fourPoint, element => element == wordLower))
      {
        totalScore += 4;
      }
      else if (Array.Exists(fivePoint, element => element == wordLower))
      {
        totalScore += 5;
      }
      else if (Array.Exists(eightPoint, element => element == wordLower))
      {
        totalScore += 8;
      }
      else if (Array.Exists(tenPoint, element => element == wordLower))
      {
        totalScore += 10;
      }
      else 
      {
        totalScore += 0;
      }
    return totalScore;
    }
  }
}