using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        private static string player1 = "";
        private static string player2 = "";
        private static void Start()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Hello! This is Tic Tac Toe");
            Console.WriteLine("\n");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(".-----. _         .-----.             .-----.            ");
            Console.WriteLine("`-. .-':_;        `-. .-'             `-. .-'            ");
            Console.WriteLine("  : :  .-. .--.     : : .--.   .--.     : : .--.  .--.   ");
            Console.WriteLine("  : :  : :'  ..'    : :' .; ; '  ..'    : :' .; :' '_.'  ");
            Console.WriteLine("  :_;  :_;`.__.'    :_;`.__,_;`.__.'    :_;`.__.'`.__.'  ");
            Console.WriteLine("\n");

            Console.WriteLine("player 1 choose 'X' or 'O': Please used capital letter!");
            player1 = Console.ReadLine();

            Console.WriteLine("player 2 choose 'X' or 'O': Please used capital letter!");
            player2 = Console.ReadLine();

            if (player1 == "X" && player2 == "O")
            {
                Console.WriteLine("player 1 is : X " + "player 2 is : O");
            }
            else if (player1 == "O" && player2 == "X")
            {
                Console.WriteLine("player 1 is : O " + "player 2 is : X");
            }
            else
            {
                Console.WriteLine("you chose the same, try again");
            }
        }

        private static char[,] board = new char[3, 3];
        private static void Main(string[] args)
        { 
            Start();
            InitBoard();
            DisplayBoard();
            
            while (true)
            {
                Console.WriteLine("make a move. Player1");
            
                var move = Console.ReadLine();
                var index1 = int.Parse(move.Split(' ')[0]);
                var index2 = int.Parse(move.Split(' ')[1]);

                if (board[index1, index2] != 'X' && board[index1, index2] != 'O')
                {
                    var player = GetPlayer();
                    board[index1, index2] = player;
                    DisplayBoard();
                }

                var win = GetWinner();

                if (win != 1 && win != -1)
                    DisplayBoard();
                
                if (win == 1)
                {
                    Console.WriteLine("You win", player1);
                }
                else
                {
                    Console.WriteLine("isTie");
                }

                Console.ReadLine(); 
            }
        }

        private static int GetWinner()
        {
            if (board[0,0] == board[0,1] && board[0,1] == board[0, 2])
            {
                return 1;
            }
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2])
            {
                return 1;
            }
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2])
            {
                return 1;
            }
            else if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0])
            {
                return 1;
            }
            else if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2])
            {
                return 1;
            }
            else if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2])
            {
                return 1;
            }
            else if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                return 1;
            }
            else if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0])
            {
                return 1;
            }
            else if (board[0, 0] == 'X' && board[0,1] == 'O' && board[0,2] == 'X' 
                && board[1,0] == 'O' && board[1,1] == 'X' && board[1,2] == 'O'
                && board[2,0] == 'X' && board[2,1] == 'O' && board[2,2] == 'X')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        private static char GetPlayer()
        {
            var player1Count = 0;
            var player2Count = 0;
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if(board[i,j] == player1[0])
                    {
                        player1Count++;
                    }
                    else if(board[i, j] == player2[0])
                    {
                        player2Count++;
                    }
                }
            }
            if(player1Count == 0 && player2Count == 0)
            {
                return player1[0];
            }

            return player1Count > player2Count ? player2[0] : player1[0];
        }

        private static void InitBoard()
        {
            for (var r = 0; r <= 2; r++)
            {
                for (var c = 0; c <= 2; c++)
                    board[r, c] = ' ';
            }
        }

        private static void DisplayBoard()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2]);
            Console.WriteLine("    --+-+--");
        }
    }
}

