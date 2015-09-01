// Copyright © Liam Hill, Joe Leach, Joe Guz 2015
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car_Park_Simulator
{
    class FullSign
    {
        // TO BE COMPLETED BY YOU
        public string state;
        public FullSign()
        {
            state = "False";
        }
        public string getstate()
        {
            return state;
        }
        public void setstate(string newstate)
        {
            state = newstate;
        }
    }
}
