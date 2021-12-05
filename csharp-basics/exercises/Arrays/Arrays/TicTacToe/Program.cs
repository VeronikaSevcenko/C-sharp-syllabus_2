using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        private static void Start()
        {
            int Player = 1;
            int choice;
            int flag = 0;

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(".-----. _         .-----.             .-----.            ");
            Console.WriteLine("`-. .-':_;        `-. .-'             `-. .-'            ");
            Console.WriteLine("  : :  .-. .--.     : : .--.   .--.     : : .--.  .--.   ");
            Console.WriteLine("  : :  : :'  ..'    : :' .; ; '  ..'    : :' .; :' '_.'  ");
            Console.WriteLine("  :_;  :_;`.__.'    :_;`.__,_;`.__.'    :_;`.__.'`.__.'  ");
            Console.WriteLine("\n");
            Console.WriteLine("Hello! This is Tic Tac Toe");
            Console.WriteLine("\n");


            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Player1:X and Player2:O");
            Console.WriteLine("\n");

            if (Player % 2 == 0)
            {
                Console.WriteLine("Player 2 Chance");
            }
            else
            {
                Console.WriteLine("Player 1 Chance");
            }
            Console.WriteLine("\n");
        }
            
            


        private static char[,] board = new char[3, 3];
        

        private static void Main(string[] args)
        { 
            Start();
            InitBoard();
            DisplayBoard();
            
        }

        private static void InitBoard()
        {
            // fills up the board with blanks
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

