using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollSimulator
{
    class DiceRollerApp
    {
        public static int GetSidesNumberFromUser(string message)
        {
            Console.WriteLine(message);

            if (!int.TryParse(Console.ReadLine(), out int userNumber))
            {
                userNumber = GetSidesNumberFromUser("Input not valid! Try again.  ");
            }

            return userNumber;
        }

        public static int GetRoll(int max, Random random)
        {
            return random.Next(1, max);
        }


        public static bool Confirmation(string message, string trueOption, string falseOption)
        {
            Console.Write(message);
            string input = Console.ReadLine().ToLower();

            if (input == trueOption.ToLower())
            {
                return true;
            }
            else if(input == falseOption)
            {
                return false;
            }

            return Confirmation("Input is not valid." + message, trueOption, falseOption);
        }

        public static string SpecialMessage(int[] dice, int max)
        {
            //Return this if dice roll landed on highest number on each die
            if (dice[0] == max && dice[1] == max)
            {
                return "Box cars!".ToUpper();
            }
            else if (dice[0] == 1 && dice[1] == 1)
            {
                return "Snake eyes!".ToUpper();
            }
            else
            {
                return "Craps!";
            }
        }
    }
}
