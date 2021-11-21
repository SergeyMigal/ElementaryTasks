using System;

namespace Envelopes
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord;
            do
            {
                InputDataReader reader = new InputDataReader();
                EnvelopeModel envelope1 = reader.ReadData();
                EnvelopeModel envelope2 = reader.ReadData();
                EnvelopeCompatibility envelopeCompatibility = new EnvelopeCompatibility();

                Console.WriteLine(envelopeCompatibility.Compatibility(envelope1, envelope2));
                Console.WriteLine("Do you want to continue? :");
                inputWord = Console.ReadLine().Trim();
            }
            while (inputWord == "y" || inputWord == "yes");
        }
    }
}
