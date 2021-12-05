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
          
            do
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Player1:X and Player2:O");
                Console.WriteLine("\n");

                 if (Player % 2 ==0)
                {
                    Console.WriteLine("Player 2 Chance");
                }
                 else
                {
                    Console.WriteLine("Player 1 Chance");
                }
                Console.WriteLine("\n");

                DisplayBoard();

                choice = int.Parse(Console.ReadLine());

                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (Player % 2 == 0)

                    {
                        arr[choice] = 'O';
                        Player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        Player++;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1}", choice, arr[choice]);
                    Console.WriteLine("\n");
                }
                flag = CheckWin();
            } while (flag != 1 && flag != -1);
            Console.Clear();
            DisplayBoard();

            if (flag == 1)
            {
                Console.WriteLine("Player {0} has won", (Player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Draw");
            }
            Console.ReadLine();
        }

        private static char[,] board = new char[3, 3];
        private static char[] arr =  { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };

        private static void Main(string[] args)
        { 
            Start();
            InitBoard();
            DisplayBoard();
        }

        private static void InitBoard()
        {
            // fills up the board with blanks
            for (var r = 0; r < 3; r++)
            {
                for (var c = 0; c < 3; c++)
                    board[r, c] = ' ';
            }
        }

        private static void DisplayBoard()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("  0  " + board[0, 0] + "|" + board[0, 1] + "|" + board[0, 2] , arr[1], arr[2], arr[3]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  1  " + board[1, 0] + "|" + board[1, 1] + "|" + board[1, 2] , arr[4], arr[5], arr[6]);
            Console.WriteLine("    --+-+--");
            Console.WriteLine("  2  " + board[2, 0] + "|" + board[2, 1] + "|" + board[2, 2] , arr[7], arr[8], arr[9]);
            Console.WriteLine("    --+-+--");
        }

        private static int CheckWin()
        {
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' 
                && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}

