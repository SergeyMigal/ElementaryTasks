using ChessBoard;
using System;

namespace ElementeryTasks
{
    class Program 
    {
        static void Main(string[] args)
        {
            string inputWord;
            do
            {
                InputDataReader reader = new InputDataReader();
                BoardSize size = reader.ReadData();
                BoardModel boardModel = new BoardModel(size);
                Console.WriteLine(boardModel.GetBoard());
                Console.WriteLine("Do you want to continue? :");
                inputWord = Console.ReadLine().Trim();
            }
            while (inputWord == "y" || inputWord == "yes");
        }
    }
}
