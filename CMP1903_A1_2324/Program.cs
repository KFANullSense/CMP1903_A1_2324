using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a new Game instance, and request the user input to roll dice.
            Game localGame = new Game();
            localGame.RequestDiceRoll();

            //Create a local Testing instance, and use it to ensure that all methods are returning valid input.
            Testing localTesting = new Testing();
            localTesting.TestDie();
        }
    }
}
