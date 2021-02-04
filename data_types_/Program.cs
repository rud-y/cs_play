using System.Collections;
using System;
using System.Collections.Generic;
namespace data_types_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> aList = new List<string>();
            aList.Add("Mark");
            aList.Add("Danielle");
            aList.Add("Welcome !");


            foreach (var str in aList)
            {
                Console.Write($"{str} ");
            }

            string greeting = "      Hello World!       ";
            Console.WriteLine($"{greeting}");

            string trimmedGreeting = $"{greeting.TrimEnd()}///";
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"{trimmedGreeting} --> greeting has {trimmedGreeting.Length} characters!");
            // Replace()
            string car = "Honda Civic";
            string car2 = car.Replace("Civic", "Jazz");
            Console.WriteLine($"Previously {car} is now {car2}");

            //Contains(), StartWith(), EndsWith()
            string berlin = "berlin";
            string output = ($"The capital of Germany is {berlin}.");

            Console.WriteLine(output.ToUpper());
            Console.WriteLine($"String >>{output}<< contains {berlin}? ... {output.Contains($"{berlin}")}");


            Console.WriteLine($"{output.StartsWith("The")}");



        }
    }
}
