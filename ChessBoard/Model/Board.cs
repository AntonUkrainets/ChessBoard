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

        public uint Width { get; }

        public uint Height { get; }

        public Board(uint width, uint height)
        {
            field = new char[width, height];

            Width = width;
            Height = height;
        }
    }
}