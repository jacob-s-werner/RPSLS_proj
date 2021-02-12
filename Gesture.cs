using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Gesture
    {
        string name;
        List<Gesture> losesTo;
        List<Gesture> beats;

        public Gesture(string name)
        {
            this.name = name;

            losesTo = new List<Gesture>();
            beats = new List<Gesture>();

        }

        


    }
}
