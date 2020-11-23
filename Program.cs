using System;
using System.Collections;

namespace RomanNumeralConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] symbols = { "I", "V", "X", "L", "C", "D", "M"};
            int[] values = { 1, 5, 10, 50, 100, 500, 1000};
            int numeqivalent = 1;
            try
            {
            Console.Write("Please enter a roman numeral: ");
            string input = Console.ReadLine().ToUpper();

            if(input == "IV")
            {
                numeqivalent = 4;
            }
            else if (input == "IX")
            {
                numeqivalent = 9;
            }
            else if (input == "XL")
            {
                numeqivalent = 40;
            }
            else if (input == "XC")
            {
                numeqivalent = 90;
            }
            else if (input == "CO")
            {
                numeqivalent = 400;
            }
            else if (input == "CM")
            {
                numeqivalent = 900;
            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    string currentletter = input.Substring(i, 1);
                    int position = Array.IndexOf(symbols, currentletter);
                    numeqivalent += values[position];
                }
            }
            Console.WriteLine(numeqivalent);
            Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Make sure the numerials you enetered for all letters!");
                Console.WriteLine("Error" + e);
            }
        }
    }
}
