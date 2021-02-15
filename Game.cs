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
        // Constructor
        public Game()
        {
            playerOne = new Human();
        }
        // Member Methods(CAN do)
        public void StartGame()
        {
            bool keepRunningMenu = true;
            string userInput;

            while (keepRunningMenu)
            {
                Console.WriteLine("Prepare to play Rock Paper Scissors Lizard Spock!\n");
                DisplayRules();
                
                Console.WriteLine("Enter the number for which game mode you want to play:");
                Console.WriteLine("1: Player vs. AI \n" +
                                  "2: Player vs. Player \n" +
                                  "0: Exit Game \n");
                userInput = Console.ReadLine();

                if (userInput == "1")
                {
                    PlayerVsAI();
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
        public void PlayerVsAI()
        {
            AI playerTwo = new AI();
            
            Console.WriteLine("----------Player vs. AI Mode----------");
            Console.WriteLine("Player One:");
            playerOne.SetName();
            Console.WriteLine("");
            
            RunGameMode(playerOne, playerTwo);
        }
        public void PlayerVsPlayer()
        {
            Human playerTwo = new Human();

            Console.WriteLine("----------Player vs. Player Mode----------");
            Console.WriteLine("Player One:");
            playerOne.SetName();
            Console.WriteLine("Player Two:");
            playerTwo.SetName();
            Console.WriteLine("");

            RunGameMode(playerOne, playerTwo);
        }
        public void BattleRound(Player player1, Player player2, int roundNumber)
        {
            int winningOption;
            
            player1.gestureChoice = player1.ChooseGesture(player1.gesturesNameList);
            Console.Clear();
            
            DisplayRules();
            Console.WriteLine($"Round {roundNumber}");
            player2.gestureChoice = player2.ChooseGesture(player2.gesturesNameList);
            winningOption = CompareGestures(player1.gestureChoice, player2.gestureChoice);

            if (winningOption == 1)
            {
                Console.WriteLine($"{player1.name} has won the round with {player1.gestureChoice}!\n");
                player1.score++;
            }
            else if (winningOption == 2)
            {
                Console.WriteLine($"{player2.name} has won the round with {player2.gestureChoice}!\n");
                player2.score++;
            }
        }
        public void RunGameMode(Player playerOne, Player playerTwo)
        {
            bool keepRunning = true;
            int roundNumber;
            string userResponse;

            DisplayRules();
            while (keepRunning)
            {
                roundNumber = 1;

                while (keepRunning)
                {
                    Console.WriteLine($"Round {roundNumber}:");
                    BattleRound(playerOne, playerTwo, roundNumber);

                    if (roundNumber >= 3 && playerTwo.score != playerOne.score)
                    {
                        break;
                    }
                    roundNumber++;
                }

                if (playerOne.score > playerTwo.score)
                {
                    Console.WriteLine($"\n{playerOne.name} has won the game!");
                }
                else
                {
                    Console.WriteLine($"\n{playerTwo.name} has won the game!");
                }

                Console.WriteLine("Would you like a rematch? Y/N");
                userResponse = Console.ReadLine();

                if (userResponse.ToUpper() != "Y" && userResponse.ToUpper() != "YES")
                {
                    keepRunning = false;
                }
            }
        }
        public int CompareGestures(string playerOneGesture, string playerTwoGesture)
        {
            Gesture playerOnePick = null, playerTwoPick = null; //gets rid of error if not included in gesturesList
            int winningOption = 0;

            foreach (Gesture gesture in playerOne.gesturesList)
            {
                if (gesture.name == playerOneGesture)
                {
                    playerOnePick = gesture;
                }

                if (gesture.name == playerTwoGesture)
                {
                    playerTwoPick = gesture;
                }        
            }

            if (playerOnePick == playerTwoPick)
            {
                DrawGestures(playerOnePick,playerTwoPick, true);
                Console.WriteLine($"Both tied with {playerOnePick.name}!");
            }
            else if (playerOnePick.beatsList.Contains(playerTwoPick))
            {
                DrawGestures(playerOnePick, playerTwoPick, false);
                Console.WriteLine($"{playerOnePick.name} beats {playerTwoPick.name}!");
                return winningOption = 1;
            }
            else if (playerTwoPick.beatsList.Contains(playerOnePick))
            {
                DrawGestures(playerTwoPick, playerOnePick, false);
                Console.WriteLine($"{playerTwoPick.name} beats {playerOnePick.name}!");
                return winningOption = 2;
            }

            return winningOption;
        }
        public void DrawGestures(Gesture winningGesture, Gesture losingGesture, bool tied)
        {
            for (int i = 0; i < winningGesture.image.Length; i++)
            {
                if (i == 4 && tied == true)
                {
                    Console.WriteLine(winningGesture.image[i] + "  TIED  " + losingGesture.image[i]);
                }
                else if (i == 4 && tied == false)
                {
                    Console.WriteLine(winningGesture.image[i] + "  BEATS " + losingGesture.image[i]);
                }
                else
                {
                    Console.WriteLine(winningGesture.image[i] + "        " + losingGesture.image[i]);
                }
            }
        }
        public void DisplayRules()
        {
            Console.WriteLine("It's like Rock Paper Scissors with the following rules:");
            Console.WriteLine("             Rock crushes Scissors, \n" +
                              "             Scissors cuts Paper, \n" +
                              "             Paper covers Rock, \n" +
                              "             Rock crushes Lizard, \n" +
                              "             Lizard poisons Spock, \n" +
                              "             Spock smashes Scissors, \n" +
                              "             Scissors decapitates Lizard, \n" +
                              "             Lizard eats Paper, \n" +
                              "             Paper disproves Spock, \n" +
                              "             Spock vaporizes Rock, \n\n" +
                              "      Play for the best out of three rounds. \n");
        }
        
    }
}
