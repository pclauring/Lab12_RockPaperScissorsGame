using System;

namespace Lab12_Roshambo_Game
{
    class Validator
    {
        public static int GetValidSelection(string prompt, int upperLimit, int lowerLimit)
        {
            bool success = false;
            int selection = 0;
            while (!success)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                success = int.TryParse(input, out selection);

                if (selection > upperLimit || selection < lowerLimit)
                {
                    Console.Write($"Not a valid input... ");
                    success = false;
                }
            }
            return selection;
        }

        public static int GetRockPaperOrScissors()
        {
            bool success = false;
            while (!success)
            {
                Console.WriteLine("Rock paper or scissors? (R/P/S)?");

                char input = Console.ReadLine().ToLower()[0];
                if (input == 'r' || input == 'p' || input == 's')
                {
                    if (input == 'r')
                    {
                        success = true;
                        return 0;
                    }
                    else if (input == 'p')
                    {
                        success = true;
                        return 1;
                    }
                    else
                    {
                        success = true;
                        return 2;
                    }
                }
                Console.WriteLine("Not a valid input...");

            }
            return -1;
        }

        public static bool GetYesorNo()
        {
            bool valid = true;
            bool repeat = true;
            while (valid)
            {
                string answer = Console.ReadLine().ToLower();
                if (answer == "y" || answer == "yes")
                {
                    valid = false;
                    repeat = true;
                }
                else if (answer == "n" || answer == "no")

                {
                    valid = false;
                    repeat = false;
                }
                else
                {
                    Console.Write("Did not enter a valid input. Please enter (Y/N): ");
                }
            }

            return repeat;
        }
    }
}
