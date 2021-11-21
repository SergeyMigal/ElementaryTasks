using System;

namespace ChessBoard
{
    class InputDataReader
    {
        public BoardSize ReadData()
        {
            int boardHeight;
            int boardWidth;
            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight;
            while (true)
            {
                Console.WriteLine("Enter board height:");
                var inputHeight = Console.ReadLine().Trim();
                Console.WriteLine("Enter board width:");
                var inputWidth = Console.ReadLine().Trim();
                if (!int.TryParse(inputHeight, out boardHeight) || !int.TryParse(inputWidth, out boardWidth))
                {
                    Console.WriteLine("Error: only intereger numbers allowed");
                    continue;
                }
                else if (boardHeight <= 0 || boardWidth <= 0)
                {
                    Console.WriteLine("Error: only positive numbers allowed");
                    continue;
                }
                else if (consoleHeight < boardHeight || consoleWidth < boardWidth)
                {
                    Console.WriteLine("Error: The size of the Chessboard is larger than the screen");
                }
                else
                {
                    break;
                }
            }
            return new BoardSize { Height = boardHeight, Width = boardWidth };
        }
    }
}
