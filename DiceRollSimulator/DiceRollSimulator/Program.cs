using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dice = new int[] { 0, 0 };
            Random random = new Random();
            int counter = 1;
            int sides;

            Console.WriteLine("\n\n============================================\n" +
                "\tWelcome to Grand Circus Casino!\n" +
                "============================================\n\n\n");
                sides = DiceRollerApp.GetSidesNumberFromUser("How many sides ?");

            while (DiceRollerApp.Confirmation("Roll?<Y/N>  ", "y", "n"))
            {
                dice[0] = DiceRollerApp.GetRoll(sides, random);
                dice[1] = DiceRollerApp.GetRoll(sides, random);

                Console.WriteLine($"\n\nRoll {counter}: {DiceRollerApp.SpecialMessage(dice, sides)}" +
                    $"\n\nDie1:{dice[0]}   Die2:{dice[1]}\n\n");
                counter++;
            } 
        }        
    }
}
