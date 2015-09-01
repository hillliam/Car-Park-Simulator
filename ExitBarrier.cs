// Copyright © Liam Hill, Joe Leach, Joe Guz 2015
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car_Park_Simulator
{
    class ExitBarrier
    {
        private CarPark carPark;
        private string state;

        // You need to discuss why the aCarPark object is passed to this constructor by reference!
        public ExitBarrier(ref CarPark aCarPark)
        {
            state = "LOWERED";
            carPark = aCarPark;
        }

        // TO BE IMPLEMENTED BY YOU
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
