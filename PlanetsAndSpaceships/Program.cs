using System;
using System.Collections.Generic;

namespace PlanetsAndSpaceships
{
    class Program
    {
        private static object dictionary;

        static void Main(string[] args)
        {
            List<string> planetList = new List<string>() { "Mercury", "Mars" };

            // 1. `Add()` Jupiter and Saturn at the end of the list. //
            planetList.Add("Jupiter");
            planetList.Add("Saturn");
            Console.WriteLine($"Planet List: { String.Join(',', planetList)}");
            // END //

            // 2. Create another List that contains that last two planets of our solar system. //
            List<string> lastTwoPlanets = new List<string>() { "Uranus", "Neptune"};
            Console.WriteLine($"Solar System List: { String.Join(',', lastTwoPlanets)}");
            // END //

            // 3. Combine the two lists by using AddRange(). //
            planetList.AddRange(lastTwoPlanets);
            Console.WriteLine($"Planet List: { String.Join(',', planetList)}");

            // END //

            // 4. Use Insert() to add Earth, and Venus in the correct order. //
            planetList.Insert(1, "Earth");
            planetList.Insert(1, "Venus");
            Console.WriteLine($"Planet List: { String.Join(',', planetList)}");
            // END //

            // 5. Use Add() again to add Pluto to the end of the list. //
            planetList.Add("Pluto");
            var withPluto = String.Join(',', planetList);
            Console.WriteLine($"Full Planet List: { String.Join(',', withPluto)}");
            // END //

            // 6. Now that all the planets are in the list, slice the list using GetRange() in order to extract the rocky planets into a new list called rockyPlanets. //
            var rockyPlanets = planetList.GetRange(0,4);
            Console.WriteLine($"Rocky Planets: { String.Join(',', rockyPlanets)}");
            // END //

            // 7. Being good amateur astronomers, we know that Pluto is now a dwarf planet, so use the Remove() method to eliminate it from the end of planetList. //
            planetList.Remove("Pluto");
            Console.WriteLine($"Without Pluto: { String.Join(',', planetList)}");
            // END // 


            // Iterating over planets // 

            // 1. Create a dictionary that will hold the name of a spacecraft that we have launched, and a list of names of the planets that it has visisted // 

            var spaceDictionary = new Dictionary<string, List<string>>();

            spaceDictionary.Add("Tyazhely Sputnik", new List<string> { "Venus" });
            var sputnikDefinition = spaceDictionary["Tyazhely Sputnik"];
            sputnikDefinition.Add("Planets this probe has visited");

            spaceDictionary.Add("Sputnik 19", new List<string> { "Venus" });
            var sputnik2Definition = spaceDictionary["Sputnik 19"];
            sputnik2Definition.Add("Planets this probe has visited");

            spaceDictionary.Add("Viking 2 Lander", new List<string> { "Mars" });
            var vikingDefinition = spaceDictionary["Viking 2 Lander"];
            vikingDefinition.Add("Planets this probe has visited");

            spaceDictionary.Add("Phoenix", new List<string> { "Mars" });
            var phoenixDefinition = spaceDictionary["Phoenix"];
            phoenixDefinition.Add("Planets this probe has visited");

            foreach (var item in dictionary)
            {

            }

        }
    }
}
