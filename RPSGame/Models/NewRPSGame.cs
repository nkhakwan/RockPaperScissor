public static void Main()
{
Console.WriteLine("Please enter R for rock, S for Scissor and P for paper");
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

Game frontEnd = new Game(MyNumInput);
FinalFunction();


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

  public void FinalFunction()
  {
    if (MyNumInput == TheNum)
    {
      Console.WriteLine("It is a draw");
    }
    else if (MyNumInput ==1 && TheNum ==2)
    {
      Console.WriteLine("You lost");
    }
    else if (MyNumInput ==1 && TheNum == 3)
    {
      Console.WriteLine("YOu won");
    }
    else if (MyNumInput ==2 && TheNum ==1)
    {
      Console.WriteLine("You won");
    }
    else if (MyNumInput ==2 && TheNum == 3)
    {
      Console.WriteLine("YOu lost");
    }
    else if (MyNumInput ==3 && TheNum ==1)
    {
      Console.WriteLine("You lost");
    }
    else if (MyNumInput ==3 && TheNum == 2)
    {
      Console.WriteLine("YOu won");
    }








  }





  }}