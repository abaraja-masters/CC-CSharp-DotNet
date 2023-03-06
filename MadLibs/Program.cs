using System;

namespace MadLibs
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
      This program is a fill-in the blanks story game.
      Author: Anthony Baraja
      */


      // Let the user know that the program is starting:
      Console.WriteLine("MadLibs program running ...");


      // Give the Mad Lib a title:
      string title = "Normnal Day";

      Console.WriteLine(title);
      // Define user input and variables:
      Console.WriteLine("Enter a name: ");
      string name = Console.ReadLine();

      Console.WriteLine("Enter an adjective: ");
      string adjective1 = Console.ReadLine();
      Console.WriteLine("Enter another adjective: ");
      string adjective2 = Console.ReadLine();
      Console.WriteLine("Enter another adjective: ");
      string adjective3 = Console.ReadLine();

      Console.WriteLine("Enter a verb: ");
      string verb = Console.ReadLine();

      Console.WriteLine("Enter a noun: ");
      string noun1 = Console.ReadLine();
      Console.WriteLine("Enter another noun: ");
      string noun2 = Console.ReadLine();

      Console.WriteLine("Enter an animal: ");
      string animal = Console.ReadLine();
      Console.WriteLine("Enter a food: ");
      string food = Console.ReadLine();
      Console.WriteLine("Enter a fruit: ");
      string fruit = Console.ReadLine();
      Console.WriteLine("Enter a superhero: ");
      string superhero = Console.ReadLine();
      Console.WriteLine("Enter a country: ");
      string country = Console.ReadLine();
      Console.WriteLine("Enter a dessert: ");
      string dessert = Console.ReadLine();
      Console.WriteLine("Enter a year: ");
      string year = Console.ReadLine();


      // The template for the story:

      string story = $"This morning {name} woke up feeling {adjective1}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adjective3}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";


      // Print the story:
      Console.WriteLine(story);

    }
  }
}
