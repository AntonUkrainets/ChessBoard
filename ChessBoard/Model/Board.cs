namespace ChessBoard.Model
{
    public class Board
    {
        private readonly char[,] field;

        public char this[int x, int y]
        {
            get => field[x, y];
            set => field[x, y] = value;
        }

        public int Width { get; }

        public int Height { get; }

        public Board(int width, int height)
        {
            field = new char[width, height];

            Width = width;
            Height = height;
        }
    }
}