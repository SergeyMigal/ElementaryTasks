using System;
using System.Collections.Generic;
using System.Text;

namespace ChessBoard
{
    public class BoardModel
    {
        private BoardSize boardSize;
        public BoardModel(BoardSize boardSize)
        {
            this.boardSize = boardSize;
        }
        public StringBuilder GetBoard()
        {
            StringBuilder boardOutput = new StringBuilder();

            for (var h = 1; h <= boardSize.Height; h++)
            {
                if (h % 2 == 0)  //row is odd
                {
                    boardOutput.Append(" ");
                }
                for (var w = 1; w <= boardSize.Width; w++)
                {
                    if (w % 2 != 0)
                    {
                        boardOutput.Append("*");
                    }
                    else
                    {
                        boardOutput.Append(" ");
                    }
                }
                boardOutput.Append("\n");
            }
            return boardOutput;
        }
    }
}
