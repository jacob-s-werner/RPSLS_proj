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
            int roundNumber = 0;

            Console.WriteLine("----------Player vs. Player Mode----------");
            Console.WriteLine("Player One:");
            playerOne.SetName();
            Console.WriteLine("Player Two:");
            playerTwo.SetName();

            while (keepRunning)
            {
                Console.WriteLine($"Round {roundNumber}:");
                BattleRound(playerOne, playerTwo);
                
                if (roundNumber >= 3 && playerTwo.score != playerOne.score)
                {
                    break;
                }
                roundNumber++;
            }



        }
        public void BattleRound(Player player1, Player player2)
        {
            int winningOption;
            string playerOneChoice, playerTwoChoice;
            
            playerOneChoice = player1.ChooseGesture(gesturesList);
            playerTwoChoice = player2.ChooseGesture(gesturesList);
            winningOption = CompareGestures(playerOneChoice, playerTwoChoice);

            if (winningOption == 1)
            {
                player1.score++;
            }
            else if (winningOption == 2)
            {
                player2.score++;
            }
        }
        public int CompareGestures(string player1Gesture, string player2Gesture)
        {
            int winningOption;

            if (player1Gesture == player2Gesture)
            {
                Console.WriteLine("Both tied!");
                return winningOption = 0;
            }
            else if(player1Gesture == "Rock" && player2Gesture == "Scissors")
            {
                Console.WriteLine("Rock crushes Scissors");
                return winningOption = 1;
            }
            else if (player1Gesture == "Scissors" && player2Gesture == "Paper")
            {
                Console.WriteLine("Scissors cuts Paper");
                return winningOption = 1;
            }
            else if (player1Gesture == "Paper" && player2Gesture == "Rock")
            {
                Console.WriteLine("Paper covers Rock");
                return winningOption = 1;
            }
            else if (player1Gesture == "Rock" && player2Gesture == "Lizard")
            {
                Console.WriteLine("Rock crushes Lizard");
                return winningOption = 1;
            }
            else if (player1Gesture == "Lizard" && player2Gesture == "Spock")
            {
                Console.WriteLine("Lizard poisons Spock");
                return winningOption = 1;
            }
            else if (player1Gesture == "Spock" && player2Gesture == "Scissors")
            {
                Console.WriteLine("Spock smashes Scissors");
                return winningOption = 1;
            }
            else if (player1Gesture == "Scissors" && player2Gesture == "Lizard")
            {
                Console.WriteLine("Scissors decapitates Lizard");
                return winningOption = 1;
            }
            else if (player1Gesture == "Lizard" && player2Gesture == "Paper")
            {
                Console.WriteLine("Lizard eats Paper");
                return winningOption = 1;
            }
            else if (player1Gesture == "Paper" && player2Gesture == "Spock")
            {
                Console.WriteLine("Paper disproves Spock");
                return winningOption = 1;
            }
            else if (player1Gesture == "Spock" && player2Gesture == "Rock")
            {
                Console.WriteLine("Spock vaporizes Rock");
                return winningOption = 1;
            }
            else if (player2Gesture == "Rock" && player1Gesture == "Scissors")
            {
                Console.WriteLine("Rock crushes Scissors");
                return winningOption = 2;
            }
            else if (player2Gesture == "Scissors" && player1Gesture == "Paper")
            {
                Console.WriteLine("Scissors cuts Paper");
                return winningOption = 2;
            }
            else if (player2Gesture == "Paper" && player1Gesture == "Rock")
            {
                Console.WriteLine("Paper covers Rock");
                return winningOption = 2;
            }
            else if (player2Gesture == "Rock" && player1Gesture == "Lizard")
            {
                Console.WriteLine("Rock crushes Lizard");
                return winningOption = 2;
            }
            else if (player2Gesture == "Lizard" && player1Gesture == "Spock")
            {
                Console.WriteLine("Lizard poisons Spock");
                return winningOption = 2;
            }
            else if (player2Gesture == "Spock" && player1Gesture == "Scissors")
            {
                Console.WriteLine("Spock smashes Scissors");
                return winningOption = 2;
            }
            else if (player2Gesture == "Scissors" && player1Gesture == "Lizard")
            {
                Console.WriteLine("Scissors decapitates Lizard");
                return winningOption = 2;
            }
            else if (player2Gesture == "Lizard" && player1Gesture == "Paper")
            {
                Console.WriteLine("Lizard eats Paper");
                return winningOption = 2;
            }
            else if (player2Gesture == "Paper" && player1Gesture == "Spock")
            {
                Console.WriteLine("Paper disproves Spock");
                return winningOption = 2;
            }
            else if (player2Gesture == "Spock" && player1Gesture == "Rock")
            {
                Console.WriteLine("Spock vaporizes Rock");
                return winningOption = 2;
            }
            else
            {
                Console.WriteLine("Error, invalid Gesture");
                return winningOption = 0;
            }


        }
    }
}
