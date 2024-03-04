using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * This function rolls a number of dice, stores them in a list of integers and returns the list.
         * The number of dice to be rolled can be specified, and the function can also choose to print values to the console or not.
         * The default function will roll three dice and print the results.
        */
        public List<int> RollDice (int diceToRoll = 3, bool printValues = true)
        {
            //Initialize needed variables.
            int diceTotal = 0;
            List<int> dieRolls = new List<int>();

            //Loop the following for each die that should be rolled.
            for (int i = 0; i < diceToRoll; i++)
            {
                //Create a die and roll it.
                Die localDie = new Die(); 
                localDie.Roll();

                if (printValues) { Console.WriteLine($"Die {i + 1} result: {localDie.CurrentValue}"); } //Print the result to the user if specified.
                
                //Add the dice roll to the total, and to the list of individual rolls.
                diceTotal += localDie.CurrentValue;
                dieRolls.Add(localDie.CurrentValue);
            }

            if (printValues) { Console.WriteLine($"Rolls performed: {diceToRoll} || Total sum of rolls: {diceTotal}"); } //Print the total sum of rolls if specified.
            return dieRolls; //Return the list of individual rolls.
        }

        //This function allows the user to continuously roll dice by checking their input.
        public void RequestDiceRoll()
        {
            bool shouldRollAgain = true; //Initializes the variable, being set to true so that the while loop starts.

            //The code will loop until the user specifies that they do not wish to roll again.
            while (shouldRollAgain)
            {
                //Ask the user if they would like to roll the dice, and recieve their input.
                Console.WriteLine("Would you like to roll the dice? [Y/N] ");
                string userInput = Console.ReadLine();

                /*
                 * If the user wants to roll the dice, call the roll method.
                 * If the user does not want to roll the dice, exit the loop (and therefore the program).
                 * If the user enters an invalid input, inform them, and start the loop again.
                */
                if (userInput.ToLower() == "y")
                {
                    RollDice();
                } else if (userInput.ToLower() == "n")
                {
                    shouldRollAgain = false;
                } else
                {
                    Console.WriteLine("Invalid input. Please enter [Y/N].");
                }
            }
        }
    }
}
