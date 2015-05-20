using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car_Park_Simulator
{
    class Coin
    {
        // TO BE COMPLETED BY YOU
        private string state = "";
        private DateTime starttime;
        private int id;
        public Coin(int setid)
        {
            state = "Unpaid";
            starttime = DateTime.Now;
            id = setid;
        }
        public void setstate(string newstate)
        {
            state = newstate;
        }
        public string getstate()
        {
            return state;
        }
        public TimeSpan getstayedtime()
        {
            return DateTime.Now - starttime; 
        }
        public int getid()
        {
            return id;
        }
    }
}
