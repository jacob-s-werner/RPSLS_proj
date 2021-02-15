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
        List<string> gesturesNameList;
        List<Gesture> gesturesList;

        // Constructor
        public Game()
        {
            playerOne = new Human();
            gesturesNameList = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };


            Gesture rock = new Gesture("Rock");
            Gesture paper = new Gesture("Paper");
            Gesture scissors = new Gesture("Scissors");
            Gesture lizard = new Gesture("Lizard");
            Gesture spock = new Gesture("Spock");
            gesturesList = new List<Gesture> { rock, paper, scissors, lizard, spock };

            rock.beatsList.Add(scissors);
            rock.beatsList.Add(lizard);
            rock.losesToList.Add(paper);
            rock.losesToList.Add(spock);

            paper.beatsList.Add(rock);
            paper.beatsList.Add(spock);
            paper.losesToList.Add(scissors);
            paper.losesToList.Add(lizard);

            scissors.beatsList.Add(paper);
            scissors.beatsList.Add(lizard);
            scissors.losesToList.Add(rock);
            scissors.losesToList.Add(spock);

            lizard.beatsList.Add(paper);
            lizard.beatsList.Add(spock);
            lizard.losesToList.Add(rock);
            lizard.losesToList.Add(scissors);

            spock.beatsList.Add(rock);
            spock.beatsList.Add(scissors);
            spock.losesToList.Add(paper);
            spock.losesToList.Add(lizard);

            paper.image[0] = "                  ";
            paper.image[1] = @"   _____________  "; // @ symbol makes it so it doesnt produce 'unrecognized escape error'
            paper.image[2] = @"  | ~~~         | ";
            paper.image[3] = @"  | ~~~~~~~~~~~ | ";
            paper.image[4] = @"  | ~~~~~~~~~~~ | ";
            paper.image[5] = @"  | ~~~~~~~~~~  | ";
            paper.image[6] = @"  | ~~~~~~~~~~~ | ";
            paper.image[7] = @"  | -JW         | ";
            paper.image[8] = @"  '-------------' ";

            scissors.image[0] = "                         ";
            scissors.image[1] = "                         ";
            scissors.image[2] = @"  ,----,___   _________  ";
            scissors.image[3] = @" ( <__> )__\ /_________\ ";
            scissors.image[4] = @"   ---- ___{X}__________ ";
            scissors.image[5] = @" ( <__> )__/ \_________/ ";
            scissors.image[6] = @"  '----'                 ";
            scissors.image[7] = "                         ";
            scissors.image[8] = "                         ";

            lizard.image[0] = "                         ";
            lizard.image[1] = @"     ______              "; 
            lizard.image[2] = @"    ( {()} )________     ";
            lizard.image[3] = @"    (-------______'')__, "; 
            lizard.image[4] = @"    (-------________)  ' "; 
            lizard.image[5] = @"   (  -----)             "; 
            lizard.image[6] = @"  (       )              "; 
            lizard.image[7] = @" (_______)               "; 
            lizard.image[8] = "                         ";
            
            spock.image[0] = "                ";
            spock.image[1] = @"    /\/\  /\    "; // @ symbol makes it so it doesnt produce 'unrecognized escape error'
            spock.image[2] = @"    | | | | |/\ ";
            spock.image[3] = @"    | | | | | | ";
            spock.image[4] = @" /\ |   \_/ | | ";
            spock.image[5] = @" \ \|         / ";
            spock.image[6] = @"  \ \        /  ";
            spock.image[7] = @"   \________/   ";
            spock.image[8] = "                ";





        }

        // Member Methods(CAN do)
        public void StartGame()
        {
            bool keepRunningMenu = true;
            string userInput;

            while (keepRunningMenu)
            {
                Console.WriteLine("Prepare to play Rock Paper Scissors Lizard Spock!\n");

                Console.WriteLine("It's like Rock Paper Scissors with the following rules:");
                Console.WriteLine("Rock crushes Scissors \nScissors cuts Paper \nPaper covers Rock \nRock crushes Lizard" +
                    "Lizard poisons Spock \nSpock smashes Scissors \nScissors decapitates Lizard \nLizard eats Paper \n" +
                    "Paper disproves Spock \nSpock vaporizes Rock \n Play for the best out of three rounds\n");

                Console.WriteLine("Enter the number for which game mode you want to play:");
                Console.WriteLine("1: Player vs. AI \n2: Player vs. Player \n0: Exit Game \n");
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
            
            player1.gestureChoice = player1.ChooseGesture(gesturesNameList);
            Console.Clear();
            
            Console.WriteLine($"Round {roundNumber}");
            player2.gestureChoice = player2.ChooseGesture(gesturesNameList);
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

            foreach (Gesture gesture in gesturesList)
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
                Console.WriteLine($"Both tied with {playerOnePick.name}!");
            }
            else if (playerOnePick.beatsList.Contains(playerTwoPick))
            {
                Console.WriteLine($"{playerOnePick.name} beats {playerTwoPick.name}!");
                return winningOption = 1;
            }
            else if (playerTwoPick.beatsList.Contains(playerOnePick))
            {
                Console.WriteLine($"{playerTwoPick.name} beats {playerOnePick.name}!");
                return winningOption = 2;
            }

            return winningOption;
        }
    }
}
