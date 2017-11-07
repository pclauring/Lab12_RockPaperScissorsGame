using System;

namespace Lab12_Roshambo_Game
{
    abstract class Player
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private Roshambo choice;

        public Roshambo Choice
        {
            get { return choice; }
            set { choice = value; }
        }

        public abstract Roshambo GenerateRoshambo();

        public override string ToString()
        {
            return $"{Name} picks {Choice}!";
        }

        public static int Shoot(Roshambo userChoice, Roshambo opponentChoice, int userScore, string playerName)
        {
            if (userChoice == Roshambo.Rock)
            {
                if (opponentChoice == Roshambo.Rock)
                {
                    Console.WriteLine("Draw!");
                }
                else if (opponentChoice == Roshambo.Paper)
                {
                    Console.WriteLine($"{playerName} you lose...");
                }
                else
                {
                    Console.WriteLine($"{playerName} you win!");
                    userScore++;
                }
            }

            if (userChoice == Roshambo.Paper)
            {
                if (opponentChoice == Roshambo.Paper)
                {
                    Console.WriteLine("Draw!");
                }
                else if (opponentChoice == Roshambo.Scissors)
                {
                    Console.WriteLine($"{playerName} you lose...");
                }
                else
                {
                    Console.WriteLine($"{playerName} you win!");
                    userScore++;
                }
            }

            if (userChoice == Roshambo.Scissors)
            {
                if (opponentChoice == Roshambo.Scissors)
                {
                    Console.WriteLine("Draw!");
                }
                else if (opponentChoice == Roshambo.Rock)
                {
                    Console.WriteLine($"{playerName} you lose...");
                }
                else
                {
                    Console.WriteLine($"{playerName} you win!");
                    userScore++;
                }
            }
            return userScore;
        }
    }
}
