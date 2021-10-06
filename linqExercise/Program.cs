using System;
using System.Collections.Generic;
using System.Linq;

namespace linqExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string word = "supercalifragilisticexpialidocious";
            int sCount = word.Count(l => l == 's');
            Console.WriteLine($"The letter s is in {word} {sCount} times.");


            //2
            List<string> names = new List<string>() { "Jillian", "Emma", "Ben", "JellyBean", "Yash" };

            List<string> JNames = names.Where(w => w[0] == 'J').ToList();
            foreach (string w in JNames)
            {
                Console.WriteLine(w);
            }


            //3
            int[] numbers = { 34, 46, 87, 456, 89, 23, 4, 7, 9 };
            //int[] descNumbers = numbers.OrderByDescending(n => n).ToArray();
            int[] descNums = (from n in numbers
                              orderby n descending
                              select n).ToArray();
            foreach (int n in descNums)
            {
                Console.WriteLine(n);
            }

            //int[] oddNums = numbers.Where(num => num % 2 == 1).ToArray();
            //double avg = oddNums.Average();
            //one line avg
            double avg = numbers.Where(num => num % 2 == 1).Average();
            Console.WriteLine($"Average = {avg}");

            int sum = numbers.Where(n => n > 10).Sum();
            Console.WriteLine($"Sum = {sum}");
        }
    }
}
