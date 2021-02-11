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
        public string name;

        // Constructor

        public Player()
        {
            name = null;
        }
        // Member Methods(CAN do)
        public virtual string ChooseGesture(List<string> gesturesList)
        {
            string gestureChosen;
            bool keepRunning = true;


            while (keepRunning)
            {
                Console.WriteLine($"{name} - Type which gesture to play out of the following options:");

                for (int i = 0; i < gesturesList.Count; i++)
                {
                    Console.WriteLine(gesturesList[i]);
                }
                gestureChosen = Console.ReadLine();
                if (gesturesList.Contains(gestureChosen))
                {
                    return gestureChosen;
                }
                Console.WriteLine("Invalid option, try again.\n");
            }

            return null;

        }
        
    }
}
