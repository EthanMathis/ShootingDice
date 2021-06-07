using System;

namespace ShootingDice
{
    // TODO: Complete this class

    // A player the prompts the user to enter a number for a roll
    public class HumanPlayer : Player
    {
        public override int Roll()
        {
            Console.WriteLine("Enter a number [1-6]");
            string response = Console.ReadLine();
            int responseNum;
            if (int.TryParse(response, out responseNum))
            {
                return responseNum;
            }
            else
            {
                Console.WriteLine("Please enter a number between 1 and 6...");
                response = Console.ReadLine();
            }
            return responseNum;
        }
    }
}