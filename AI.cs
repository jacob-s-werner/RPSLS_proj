using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class AI : Player
    {
        // Member Variables (HAS a)
        Random random;

        // Constructor
        public AI()
        {
            name = "ComputerAI";
            random = new Random();
        }

        // Member Methods(CAN do)
        public override string ChooseGesture(List<string> gesturesList)
        {
            string gestureChosen;

            gestureChosen = gesturesList[random.Next(gesturesList.Count)];
            return gestureChosen;
        }
    }
}
