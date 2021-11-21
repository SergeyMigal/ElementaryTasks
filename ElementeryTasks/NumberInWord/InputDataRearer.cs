using System;
using System.Collections.Generic;
using System.Text;

namespace NumberInWord
{
    class InputDataRearer
    {
        int inputValue;
        public int ReadData()
        {
            while (true)
            {
                Console.WriteLine("Input value: ");
                var value = Console.ReadLine().Trim();
                if (!int.TryParse(value, out inputValue))
                {
                    Console.WriteLine("Error: only intereger numbers allowed");
                    continue;
                }
                else if (inputValue <= 0 || inputValue >999999999)
                {
                    Console.WriteLine("Error: only positive numbers allowed");
                    continue;
                }
                else
                {
                    return inputValue;
                }
            }
        }
    }
}
