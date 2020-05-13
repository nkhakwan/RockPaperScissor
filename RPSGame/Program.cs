using System;
using System.Collections.Generic;
using RPSGame.Models;

namespace RPSEntry
{
  class Program
  {
    public static void Main()
    {
      GameStart();
    }

    
    public static void GameStart()
    {
      Console.WriteLine("Let's play Rock Paper Scissor\n\t Enter R for Rock\n\t Enter S for Scissor\n\t Enter P for Paper");
      string MyInput = (Console.ReadLine().ToUpper());
      int MyNumInput =0;
      if (MyInput == "R")
      {
        MyNumInput = 1;
      }
      if (MyInput == "P")
      {
        MyNumInput = 2;
      }
      if (MyInput == "S")
      {
        MyNumInput = 3;
      }
      Game backEnd = new Game(MyNumInput);
      backEnd.FinalFunction();
    }
  }
}