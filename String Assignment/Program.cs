using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, What is your name ?");
            string name = Console.ReadLine().ToUpper();

            Console.WriteLine($"Hello, {name}");

            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Where are you from ?");
            string place = Console.ReadLine();

            Console.WriteLine($"You are {name}, you are from {place}, and your favorite number is: {favNum}");

            // Creating a StringBuilder to build a paragraph of text
            StringBuilder paragraphBuilder = new StringBuilder();

            // Building the paragraph one sentence at a time
            paragraphBuilder.Append("Once upon a time, ");
            paragraphBuilder.Append("there was a programmer named ");
            paragraphBuilder.Append(name);
            paragraphBuilder.Append(" who hailed from ");
            paragraphBuilder.Append(place);
            paragraphBuilder.Append(". ");

            // Appending more sentences to the paragraph
            paragraphBuilder.AppendLine("He enjoyed coding and solving problems.");
            paragraphBuilder.AppendLine("His favorite number was ");
            paragraphBuilder.Append(favNum);
            paragraphBuilder.Append(". ");

            // Displaying the built paragraph
            Console.WriteLine("\nHere is the paragraph:");
            Console.WriteLine(paragraphBuilder.ToString());
            Console.ReadLine();
        }
    }
}
