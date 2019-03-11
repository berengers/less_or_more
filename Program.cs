using System;

namespace less_or_more
{
  class Program
  {
    static void Main(string[] args)
    {
      var game = new Game(maxNumber:50);
      game.StartGame();
    }
  }
}
