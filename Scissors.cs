using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Scissors : Gesture
    {

        public Scissors()
        {
            name = "Scissors";

            image[0] = "                         ";
            image[1] = "                         ";
            image[2] = @"  ,----,___   _________  ";
            image[3] = @" ( <__> )__\ /_________\ ";
            image[4] = @"   ---- ___{X}__________ ";
            image[5] = @" ( <__> )__/ \_________/ ";
            image[6] = @"  '----'                 ";
            image[7] = "                         ";
            image[8] = "                         ";
        }
    }
}
