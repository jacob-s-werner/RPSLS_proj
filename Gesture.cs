using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Gesture
    {
        public string name;
        public List<Gesture> losesToList;
        public List<Gesture> beatsList;
        public string[] image;
        public Gesture(string name)
        {
            this.name = name;

            losesToList = new List<Gesture>();
            beatsList = new List<Gesture>();
            image = new string[9];
        }
    }
}
