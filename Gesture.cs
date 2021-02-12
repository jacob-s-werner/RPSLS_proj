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
        List<Gesture> losesToList;
        List<Gesture> beatsList;

        public Gesture(string name)
        {
            this.name = name;

            losesToList = new List<Gesture>();
            beatsList = new List<Gesture>();
        }
    }
}
