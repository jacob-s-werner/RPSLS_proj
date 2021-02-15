using System.Collections.Generic;

namespace RPSLS
{
    public class Gesture // Am I ready to be a parent?
    {
        public string name;
        public List<Gesture> beatsList;
        public string[] image;
        public Gesture()
        {
            beatsList = new List<Gesture>();
            image = new string[9];
        }
    }

    
}
