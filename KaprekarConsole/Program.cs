using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace KaprekarConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get user input and validate
            string? inputAsString = null;
            do
            {
                Console.WriteLine("Welcome to the Kaprekar's Calculator. \n Please enter 4 unique numbers");
                inputAsString = Console.ReadLine();


            } while (!IsValidInput(inputAsString));

            runKoprekarsAlgorithm(inputAsString);




        }
        public static bool IsValidInput(string inputAsString)
        {
            if (inputAsString == null || inputAsString.Length != 4 || !int.TryParse(inputAsString, out _))
            {
                Console.WriteLine("Invalid input. Please enter exactly 4 unique digits.");
                return false;
            }
            else if (inputAsString.Length != inputAsString.Distinct().Count())
            {
                Console.WriteLine("Invalid input. Please enter 4 unique digits.");
                return false;
            }

            foreach (char num in inputAsString)
            {
                if (num == '0')
                {
                    Console.WriteLine("Invalid input. Please enter 4 unique digits without any zeros.");
                    return false;
                }
            }
 
            return true;
        }

        public static void runKoprekarsAlgorithm(string inputAsString)
        {
            int rounds = 0;
            int sortedAscending = int.Parse(new string(inputAsString.OrderBy(c => c).ToArray()));
            int sortedDescending = int.Parse(new string(inputAsString.OrderByDescending(c => c).ToArray()));

            int total = sortedDescending - sortedAscending;
            do
            {
                string strTotal = total.ToString();
                sortedAscending = int.Parse(new string(strTotal.OrderBy(c => c).ToArray()));
                sortedDescending = int.Parse(new string(strTotal.OrderByDescending(c => c).ToArray()));

                total = sortedDescending - sortedAscending;


                rounds++;
                Console.WriteLine($"Round {rounds}: {sortedDescending} - {sortedAscending} = {total}");

            } while (total != 6174);

        }
    }
}
