using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program is intended to render a Mad-Lib story utilizing input provided by the user through the Console.
            Author: Hamza Foy
            */
            string title = "Hamza's Mad Libs";

            Console.WriteLine($"Welcome to {title}, program starting. . .");
            // Define user input and variables:
            Console.Write("Enter a name: ");
            string username = Console.ReadLine();
            Console.Write("Enter an adjective: ");
            string adjectiveOne = Console.ReadLine();
            Console.Write("Enter an adjective: ");
            string adjectiveTwo = Console.ReadLine();
            Console.Write("Enter an adjective: ");
            string adjectiveThree = Console.ReadLine();
            Console.Write("Enter a verb: ");
            string verb = Console.ReadLine();
            Console.Write("Enter a noun: ");
            string nounOne = Console.ReadLine();
            Console.Write("Enter a noun: ");
            string nounTwo = Console.ReadLine();
            Console.Write("Enter an animal: ");
            string animal = Console.ReadLine();
            Console.Write("Enter a type of food: ");
            string food = Console.ReadLine();
            Console.Write("Enter a type of fruit: ");
            string fruit = Console.ReadLine();
            Console.Write("Enter a superhero's name: ");
            string hero = Console.ReadLine();
            Console.Write("Enter a country's name: ");
            string country = Console.ReadLine();
            Console.Write("Enter a type of dessert: ");
            string dessert = Console.ReadLine();
            Console.Write("Enter a random year: ");
            string year = Console.ReadLine();
            // The template for the story:

            string story = $"This morning {username} woke up feeling {adjectiveOne}. 'It is going to be a {adjectiveTwo} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {nounOne}, which made all the {fruit}s very {adjectiveThree}. Concerned, {username} texted {hero}, who flew {username} to {country} and dropped {username} in a puddle of frozen {dessert}. {username} woke up in the year {year}, in a world where {nounTwo}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);
        }
    }
}
