namespace Lab12_Roshambo_Game
{
    class RockPlayer : Player
    {
        public RockPlayer(string name)
        {
            this.Name = name;
        }

        public override Roshambo GenerateRoshambo()
        {
            Choice = Roshambo.Rock;
            this.Choice = Roshambo.Rock;
            return Choice;
        }
    }
}
