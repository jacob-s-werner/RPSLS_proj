using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Spock : Gesture
    {


        public Spock()
        {
            name = "Spock";

            image[0] = "                ";
            image[1] = @"    /\/\  /\    ";
            image[2] = @"    | | | | |/\ ";
            image[3] = @"    | | | | | | ";
            image[4] = @" /\ |   \_/ | | ";
            image[5] = @" \ \|         / ";
            image[6] = @"  \ \        /  ";
            image[7] = @"   \________/   ";
            image[8] = "                ";
        }
    }
}
