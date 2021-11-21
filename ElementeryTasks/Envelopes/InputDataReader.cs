using System;
using System.Collections.Generic;
using System.Text;

namespace Envelopes
{
    class InputDataReader
    {
        public EnvelopeModel ReadData()
        {
            double sideA;
            double sideB;

            while (true)
            {
                Console.WriteLine("Enter side A:");
                var inputA = Console.ReadLine().Trim();
                double.TryParse(inputA, out sideA);

                Console.WriteLine("Enter side B:");
                var inputB = Console.ReadLine().Trim();
                double.TryParse(inputB, out sideB);

                if (sideA <= 0 || sideB <= 0)
                {
                    Console.WriteLine("Error: only positive numbers allowed");
                }
                else
                {
                    break;
                }
            }
            return new EnvelopeModel { Height = sideA, Widht = sideB };
        }
    }
}
