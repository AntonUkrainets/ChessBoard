using System;

namespace ChessBoard.ConsoleManagers.Interfaces
{
    public interface IConsoleManager
    {
        ConsoleColor BackgroundColor { get; set; }

        void SetFont(string fontName);
        void Write(string text);
        void WriteLine();
        void ResetColor();
    }
}