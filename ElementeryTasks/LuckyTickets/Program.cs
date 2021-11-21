using System;

namespace LuckyTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            InputDataReader inputDataReader = new InputDataReader();
            CountingLuckyTickets countingLuckyTickets = new CountingLuckyTickets(inputDataReader);

            Console.WriteLine(countingLuckyTickets.CreateArrayLuckyNumbers());
        }
    }
}
