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
            Console.WriteLine("Prepare to play Rock Paper Scissors Lizard Spock!\n");
            Console.WriteLine("It's like Rock Paper Scissors with the following rules:");
            Console.WriteLine("Rock crushes Scissors \nScissors cuts Paper \n Paper covers Rock \n Rock crushes Lizard" +
                "Lizard poisons Spock \nSpock smashes Scissors \nScissors decapitates Lizard \nLizard eats Paper \n" +
                "Paper disproves Spock \n Spock vaporizes Rock \n");

        }

    }
}
