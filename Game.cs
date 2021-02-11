using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        // Member Variables (HAS a)


        // Constructor
        public Game()
        {

        }

        // Member Methods(CAN do)
        public void RunGame()
        {
            bool keepRunningMenu = true;
            string userInput;

            while (keepRunningMenu)
            {
                Console.WriteLine("Prepare to play Rock Paper Scissors Lizard Spock!\n");

                Console.WriteLine("It's like Rock Paper Scissors with the following rules:");
                Console.WriteLine("Rock crushes Scissors \nScissors cuts Paper \n Paper covers Rock \n Rock crushes Lizard" +
                    "Lizard poisons Spock \nSpock smashes Scissors \nScissors decapitates Lizard \nLizard eats Paper \n" +
                    "Paper disproves Spock \n Spock vaporizes Rock \n");

                Console.WriteLine("Enter the number for which game mode you want to play:");
                Console.WriteLine("1: Player vs. AI \n2: Player vs. Player \n0: Exit Game");
                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    
                }
                else if(userInput == "2")
                {

                }
                else if (userInput == "0")
                {
                    keepRunningMenu = false;
                }
                else
                {
                    Console.WriteLine("Invalid option,try again\n");
                }

            }
            




        }

    }
}
