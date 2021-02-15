using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Paper : Gesture
    {


        public Paper()
        {
            name = "Paper";

            image[0] = "                  ";
            image[1] = @"   _____________  ";
            image[2] = @"  | ~~~         | ";
            image[3] = @"  | ~~~~~~~~~~~ | ";
            image[4] = @"  | ~~~~~~~~~~~ | ";
            image[5] = @"  | ~~~~~~~~~~  | ";
            image[6] = @"  | ~~~~~~~~~~~ | ";
            image[7] = @"  | -JW         | ";
            image[8] = @"  '-------------' ";
        }
    }
}
