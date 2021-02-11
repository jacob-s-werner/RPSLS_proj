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
        Human playerOne;
        List<string> gesturesList;

        // Constructor
        public Game()
        {
            playerOne = new Human();
            gesturesList = new List<string> {"Rock","Paper","Scissors","Lizard","Spock"};
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
                Console.WriteLine("1: Player vs. AI \n2: Player vs. Player \n0: Exit Game \n");
                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    Console.WriteLine("Player vs. AI");
                }
                else if(userInput == "2")
                {
                    PlayerVsPlayer();
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
        public void PlayerVsPlayer()
        {
            Human playerTwo = new Human();
            bool keepRunning = true;
            int roundNumber;

            Console.WriteLine("----------Player vs. Player Mode----------");
            Console.WriteLine("Player One:");
            playerOne.SetName();
            Console.WriteLine("Player Two:");
            playerTwo.SetName();

            while (keepRunning)
            {
                
            }



        }
        public void BattleRound(Player player1, Player player2)
        {
            string playerOneChoice, playerTwoChoice;
            playerOneChoice = player1.ChooseGesture(gesturesList);
            playerTwoChoice = player2.ChooseGesture(gesturesList);

           
        }
        public void CompareGestures(string player1Gesture, string player2Gesture)
        {
            if (player1Gesture == player2Gesture)
            {
                Console.WriteLine("Both tied!");
            }
            else if(player1Gesture == "Rock")
            {

            }
        }
    }
}
