using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Lizard : Gesture
    {


        public Lizard()
        {
            name = "Lizard";

            image[0] = "                         ";
            image[1] = @"     ______              ";
            image[2] = @"    ( {()} )________     ";
            image[3] = @"    (-------______'')__, ";
            image[4] = @"    (-------________)  ' ";
            image[5] = @"   (  -----)             ";
            image[6] = @"  (       )              ";
            image[7] = @" (_______)               ";
            image[8] = "                         ";
        }
    }
}
