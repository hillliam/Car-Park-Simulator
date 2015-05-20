using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Park_Simulator
{
    class payment
    {
        private Coin insetedcoin;
        private int coinid;
        private double requiredMoney;
        public payment()
        { 
            
        }
        public void setcoinid(int id)
        {
            coinid = id;
        }
        public int getcoinid()
        {
            return coinid;
        }
        public void insertcoin(Coin coin)
        {
            insetedcoin = coin;
        }
        public Coin returncoin()
        {
            return insetedcoin;
        }
        public void calculatevalue()
        {
            requiredMoney = insetedcoin.getstayedtime().Seconds;
        }
        public string getrequiredbalence()
        {
            if (insetedcoin != null)
            {
                return requiredMoney.ToString();
            }
            else return "Please insert a coin.";
        }
        public void insert1p()
        {
            calculateAmountRemaining(0.01);
        }
        public void insert2p()
        {
            calculateAmountRemaining(0.02);
        }
        public void insert5p()
        {
            calculateAmountRemaining(0.05);
        }
        public void insert10p()
        {
            calculateAmountRemaining(0.1);
        }
        public void insert20p()
        {
            calculateAmountRemaining(0.2);
        }
        public void insert50p()
        {
            calculateAmountRemaining(0.5);
        }
        public void insert1pound()
        {
            calculateAmountRemaining(1);
        }
        public void insert2pound()
        {
            calculateAmountRemaining(2);
        }
        public bool haspayedinfull()
        {
            if (requiredMoney <= 0)
            {
                insetedcoin.setstate("payed");
                return true;
            }
            else
                return false;
        }

        private void calculateAmountRemaining(double coinInserted)
        {
            if ((requiredMoney - coinInserted) >= 0)
                requiredMoney -= coinInserted;
            else
                requiredMoney = 0;
        }
    }

}



    