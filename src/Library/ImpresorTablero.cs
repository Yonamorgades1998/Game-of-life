using System;
using System.IO;
using System.Text;
using System.Threading;

namespace PII_Game_Of_Life
{
    
    public class ImpresorTablero
    {
        public static void MostrarTablero(Juego juego)
        {
            while (true)
            {
                Console.Clear();
                StringBuilder s = new StringBuilder();
                for (int y = 0; y<juego.BoardHeight;y++)
                {
                    for (int x = 0; x<juego.BoardWidth; x++)
                    {
                        if(juego.GameBoard[x,y])
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
                juego.LogicaJuego();
                Thread.Sleep(300);
            }
        }
    }
}