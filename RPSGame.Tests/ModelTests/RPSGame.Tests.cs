using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Game.TestTools
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      
    }
  [TestMethod]
  public void UserInput_UserInputsAString_True()
  {
    // Arrange
    Game testOne = new Game("R");

    // Act
    string userInput = testOne.GameStart
  }
  }
}