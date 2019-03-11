using System;

namespace less_or_more
{
  public class Game
  {
    private readonly int _max;
    private readonly int _secretInt;

    ///<summary>
    /// Create a new instance of the Less and More Game
    ///<param name="max">Maximum value to be guessed by the user</param>
    ///</summary>
    public Game(int maxNumber = 30)
    {
      _max = maxNumber;
      var rnd = new Random();
      _secretInt = rnd.Next(_max);
    }

    ///<summary>
    /// Start the game #CaptainObvious
    ///</summary>
    public void StartGame()
    {
      WriteInit();
      DoGame();
    }

    private void WriteInit()
    {
      Console.WriteLine("\nWelcome in my game:");
      Console.WriteLine($"FindMyNumb between 0 and {_max} !!");
      Console.WriteLine("----------------------");
      Console.WriteLine("Wich number is the secret number? :)");
    }

    private void DoGame()
    {
      string answer = "";
      int number;

      do
      {
        answer = Console.ReadLine();

        if (!Int32.TryParse(answer, out number))
          Console.WriteLine("\nPlease, write a valid number");
        else if (_secretInt > number)
          Console.WriteLine("\nMore");
        else
          Console.WriteLine("\nLess");
      } while (number != _secretInt);
      EndGame();
    }

    private void EndGame()
    {
      Console.WriteLine($"Congratulation! {_secretInt} was good answer!");
    }
  }
}