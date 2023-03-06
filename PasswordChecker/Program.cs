using System;
using System.Text.RegularExpressions;

namespace PasswordChecker
{
  class Program
  {
    public static void Main(string[] args)
    {

      /*
        Password Standards:
        minLength — a number with the minimum length
        uppercase — a string with all uppercase letters
        lowercase — a string with all lowercase letters
        digits — a string with all 10 digits
        specialChars — a string made of special characters
      */

      int minLength = 8;
      string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
      string lowercase = uppercase.ToLower();
      string digits = "1234567890";
      string specialChars = "#?!";

      Console.WriteLine("Enter your password:");
      string password = Console.ReadLine();

      int score = 0;

      if( password.Length >= minLength ){
        score++;
      }

      if( Tools.Contains(password, uppercase) ){
        score++;
      }

      if( Tools.Contains(password, lowercase) ){
        score++;
      }

      if( Tools.Contains(password, digits) ){
        score++;
      }

      /*
      if( Tools.Contains(password, specialChars) ){
        score++;
      }
      */
      // Extra Challenge: Utilize regular expressions instead of Tools.Contains()
      var regexItem = new Regex("^[a-zA-Z0-9]*$");
      if( !regexItem.IsMatch(password) ){
        score++;
      }
      
      // Extra Challenge: score is 0 if password is "password" or "1234"
      if( password == "password" || password == "1234" ){
        score = 0;
      }

      Console.WriteLine($"Your password Strength Score: {score}");

      switch (score) {
        case 1:
          Console.WriteLine("The password is weak");
          break;
        case 2:
          Console.WriteLine("The password is medium");
          break;
        case 3:
          Console.WriteLine("The password is strong");
          break;
        case 4:
          Console.WriteLine("The password is extremely strong");
          break;
        case 5:
          Console.WriteLine("The password is extremely strong");
          break;
        default:
          Console.WriteLine("The password doesn't meet any of the standards");
          break;
      }

    }
  }
}
