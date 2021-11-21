using System;
using System.Collections.Generic;

namespace NumberInWord
{
    class Program
    {

        static void Main(string[] args)
        {
            string inputWord;
            do
            {
                InputDataRearer inputDataRearer = new InputDataRearer();
                int n = inputDataRearer.ReadData();
                ConvertValue convertValue = new ConvertValue();
                Console.WriteLine(convertValue.GetNumberStringPresentation(n));
                Console.WriteLine("Do you want to continue? :");
                inputWord = Console.ReadLine().Trim();
            }
            while (inputWord == "y" || inputWord == "yes");
        }
    }
}
