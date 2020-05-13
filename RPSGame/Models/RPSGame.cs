using System;
using System.Collections.Generic;

namespace RPSGame.Models
{
  class Game
  {
    int MyNumInput {get; set;}
    public Game (int myNumInput)
    {
      MyNumInput = myNumInput;
    }

    private int MyRandGen()
    {
      Random rand = new Random();
      int  TheNum = rand.Next(1,4);
    }

    public static void GameStart()
      {
        Game backEnd = new Game(MyNumInput);
        Console.WriteLine("Let's play Rock Paper Scissor\n\t) Enter R for Rock\n\t) Enter S for Scissor\n\) Enter P for Paper");
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
        
        FinalFunction();
      }

    public void FinalFunction()
    {
      if (MyNumInput == TheNum)
      {
        Console.WriteLine("It is a draw! would you like to play again?");
        string answer = (Console.ReadLine().ToUpper());
        if (answer == "Y")
        {
          GameStart();
        }
        else
        {
          Console.WriteLine("Thanks for playing!");
          Environment.Exit(0);
        }
      }
      else if (MyNumInput ==1 && TheNum ==2)
      {
        Console.WriteLine("You lost! would you like to play again?");
        string answer = (Console.ReadLine().ToUpper());
        if (answer == "Y")
        {
          GameStart();
        }
      }
      else if (MyNumInput ==1 && TheNum == 3)
      {
        Console.WriteLine("You won! would you like to play again?");
        string answer = (Console.ReadLine().ToUpper());
        if (answer == "Y")
        {
          GameStart();
        }
      }
      else if (MyNumInput ==2 && TheNum ==1)
      {
        Console.WriteLine("You won! would you like to play again?");
        string answer = (Console.ReadLine().ToUpper());
        if (answer == "Y")
        {
          GameStart();
        }
      }
      else if (MyNumInput ==2 && TheNum == 3)
      {
        Console.WriteLine("You lost! would you like to play again?");
        string answer = (Console.ReadLine().ToUpper());
        if (answer == "Y")
        {
          GameStart();
        }
      }
      else if (MyNumInput ==3 && TheNum ==1)
      {
        Console.WriteLine("You lost! would you like to play again?");
        string answer = (Console.ReadLine().ToUpper());
        if (answer == "Y")
        {
          GameStart();
        }
      }
      else if (MyNumInput ==3 && TheNum == 2)
      {
        Console.WriteLine("You won! would you like to play again?");
        string answer = (Console.ReadLine().ToUpper());
        if (answer == "Y")
        {
          GameStart();
        };
      }
    }
  }