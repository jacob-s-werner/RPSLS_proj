using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        // Member Variables (HAS a)
        public string name, gestureChoice;
        public int score;
        
        public List<string> gesturesNameList;
        public List<Gesture> gesturesList;
        // Constructor

        public Player()
        {
            name = null;
            score = 0;
            
            gesturesNameList = new List<string> { "Rock", "Paper", "Scissors", "Lizard", "Spock" };

            Gesture rock = new Rock();
            Gesture paper = new Paper();
            Gesture scissors = new Scissors();
            Gesture lizard = new Lizard();
            Gesture spock = new Spock();

            gesturesList = new List<Gesture> { rock, paper, scissors, lizard, spock };

            AddToBeatsList(rock, scissors, lizard);
            AddToBeatsList(paper, rock, spock);
            AddToBeatsList(scissors, paper, lizard);
            AddToBeatsList(lizard, paper, spock);
            AddToBeatsList(spock, rock, scissors);
        }
        // Member Methods(CAN do)
        public virtual string ChooseGesture(List<string> gesturesList)
        {
            string gestureChosen;
            bool keepRunning = true;


            while (keepRunning)
            {
                Console.WriteLine($"{name} - Type which gesture to play from the following options:");

                for (int i = 0; i < gesturesList.Count; i++)
                {
                    Console.WriteLine(gesturesList[i]);
                }
                gestureChosen = Console.ReadLine();
                Console.WriteLine("");

                if (gesturesList.Contains(gestureChosen))
                {
                    return gestureChosen;
                }
                Console.WriteLine("Invalid option, try again.\n");
            }
            return null;
        }
        public virtual void AddToBeatsList(Gesture gestureThatBeats, Gesture getsBeaten1, Gesture getsBeaten2)
        {
            gestureThatBeats.beatsList.Add(getsBeaten1);
            gestureThatBeats.beatsList.Add(getsBeaten2);
        }
    }
}
