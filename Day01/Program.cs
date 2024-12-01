// Open file input.txt

using System;

namespace Day01
{
    class Program
    {
        // sum = 0
        // For each line in the file
        //   Extract and concatenate all the digits
        //   Take the first and last digit to create a number
        //   sum += number
        // Print sum
        static int day01a(){
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
            return sum;
        }

        // Same as day01a but It looks like some of the digits are actually
        // spelled out with letters: one, two, three, four, five, six, seven, eight, and nine also count as valid "digits".

        static int day01b() {
            string[] lines = System.IO.File.ReadAllLines("input.txt");
            string[] spelledDigits = {"one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            List<string> convertedLines = new List<string>();

            int sum = 0;
            foreach (string line in lines)
            {
                string digits = "";
                string convertedLine = line;
                foreach (var spelledDigit in spelledDigits)
                {
                    if (convertedLine.Contains(spelledDigit))
                    {
                        convertedLine = convertedLine.Replace(spelledDigit, (spelledDigits.ToList().IndexOf(spelledDigit) + 1).ToString());
                    }
                }

                convertedLines.Add(convertedLine);

                foreach (char c in convertedLine)
                {
                    if (char.IsDigit(c))
                    {
                        digits += c;
                    }
                }
                int number = int.Parse(digits[0] + "" + digits[digits.Length - 1]);
                sum += number;                
            }

            // Save the converted lines to inputConverted.txt
            System.IO.File.WriteAllLines("inputConverted.txt", convertedLines);

            return sum;

        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Day 01a : {day01a()}");
            Console.WriteLine($"Day 01b : {day01b()}");
        }
    }
}
