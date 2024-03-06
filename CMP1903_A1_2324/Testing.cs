using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        //This function creates local instances of both Game() and Die(), and ensures that their outputs are within expected bounds.
        public void TestDie()
        {
            Game localGame = new Game(); //Create a local Game class.

            List<int> localDieRolls = localGame.RollDice(printValues: false); //Store the resulting list of dice rolls.

            //Check each output of the individual rolls, and ensure that they are within expected bounds.
            foreach (int roll in localDieRolls)
            {
                Debug.Assert(roll >= 1 && roll <= 6, "Roll is out of expected bounds.");
            }

            Die localDieInstance = new Die(); //Create a local Die class.

            int rollToTest = localDieInstance.Roll(); //Roll the die.

            Debug.Assert(rollToTest >= 1 && rollToTest <= 6, "Roll is out of expected bounds."); //Ensure that the outputted value of the die is within expected bounds.

            Console.WriteLine("Testing completed successfully.");
        }
    }
}
