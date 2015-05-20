using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car_Park_Simulator
{
    class CarPark
    {
        // TO BE COMPLETED BY YOU
        private int spaces;
        private int maxspaces;
        public CarPark(int numspace)
        {
            maxspaces = numspace;
        }
        public bool hasAvailableSpaces()
        {
            return (spaces == maxspaces ? false : true); // TODO: understand me
        }

        public int getAvailableSpace()
        {
            return maxspaces - spaces; // TODO: understand me
        }

        public int getTotalSpace()
        {
            return maxspaces; // TODO: understand me
        }
        public bool isfull()
        {
            return (spaces == maxspaces ? true : false);
        }
        public void increment()
        {
            spaces++;
        }
        public void decroment()
        {
            spaces--;
        }
    }
}