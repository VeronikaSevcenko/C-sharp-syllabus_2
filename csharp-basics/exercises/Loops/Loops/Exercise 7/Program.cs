using System;

namespace Exercise_7
{
    class Roll
    {
        public int TotalScore { get; set; }
        public int RollScore { get; set; }
        public bool Continue { get; set; }
    }

    class Player
    {
        public string Name { get; set; }
        public int score { get; set; }
        Random rnd;
        public Player()
        {
            score = 0;
            rnd = new Random();
        }

        public Roll Roll(int LastScore)
        {
            Roll roll = new Roll();
            roll.RollScore = rnd.Next(6) + 1;

            if (roll.RollScore == 1)
            {
                roll.TotalScore = 0;
                roll.Continue = false;
                return roll;
            }
            roll.TotalScore = LastScore = roll.RollScore;
            roll.Continue = true;
            return roll;
        }

        public void Result(Roll roll)
        {
            score += roll.TotalScore;
        }
    }

    public class Game
    {
        static void Main(string[] args)
        {
            string input = null;
            Player[] player1 = new Player[1];

            while (true)
            {
                Console.WriteLine("Welcome to Piglet!");
                Console.WriteLine("You would like to play?(y/n)");
                Console.WriteLine();

                if (input.ToLowerInvariant() == "Y")
                {
                    player1[0] = new Player();
                    Console.WriteLine("What your name?");
                    input = Console.ReadLine();
                    player1[0].Name = input;
                    Console.WriteLine("Let's go,player!");
                }

                while (input == " ")
                {
                    if (input.ToLowerInvariant() == "y")
                    {
                        player1[0] = new Player();
                        Console.WriteLine("What your name?");
                        input = Console.ReadLine();
                        player1[0].Name = input;
                        Console.WriteLine("Let's go!");
                    }
                    if (input.ToLowerInvariant() == "n")
                    {
                        Console.WriteLine("Goodbye and besafe!"); ;
                    }
                    else
                    {
                        input = null;
                        Console.WriteLine("Error! You would like to play?(y/n)");

                        var streamPlayer = 0;
                        Roll roll = null;
                        bool turn = true;

                        while (turn)
                        {
                            Player one = player1[streamPlayer];
                            roll = one.Roll((roll != null) ? roll.TotalScore : 0);

                            if (roll.Continue)
                            {
                                if (roll.TotalScore + one.score > 10)
                                {
                                    Console.WriteLine("Congrats! " + one.Name + "You rolled a" + roll.RollScore +
                                        "for a final score of" + (roll.TotalScore + one.score));
                                    turn = false;
                                }
                            }
                            else
                            {
                                Console.WriteLine(one.Name + ": Roll " + roll.RollScore + "/Turn " + roll.TotalScore +
                                    "/Total " + (roll.TotalScore + one.score) + "Roll again? yes/no");
                                input = Console.ReadLine();

                                if (input.ToLowerInvariant() == "y")
                                {
                                    Console.WriteLine("Good");
                                }
                                else if (input.ToLowerInvariant() == "n")
                                {
                                    one.Result(roll);
                                    streamPlayer = Math.Abs(streamPlayer - 1);
                                    Console.WriteLine();
                                }
                                Console.WriteLine("Thanks for playing");
                            }
                        }
                    }
                }
            }
        }
    }
}

