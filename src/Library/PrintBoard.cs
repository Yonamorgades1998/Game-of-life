using System;
using System.IO;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    
    public class PrintBoard
    {
        public static void ShowBoard(Game game)
        {
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<game.BoardHeight;y++)
                {
                    for (int x = 0; x<game.BoardWidth; x++)
                    {
                        if(game.GameBoard[x,y])
                        {
                            s.Append("|X|");
                        }
                        else
                        {
                            s.Append("___");
                        }
                    }
                    s.Append("\n");
                }
                Console.WriteLine(s.ToString());
                game.LogicaGame();
                Thread.Sleep(300);
            }
        }
    }
}