using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Human : Player
    {
        // Member Variables (HAS a)


        // Constructor
        public Human()
        {

        }
        
        // Member Methods(CAN do)
        public void SetName()
        {
            Console.Write("Enter your name:");
            name = Console.ReadLine();
        }

    }
}
