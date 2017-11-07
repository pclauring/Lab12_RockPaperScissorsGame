using System;

namespace Lab12_Roshambo_Game
{
    class RandomRoshamboPlayer : Player
    {
        Random random;
        public RandomRoshamboPlayer(string name)
        {
            random = new Random();

            this.Name = name;
        }

        public override Roshambo GenerateRoshambo()
        {
            Roshambo choice = (Roshambo)random.Next(3);
            Choice = choice;
            return choice;
        }
    }
}

