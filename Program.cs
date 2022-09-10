using System;

namespace PlayingWithVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Coco";
            int dogAge = 6;
            bool loveDog = true;
            var chars = "c";
            decimal dogAgeNew = 6.5m;
            double dogAgeOld = 6.55;

            Console.WriteLine($"My dog's name is {dogName}, her name starts with a {chars}.");
            Console.WriteLine($"Currently she is about {dogAge}.");
            Console.WriteLine($"To be precise, she is around {dogAgeNew}.");
            Console.WriteLine($"In a month she will be {dogAgeOld} years old.");
            Console.WriteLine($"I love her. {loveDog}");
            Console.ReadLine();
            }
    }
}
