using System;

namespace Lab12_Roshambo_Game
{
    class RoshamboApp
    {
        static void Main(string[] args)
        {
            Player randomPlayer = new RandomRoshamboPlayer("Rando");
            Player rockPlayer = new RockPlayer("Brick");

            int userScore = 0;
            Console.WriteLine("Please enter your username!");
            Player user = new UserPlayer(Console.ReadLine());
            Console.WriteLine($"{user.Name} please pick your opponent - \"{randomPlayer.Name}\" or \"{rockPlayer.Name}\"!");

            bool validinput = false;
            Player opponent = null;

            while (!validinput)
            {

                string opponentChoice = Console.ReadLine().ToLower();
                if (opponentChoice == randomPlayer.Name.ToLower())
                {
                    opponent = randomPlayer;
                    validinput = true;
                }
                else if (opponentChoice == rockPlayer.Name.ToLower())
                {
                    opponent = rockPlayer;
                    validinput = true;
                }
                else
                {
                    Console.WriteLine("Not a valid opponent... Try a real player!");
                }
            }
            bool repeat = true;
            int games = 0;
            while (repeat)
            {
                games++;
                user.GenerateRoshambo();
                opponent.GenerateRoshambo();

                Console.WriteLine(user);
                Console.WriteLine(opponent);

                userScore = Player.Shoot(user.Choice, opponent.Choice, userScore, user.Name);

                Console.WriteLine($"{user.Name} you have won {userScore} games out of {games}!");
                Console.Write("Would you like to play again? (Y/N?): ");
                repeat = Validator.GetYesorNo();
            }
        }


    }
}
