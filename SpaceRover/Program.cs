using System;
using System.Collections.Generic;

namespace SpaceRover
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Space Rover Project");

      //Creating a list of all planets. Starting with an unordered list of planets. 
      var planetList = new List<string>() { "Mercury", "Mars" };
      planetList.Add("Jupiter");
      planetList.Add("Saturn");

      //Creating a separate list of the last planets in our solar system.
      var lastPlanetList = new List<string>() { "Uranus", "Neptune" };

      //Appending the list above to the end of our solar system list
      planetList.AddRange(lastPlanetList);

      // Adding the missing planets in the correct order by index, our solar system is now in order
      planetList.Insert(1, "Venus");
      planetList.Insert(2, "Earth");
      planetList.Add("Pluto");

      // Now looping through that list to display them in order.
      Console.WriteLine("The planets in our Solar System:");
      foreach (var planet in planetList)
      {
        Console.WriteLine($"\t {planet}");
      }

      //Creating a new list of the terrestrial planets, taking the first planets.
      var rockyPlanets = planetList.GetRange(0, 4);
      Console.WriteLine("These are the Terrestrial Planets in our Solar System:");
      //Loop through and display each rocky planet.
      foreach (var terrestrial in rockyPlanets)
      {
        Console.WriteLine($"\t {terrestrial}");
      }

      //Creating a Dictionary collection to assign a list of missions to each planet that has been probed. 
      //First value is string name of the Planet, and the second value is a list of missions
      var spaceMissions = new Dictionary<string, List<string>>();
      spaceMissions.Add("Mercury", new List<string> { "Mariner", "Messenger" });
      spaceMissions.Add("Venus", new List<string> { "Mariner", "Pioneer","Galileo", "Magellan", "Messenger" });
      spaceMissions.Add("Mars", new List<string> { "Mariner", "Viking", "Pathfinder", "Sojourner", "Odyssey", "Curiosity" });
      spaceMissions.Add("Jupiter", new List<string> { "Pioner", "Voyager", "Galileo" });
      spaceMissions.Add("Saturn", new List<string> { "Pioner", "Voyager" });
      spaceMissions.Add("Uranus", new List<string> { "Voyager" });
      spaceMissions.Add("Neptune", new List<string> { "Voyager" });

      Console.WriteLine("The following list of planets have been explored by these probes:");

      //Destructuring the key:value pair in the dictionary to iterate. 
      //Planet is a string, rover is a list, the .Join iterates over the list and appends each mission as a comma separated value to the string. 
      foreach (var (planet, rover) in spaceMissions)
      {
        Console.WriteLine($"\t {planet}: {String.Join(", ", rover)}");
      }

    }
  }
}
