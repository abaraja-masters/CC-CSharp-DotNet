using System;

namespace MoneyMaker
{
  class MainClass
  {
    public static void Main(string[] args)
    {
      Console.WriteLine("Welcome to Money Maker!");

      Console.WriteLine("Enter the value amount: ");
      string valueStr = Console.ReadLine();

      double value = Convert.ToDouble(valueStr);

      Console.WriteLine($"{value} cents is equal to...");

      // Conversion Time!
      int goldCoins = 10;
      int silverCoins = 5;

      double valueGold = Math.Floor(value / goldCoins);
      double remainder = value % goldCoins;

      double valueSilver = Math.Floor(remainder / silverCoins);
      remainder = remainder % silverCoins;

      Console.WriteLine($"Gold coins: {valueGold}");
      Console.WriteLine($"Silver coins: {valueSilver}");
      Console.WriteLine($"Bronze coins: {remainder}");

      // Extra Challenges:
      /*
      The program doesn’t work if the user enters a decimal, like 16.2 cents. 
      Using type conversion or a Math method, round down their input to the nearest whole cent.
      */
      /*
      Use another currency that has different coin amounts. 
      For example, the US uses 1, 5, 10, and 25 cent coins called pennies, nickels, dimes, and quarters, respectively.
      */
      
    }
  }
}
