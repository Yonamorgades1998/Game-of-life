using System;
using System.IO;

namespace PII_Game_Of_Life
{
    
    public class Game
    {
        public int BoardWidth {get; set;}
        public int BoardHeight { get; set; }
        public bool [,] GameBoard {get; set;}
        public bool [,] CloneBoard {get; set;}

        public Game(Board board)
        {
            this.GameBoard = board.Board_;
            this.BoardWidth = GameBoard.GetLength(0);
            this.BoardHeight = GameBoard.GetLength(1);
            this.CloneBoard = new bool[BoardWidth, BoardHeight];
        }

        public void LogicaGame()
        {
            for (int x = 0; x < this.BoardWidth; x++)
            {
                for (int y = 0; y < this.BoardHeight; y++)
                {
                    int aliveNeighbors = 0;
                    for (int i = x-1; i<=x+1;i++)
                    {
                        for (int j = y-1;j<=y+1;j++)
                        {
                            if(i>=0 && i<this.BoardWidth && j>=0 && j < this.BoardHeight && this.GameBoard[i,j])
                            {
                                aliveNeighbors++;
                            }
                        }
                    }
                    if(this.GameBoard[x,y])
                    {
                        aliveNeighbors--;
                    }
                    if (this.GameBoard[x,y] && aliveNeighbors < 2)
                    {
                        //Celula muere por baja población
                        this.CloneBoard[x,y] = false;
                    }
                    else if (this.GameBoard[x,y] && aliveNeighbors > 3)
                    {
                        //Celula muere por sobrepoblación
                        this.CloneBoard[x,y] = false;
                    }
                    else if (!this.GameBoard[x,y] && aliveNeighbors == 3)
                    {
                        //Celula nace por reproducción
                        this.CloneBoard[x,y] = true;
                    }
                    else
                    {
                        //Celula mantiene el estado que tenía
                        this.CloneBoard[x,y] = this.GameBoard[x,y];
                    }
                }
            }
            this.GameBoard = this.CloneBoard;
            this.CloneBoard = new bool[this.BoardWidth, this.BoardHeight];
        }

    }
}