using System;

namespace IterationExerciseBonus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Iteration Exercise Bonus!");
            Console.WriteLine("");
            Console.WriteLine("Here, we will create a list that contains values. From that list, we will assign variables that will perform based upon different behaviors.");
            var numberspectrum = new System.Collections.Generic.List<int>();
            var uno = 0;
            Console.WriteLine("");
            Console.WriteLine($"Our assigned variable, uno, will start off as {uno}.");
            do
            {
                uno++;
                numberspectrum.Add(uno);
            } while (uno < 40);
            Console.WriteLine("");
            foreach (var unoprint in numberspectrum)
            {
                Console.WriteLine($"{unoprint}");
            }
            Console.WriteLine("");
            Console.WriteLine($"Now, our assigned variable, uno, has become a value of {uno}.");
            Console.WriteLine("");
            Console.WriteLine("Weirdly enough, uno needed a little help in spreading the word of its numerical journey, by having another semi-predefined variable announce what was happening to uno, at every loop being performed until the condition of the script for which uno was placed in, was met.");
            Console.WriteLine("");
            Console.WriteLine("Let's have uno go through another transformation.");
            do
            {
                uno--;
                numberspectrum.Add(uno);
            } while (uno > 18);
            Console.WriteLine("");
            foreach (var unoprint in numberspectrum)
            {
                Console.WriteLine($"{unoprint}");
            }
            Console.WriteLine("");
            Console.WriteLine($"Uno degraded down to a value of {uno}.");
            Console.WriteLine("");
        }
    }
}
