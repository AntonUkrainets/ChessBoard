namespace ChessBoard.Validation
{
    public static class Validator
    {
        public static bool IsArgumentsValid(string[] args)
        {
            return args.Length == 2;
        }
    }
}