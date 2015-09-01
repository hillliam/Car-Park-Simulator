// Copyright © Liam Hill, Joe Leach, Joe Guz 2015
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Car_Park_Simulator
{
    class CoinMachine
    {
        private List<Coin> coines;
        private string message;
        // TO BE COMPLETED BY YOU
        public CoinMachine()
        {
            coines = new List<Coin>();
        }
        public void entercoin(Coin item)
        {

        }
        public void cararives()
        { //give user a coin
            coines.Add(new Coin(coines.Count));
        }
        public void carexits()
        {// remove users coin
            coines.RemoveAt(coines.Count - 1);
        }
        public void carexits(int index)
        {// remove users coin
            coines.RemoveAt(index);
        }
        public Coin presscoin()
        {// give ref of coin to ui?
            return coines[coines.Count - 1];
        }
        public int getnumberofcoins()
        {
            return 10 - coines.Count;
        }
        public string getmessage()
        {
            return message;
        }
        public void setmessage(string newmessage)
        {
            message = newmessage;
        }
        public void clearmessage()
        {
            message = "";
        }
        public bool haspayed()
        {
            if (coines[coines.Count - 1].getstate() != "Unpaid")
                return true;
            else
                return false;
        }
        public bool haspayed(int index)
        {
            if (coines[index].getstate() != "Unpaid")
                return true;
            else
                return false;
        }
    }
}
