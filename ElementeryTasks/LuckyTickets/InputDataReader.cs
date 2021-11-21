using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuckyTickets
{
    public class InputDataReader
    {
        int minNumber;
        int maxNumber;
 
        public List<int> MinMaxValue = new List<int>();
        public List <int> ReadData()
        {
            while (true)
            {
                Console.WriteLine("Enter min number ticket: ");
                var inputMinNumber = Console.ReadLine().Trim();

                Console.WriteLine("Enter max number ticket: ");
                var inputMaxNumber = Console.ReadLine().Trim();

                if (!int.TryParse(inputMinNumber, out minNumber) || !int.TryParse(inputMaxNumber, out maxNumber))
                {
                    Console.WriteLine("Error: only intereger numbers allowed");
                    continue;
                }
                else if (minNumber < 0 || maxNumber < 0)
                {

                    Console.WriteLine("Error: only positive numbers allowed");
                    continue;
                }
                else
                {
                    MinMaxValue.Add(minNumber);
                    MinMaxValue.Add(maxNumber);
                    break;
                }
            }
            return MinMaxValue;
        }
    }
}
