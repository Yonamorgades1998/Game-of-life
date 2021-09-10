using System;

namespace PII_Game_Of_Life
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(@"../../assets/board.txt");
            Game game = new Game(board);
            PrintBoard.ShowBoard(game);
        }
    }
}
