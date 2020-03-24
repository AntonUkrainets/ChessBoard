using System;
using ChessBoard.Business.Interfaces;
using ChessBoard.ConsoleManagers.Interfaces;
using ChessBoard.Model;

namespace ChessBoard.Business
{
    public class ConsoleBoard : IDraw
    {
        private readonly IConsoleManager consoleManager;

        public ConsoleBoard(IConsoleManager consoleManager)
        {
            this.consoleManager = consoleManager;
        }

        public void Draw(Board board)
        {
            var width = board.Width;
            var height = board.Height;

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j % 2 == i % 2)
                    {
                        consoleManager.BackgroundColor = ConsoleColor.DarkGray;
                    }

                    consoleManager.Write($"{board[j, i]} ");

                    consoleManager.ResetColor();
                }

                consoleManager.WriteLine();
            }
        }
    }
}