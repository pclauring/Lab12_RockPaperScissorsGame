namespace Lab12_Roshambo_Game
{
    class UserPlayer : Player
    {
        public UserPlayer(string name)
        {
            this.Name = name;
        }

        public override Roshambo GenerateRoshambo()
        {
            int selection = Validator.GetRockPaperOrScissors();

            if (selection == 0)
            {
                Choice = Roshambo.Rock;
            }
            else if (selection == 1)
            {
                Choice = Roshambo.Paper;
            }
            else
            {
                Choice = Roshambo.Scissors;
            }
            return Choice;
        }
    }
}
