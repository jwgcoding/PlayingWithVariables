using System;

namespace PlayingWithVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dogName = "Coco";
            int dogAge = 6;
            bool isAlive = true;
            var chars = "c";
            decimal dogAgeNew = 6.5m;
            double dogAgeOld = 6.55;
         
            Console.WriteLine($"My dog's name is {dogName}, her name starts with a {chars}." + 
                " " + $"Currently she is about {dogAge}, " +
                $"but if I would guess she is around {dogAgeNew} " +
                $"and in a month she will be {dogAgeOld} years old." + " " + 
                $"Do I love her?,{isAlive}");



        }
    }
}
