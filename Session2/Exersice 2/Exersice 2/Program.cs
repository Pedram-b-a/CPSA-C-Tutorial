using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exersice_2
{
    internal class Program
    {
        // Creating a TicTacToe Game with Classes
        public class Player
        {
            // properties : player name, player id, the player is X or O
        }

        public class Board
        {
            private bool?[,] boardArray = new bool?[3, 3];
            // 2D Array that can get either true, false, null

            public Board()
            {
                // Create a 3 x 3 Board containing null
            }
            public bool playAt(Player player, int x, int y)
            {
                // the player X or O should be placed at x,y in the table
                // x = 1, y = 1 => 
                /* [0 . .]
                 * [. . .]
                   [. . .]*/
            }
            public bool winCheck(Player player)
            {
                for (int i = 0; i < 3; i++) 
                {
                    // checking rows

                    // >>>>>

                    // checking columns

                    // >>>>>

                    // checking diagonals
                    if ((boardArray[0, 0] == player.IsCircle && boardArray[1, 1] == player.IsCircle && boardArray[2, 2] == player.IsCircle) ||
                        (boardArray[0, 2] == player.IsCircle && boardArray[1, 1] == player.IsCircle && boardArray[2, 0] == player.IsCircle))
                    {
                        return true;
                    }
                }
                return false;
            }
            public void displayBoard()
            {
                // Create the table with this format
                /*[ . . . ]
                  [ . . . ]
                  [ . . . ]*/
                // using O & X
            }

        }


        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                try
                {
                    // Creating the players
                    Console.Write("Please enter your name For Player 1 : ");
                    Player player1 = new Player(Console.ReadLine(), true);
                    Console.Clear();
                    Console.Write("Please enter your name For Player 2 : ");
                    Player player2 = new Player(Console.ReadLine(), false);

                    // creating the board
                    Board board = new Board();
                    // x, y for the players choice
                    int x, y;

                    // Main game
                    while (true)
                    {

                        Console.Clear();
                        // Showing the board
                        board.displayBoard();

                        // getting the player 1 x, y
                        Console.Write("Player 1 Enter X : ");
                        x = Convert.ToInt32(Console.ReadLine());
                        
                        Console.Write("Player 1 Enter Y : ");
                        y = Convert.ToInt32(Console.ReadLine());
                        // send the players choice to the board
                        board.playAt(player1, x, y);
                        // check that if the player has won the game
                        if (board.winCheck(player1))
                        {
                            Console.WriteLine("Done!!!");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        }
                        Console.Clear();
                        board.displayBoard();

                        Console.Write("Player 2 Enter X : ");
                        x = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Player 2 Enter Y : ");
                        y = Convert.ToInt32(Console.ReadLine());
                        
                        board.playAt(player2, x, y);
                        
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
                    Console.WriteLine($"{e.Message} Press Enter To Start Over !!!");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
        }
    }
}
