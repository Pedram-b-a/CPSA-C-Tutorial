using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        // Creating a tictacttoe Game with Classes
        public class Player
        { 
            public string Name {  get; set; }
            public bool IsCircle { get; private set; }
            public Player(string name, bool isCircle) 
            {
                this.Name = name;
                this.IsCircle = isCircle;
            }
            
        }

        public class Board
        {
            private bool?[,] boardArray = new bool?[3, 3];
            
            public Board()
            {
                for (int i = 0; i < boardArray.GetLength(0); i++)
                {
                    for(int j = 0; j < boardArray.GetLength(1); j++)
                    {
                        boardArray[i, j] = null;
                    }
                }
            }
            public bool playAt(Player player, int x, int y)
            {
                if (x <= 3 && y <= 3 && x > 0&& y > 0)
                {
                    x--;
                    y--;
                    if (boardArray[x, y] == null)
                    {
                        this.boardArray[x, y] = player.IsCircle;
                        return true;
                    }
                }
                
                Console.WriteLine("Illegal Move Press Enter to Continue");
                Console.ReadLine();
                return false;
            }
            public bool winCheck(Player player)
            {
                bool isCircle = player.IsCircle;

                // Check rows
                for (int i = 0; i < 3; i++)
                {
                    if (boardArray[i, 0] == isCircle && boardArray[i, 1] == isCircle && boardArray[i, 2] == isCircle)
                    {
                        return true;
                    }
                }

                // Check columns
                for (int i = 0; i < 3; i++)
                {
                    if (boardArray[0, i] == isCircle && boardArray[1, i] == isCircle && boardArray[2, i] == isCircle)
                    {
                        return true;
                    }
                }

                // Check diagonals
                if ((boardArray[0, 0] == isCircle && boardArray[1, 1] == isCircle && boardArray[2, 2] == isCircle) ||
                    (boardArray[0, 2] == isCircle && boardArray[1, 1] == isCircle && boardArray[2, 0] == isCircle))
                {
                    return true;
                }

                return false; // No winning condition met
            }
           
            public void displayBoard()
            {
                Console.Clear();
                for (int i = 0; i < boardArray.GetLength(0); i++)
                { 
                    for (int j = 0; j < boardArray.GetLength(1); j++)
                    {
                        if (boardArray[i, j] == false)
                        {
                            Console.Write(" X ");
                        }
                        else if (boardArray[i, j] == true)
                        {
                            Console.Write(" O ");
                        }
                        else
                        {
                            Console.Write(" . ");
                        }    
                    }
                    Console.WriteLine();
                }
            }

            public bool isFinished()
            {
                for (int i = 0; i < boardArray.GetLength(0); i++)
                {
                    for (int j = 0;j < boardArray.GetLength(1); j++)
                    {
                        if (this.boardArray[i, j] == null)
                        {
                            return false;
                        }
                    }
                }
                return true;
            }

        }


        static void Main(string[] args)
        {
            
            
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                try
                {
                    Console.Write("Please enter your name For Player 1 : ");
                    Player player1 = new Player(Console.ReadLine(), true);
                    Console.Clear();
                    Console.Write("Please enter your name For Player 2 : ");
                    Player player2 = new Player(Console.ReadLine(), false);

                    Board board = new Board();
                    int x, y;

                    while (true)
                    {

                        if (board.isFinished())
                        {
                            Console.WriteLine("Game has finished Press Enter to Play Agian");
                            Console.ReadLine();
                            break;
                        }
                        board.displayBoard();

                        Console.Write("Player 1 Enter X : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Player 1 Enter Y : ");
                        y = Convert.ToInt32(Console.ReadLine());
                        board.playAt(player1, x, y);
                        board.displayBoard();

                        if (board.winCheck(player1))
                        {
                            Console.WriteLine("Done!!!");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        Console.Clear();
                        board.displayBoard();
                        Console.Write("Player 1 Enter X : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Player 1 Enter Y : ");
                        y = Convert.ToInt32(Console.ReadLine());
                        board.playAt(player2, x, y);
                        board.displayBoard();
                        if (board.winCheck(player2))
                        {
                            Console.WriteLine("Done!!!");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{ e.Message} Press Enter To Start Over !!!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
