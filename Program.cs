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
            string title = "Hamza's Mad Libs", username, adjectiveOne, adjectiveTwo, verb, noun, animal;

            Console.WriteLine($"Welcome to {title}, program starting. . .");

            // Define user input and variables:
            Console.Write("Enter your name: ");
            username = Console.ReadLine();

            Console.Write("Enter an adjective: ");
            adjectiveOne = Console.ReadLine();
            Console.Write("Enter an adjective: ");
            adjectiveTwo = Console.ReadLine();
            Console.Write("Enter a verb: ");
            verb = Console.ReadLine();
            Console.Write("Enter a noun: ");
            noun = Console.ReadLine();
            Console.Write("Enter an animal: ");
            animal = Console.ReadLine();

            string story = $"This story opens with {username} making his way through the {adjectiveOne} forest.\n He encounters a {adjectiveTwo} {animal} and reaches for his belt to unshealth a {noun} and {verb} the {animal} with it.";


            // Print the story:
            Console.WriteLine(story);
        }
    }
}
