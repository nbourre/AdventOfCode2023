// Open file input.txt
// sum = 0
// For each line in the file
//   Extract and concatenate all the digits
//   Take the first and last digit to create a number
//   sum += number
// Print sum

using System;

namespace Day01
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = System.IO.File.ReadAllLines("input.txt");
            int sum = 0;
            foreach (string line in lines)
            {
                string digits = "";
                foreach (char c in line)
                {
                    if (char.IsDigit(c))
                    {
                        digits += c;
                    }
                }
                int number = int.Parse(digits[0] + "" + digits[digits.Length - 1]);
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }
}
