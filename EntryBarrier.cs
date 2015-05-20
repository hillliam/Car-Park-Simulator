using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car_Park_Simulator
{
    class EntryBarrier
    {
        // TO BE IMPLEMENTED BY YOU 
        private string state ="";
        private CarPark carPark;
        public EntryBarrier(ref CarPark aCarPark)
        {
            state = "LOWERED";
            carPark = aCarPark;
        }
        public void lower()
        {
            state = "LOWERED";
        }
        public void raise()
        {
            state = "RAISED";
        }
        public string getstate()
        {
            return state;
        }
    }
}
