using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Rock : Gesture
    {


        public Rock()
        {
            name = "Rock";

            image[0] = @"   \\\\                ";
            image[1] = @"    ,----,,----,,      "; // @ symbol makes it so it doesnt produce 'unrecognized escape error' due to slashes
            image[2] = @"   {  '       '  '}    "; // for the life of me I can't make a simple rock from ASCII, looks more like a cloud
            image[3] = @"  {  '  ^   *'    ''}  ";
            image[4] = @"   {   /  ' \   '   }  ";
            image[5] = @"  { ' /    ' >  '  *}  ";
            image[6] = @"   {     *  /'    ,,}  ";
            image[7] = @"    '--------'---'     ";
            image[8] = "                       ";

        }

    }
}
