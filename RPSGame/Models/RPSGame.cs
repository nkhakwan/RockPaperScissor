using System;
using System.Collections.Generic;
using RPSEntry;

namespace RPSGame.Models
{
  class Game
  {
    public int MyNumInput {get; set;}
    public Game (int myNumInput)
    {
      MyNumInput = myNumInput;
    }

    // public void MyRandGen()
    // {
    //   Random rand = new Random();
    //   TheNum = rand.Next(1,4);
    // }

    

    public void FinalFunction()
    {
      Random rand = new Random();
      int TheNum = rand.Next(1,4);
      
      if (MyNumInput == TheNum)
      {
        Console.WriteLine("It is a draw! would you like to play again?");
        string answer = (Console.ReadLine().ToUpper());
        if (answer == "Y")
        {
          Program.GameStart();
        }
        else
        {
        Console.WriteLine("Thanks for playing!");
        Environment.Exit(0);
        }
      }
      else if (MyNumInput ==1 && TheNum ==2)
      {
        Console.WriteLine("You lost! Would you like to play again\n\t[Y/N]?");
        string answer = (Console.ReadLine().ToUpper());
        if (answer == "Y")
        {
          Program.GameStart();
        }
        else
        {
          Console.WriteLine("Thanks for playing!");
          Environment.Exit(0);
        }
      }
      else if (MyNumInput ==1 && TheNum == 3)
      {
        Console.WriteLine("You won! Would you like to play again\n\t[Y/N]?");
        string answer = (Console.ReadLine().ToUpper());
        if (answer == "Y")
        {
          Program.GameStart();
        }
        else
        {
          Console.WriteLine("Thanks for playing!");
          Environment.Exit(0);
        }
      }
      else if (MyNumInput ==2 && TheNum ==1)
      {
        Console.WriteLine("You won! Would you like to play again\n\t[Y/N]?");
        string answer = (Console.ReadLine().ToUpper());
        if (answer == "Y")
        {
          Program.GameStart();
        }
        else
        {
          Console.WriteLine("Thanks for playing!");
          Environment.Exit(0);
        }
      }
      else if (MyNumInput ==2 && TheNum == 3)
      {
        Console.WriteLine("You lost! Would you like to play again\n\t[Y/N]?");
        string answer = (Console.ReadLine().ToUpper());
        if (answer == "Y")
        {
          Program.GameStart();
        }
        else
        {
          Console.WriteLine("Thanks for playing!");
          Environment.Exit(0);
        }
      }
      else if (MyNumInput ==3 && TheNum ==1)
      {
        Console.WriteLine("You lost! Would you like to play again\n\t[Y/N]?");
        string answer = (Console.ReadLine().ToUpper());
        if (answer == "Y")
        {
          Program.GameStart();
        }
        else
        {
          Console.WriteLine("Thanks for playing!");
          Environment.Exit(0);
        }
      }
      else if (MyNumInput ==3 && TheNum == 2)
      {
        Console.WriteLine("You won! Would you like to play again\n\t[Y/N]?");
        string answer = (Console.ReadLine().ToUpper());
        if (answer == "Y")
        {
          Program.GameStart();
        }
        else
        {
          Console.WriteLine("Thanks for playing!");
          Environment.Exit(0);
        }
      }
    }
  }
}