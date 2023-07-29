// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.ReadKey(true);

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TuringConsole
{
    //    Workout Progress

    // A workout plan has a schedule to burn calories everyday
    // Given an array cals, a person burns cals[k] calories on the k-th day of a workout plan Given the number of days 
    // d, for every consecutive sequence of d days (cals[k], cals[k]. cals[kid-1] for all ok <- n-d)

    // We look at the total calorie burned during that sequence of d days

    // (cals[k] cals[k+1] + +cals[kid-1])

    // If total min, they are not burning enough calories, so one point gets deducted from their score If total max,
    //  they are doing good and burning a good amount of calories, so one point is added to their score Otherwise, 
    //  they are just doing fine, and their score is kept the same with no point changes Calculate and return 
    //  the total score the person has after working out for cals.length days


    // Example:

    // Input: cals = [1,2,3,4,5], d 1, min = 3, max - 3

    // Output: 0

    // Explanation: Since d 1, we consider each element of the array separately and compare it to min

    // and max.

    // cals[0] and cals[1] are less than min so 2 points are lost.
    // cals[3] and cals[4] are greater than max so 2 points are gained.

    // Constraints:

    // 1-dc- calories.length <- 105
    // public class TheSolution
    // {
    //     public int Solution(int[] cals, int d, int min, int max)
    //     {
    //         var score = 0;
    //         for (var i = 0; i < cals.Length; i++)
    //         {
    //             var total = 0;
    //             for (var j = i; j < i + d; j++)
    //             {
    //                 if (j >= cals.Length)
    //                 {
    //                     break;
    //                 }
    //                 total += cals[j];
    //             }
    //             if (total < min)
    //             {
    //                 score -= 1;
    //             }
    //             else if (total > max)
    //             {
    //                 score += 1;
    //             }
    //         }
    //         return -1;
    //     }
    // }
    // public class TheProblem    
    // {

    //     static void Main(string[] args)
    //     {
    //         var solution = new TheSolution();
    //         var space = new char[] { };
    //         var input = Console.ReadLine().Split(space);
    //         var k = input.ToList().Select(int.Parse).ToArray();
    //         var n = Console.ReadLine();
    //         var b = Console.ReadLine();
    //         var d = Console.ReadLine();
    //         var output = solution.Solution(k, int.Parse(n), int.Parse(b), int.Parse(d));
    //         Console.WriteLine(output);
    //     }
    // }

    // Popular Animal
    // You will be given a list of forbidden animals and a string animals that contains a set of animal names 
    // (all are case insensitive), find the popular animal in animals
    // A popular animal is the one that exists the most in animals, and it shouldn't be forbidden
    // At least one non-forbidden animal exists in animals, and the input will have a definite answer Make sure 
    // you return the popular animal in lower-case

    // Example:

    // Input: animals = "Dog horse donkey CAT donkey cat bird donkey.", f = ["donkey"]

    // Output: "cat"

    // Constraints:

    // 1 < animals.length <- 1000

    // ⚫ statement consists of letters, space, or one of the symbols: "?",;."

    // e-f.length <- 108

    // 1-f[i].length <= 10

    // f[i] consists of only lowercase English letters

    public class TheSolution
    {
        public string Solution(string animals, string[] f)
        {
            var animalList = animals.Split(' ');
            var animalCount = new Dictionary<string, int>();
            foreach (var animal in animalList)
            {
                var lowerCaseAnimal = animal.ToLower();
                if (f.Contains(lowerCaseAnimal))
                {
                    continue;
                }
                if (animalCount.ContainsKey(lowerCaseAnimal))
                {
                    animalCount[lowerCaseAnimal] += 1;
                }
                else
                {
                    animalCount[lowerCaseAnimal] = 1;
                }
            }
            var max = 0;
            var maxAnimal = "";
            foreach (var animal in animalCount)
            {
                if (animal.Value > max)
                {
                    max = animal.Value;
                    maxAnimal = animal.Key;
                }
            }
            return maxAnimal;
        }
    }
    public class TheProblem
    {        
        static void Main(string[] args)
        {
            var solution = new TheSolution();

            char[] space = new char[] { ' ' };

            var s = Console.ReadLine();

            var input = Console.ReadLine().Split(space); 
            string output = solution.Solution(s, input); 
            Console.WriteLine(output);
        }
    }
}
