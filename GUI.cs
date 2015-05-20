using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Microsoft.VisualBasic;

namespace Car_Park_Simulator
{
    public partial class GUI : Form
    {
        // All the objects, which are used in the application should be declared here. 
        private CarPark carPark;

        // TO COMPLETED BY YOU
        private CoinMachine machine;
        private ExitBarrier exitdoor;
        private EntryBarrier enterdoor;
        private FullSign full;
        private payment paymachine;
        // The purpose of this private object is to store coins collected by drivers from the coin machine upon their entry to the car park.
        private List <Coin> CollectedCoins;
        private int exitindex;

        public GUI()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStart.Text = "RESTART";
            
            // All the objects, which are used in the application, are initialiased here.
            carPark = new CarPark(5);
            machine = new CoinMachine();
            exitdoor = new ExitBarrier(ref carPark);
            enterdoor = new EntryBarrier(ref carPark);
            full = new FullSign();
            paymachine = new payment();
            //  TO BE COMPLETED BY YOU

            // The coin list is initialiased with empty coins because no car has arrived at the car park yet at the beginning.
            CollectedCoins = new List<Coin>();
            CollectedCoins.Clear();

            btnCarArrives.Visible = true;
            btnCarArrivesAtExit.Visible = false;
            btnEnterCarPark.Visible = false;
            btnEnterCoin.Visible = false;
            btnExitCarPark.Visible = false;
            btnPressForCoin.Visible = false;
            btnInsertCoin.Enabled = false;
            btnCalculateValue.Enabled = false;
            btnRequestCoin.Enabled = false;
            btnInsert1p.Enabled = false;
            btnInsert2p.Enabled = false;
            btnInsert5p.Enabled = false;
            btnInsert10p.Enabled = false;
            btnInsert20p.Enabled = false;
            btnInsert50p.Enabled = false;
            btnInsert1Pound.Enabled = false;
            btnInsert2Pound.Enabled = false;
            btnCalculateValue.Enabled = false;
            UpdateDisplay();
            UpdateCoinsDisplay();
        }

        private void btnCarArrives_Click(object sender, EventArgs e)
        {
            string displayMessage = "Please press for coin";

            // TO BE COMPLETED BY YOU
            machine.cararives();
            machine.setmessage(displayMessage);
            btnCarArrives.Visible = false;
            btnPressForCoin.Visible = true;

            UpdateDisplay();
        }

        private void btnPressForCoin_Click(object sender, EventArgs e)
        {
            // TO BE COMPLETED BY YOU
            CollectedCoins.Add(machine.presscoin());
            MessageBox.Show("Your coin id is " + CollectedCoins[CollectedCoins.Count - 1].getid());// TODO: should the coinmachine display this
            enterdoor.raise();
            machine.clearmessage();
            btnPressForCoin.Visible = false;
            btnEnterCarPark.Visible = true;

            UpdateDisplay();
        }

        private void btnEnterCarPark_Click(object sender, EventArgs e)
        {
            // TO BE COMPLETED BY YOU
            carPark.increment();
            enterdoor.lower();
            btnEnterCarPark.Visible = false;
            if (carPark.hasAvailableSpaces())
                btnCarArrives.Visible = true;
            else
                full.setstate("True");
            if (!btnEnterCoin.Visible && !btnExitCarPark.Visible)
                btnCarArrivesAtExit.Visible = true;

            UpdateDisplay();
        }

        private void btnCarArrivesAtExit_Click(object sender, EventArgs e)
        {
            string displayMessage = "Please enter coin";

            // TO BE COMPLETED BY YOU
            machine.setmessage(displayMessage);
            btnCarArrivesAtExit.Visible = false;
            btnEnterCoin.Visible = true;
            btnInsertCoin.Enabled = true;
            UpdateDisplay();
        }

        private void btnEnterCoin_Click(object sender, EventArgs e)
        {
            // TO BE COMPLETED BY YOU
            int number = int.Parse(Interaction.InputBox("Please enter your coin id", "Enter coin id", (CollectedCoins.Count - 1).ToString()));
            machine.entercoin(CollectedCoins[number]);
            if (machine.haspayed(number))
            {
                exitindex = number;
                exitdoor.raise();
                machine.clearmessage();
                btnEnterCoin.Visible = false;
                btnExitCarPark.Visible = true;
            }
            else
            {
                btnEnterCoin.Visible = false;
                btnCarArrivesAtExit.Visible = true;
                machine.setmessage("Please pay for your stay");// TODO: should the payment machine display this
            }
            UpdateDisplay();
        }

        private void btnExitCarPark_Click(object sender, EventArgs e)
        {
            // TO BE COMPLETED BY YOU
            machine.carexits(exitindex);
            carPark.decroment();
            CollectedCoins.RemoveAt(exitindex);
            btnExitCarPark.Visible = false;
            if (carPark.getAvailableSpace() != carPark.getTotalSpace())
                btnCarArrivesAtExit.Visible = true;
            if (carPark.hasAvailableSpaces() && !btnPressForCoin.Visible && !btnEnterCarPark.Visible)
                btnCarArrives.Visible = true;
            if (carPark.getAvailableSpace() == carPark.getTotalSpace())
                btnInsertCoin.Enabled = false;

            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            txtFullSign.Text = full.getstate(); // "full" or "avalible"
            txtAvailableCoins.Text = machine.getnumberofcoins().ToString();  // coins avalible to give
            txtAvailableSpaces.Text = carPark.getAvailableSpace().ToString(); // a number between the the size of the car park and 0
            txtEntryBarrier.Text = enterdoor.getstate();    // am i up or down
            txtExitBarrier.Text = exitdoor.getstate(); // am i up or down
            txtCoinMachine.Text = machine.getmessage();
            txtPaymentDisplay.Text = paymachine.getrequiredbalence();
            UpdateCoinsDisplay();

            btnStart.Focus();
        }

        // This procedure updates the listbox that contains coins collected by drivers after entering the car park
        private void UpdateCoinsDisplay()
        {
            coinDisplay.Items.Clear();
            foreach (Coin coin in CollectedCoins)
            {
                coinDisplay.Items.Add("Coin " + coin.getid());
            }
        }

        private void btnInsertCoin_Click(object sender, EventArgs e)
        {
            int number = int.Parse(Interaction.InputBox("Please enter your coin id", "Enter coin id", (CollectedCoins.Count - 1).ToString()));
            paymachine.insertcoin(CollectedCoins[number]);
            paymachine.setcoinid(number);
            UpdateDisplay();
            btnCalculateValue.Enabled = true;
        }

        private void btnInsert1Pound_Click(object sender, EventArgs e)
        {
            paymachine.insert1pound();
            cangetcoin();
            UpdateDisplay();
        }

        private void btnInsert5p_Click(object sender, EventArgs e)
        {
            paymachine.insert5p();
            cangetcoin();
            UpdateDisplay();
        }

        private void btnInsert10p_Click(object sender, EventArgs e)
        {
            paymachine.insert10p();
            cangetcoin();
            UpdateDisplay();
        }
        private void cangetcoin()
        {
            if (paymachine.haspayedinfull())
                btnRequestCoin.Enabled = true;
        }

        private void btnCalculateValue_Click(object sender, EventArgs e)
        {
            paymachine.calculatevalue();
            UpdateDisplay();
            btnInsert1p.Enabled = true;
            btnInsert2p.Enabled = true;
            btnInsert5p.Enabled = true;
            btnInsert10p.Enabled = true;
            btnInsert20p.Enabled = true;
            btnInsert50p.Enabled = true;
            btnInsert1Pound.Enabled = true;
            btnInsert2Pound.Enabled = true;
        }

        private void btnRequestCoin_Click(object sender, EventArgs e)
        {
            if (paymachine.haspayedinfull())
            {
                CollectedCoins[paymachine.getcoinid()] = paymachine.returncoin();
                btnInsert1p.Enabled = false;
                btnInsert2p.Enabled = false;
                btnInsert5p.Enabled = false;
                btnInsert10p.Enabled = false;
                btnInsert20p.Enabled = false;
                btnInsert50p.Enabled = false;
                btnInsert1Pound.Enabled = false;
                btnInsert2Pound.Enabled = false;
                btnCalculateValue.Enabled = false;
                btnRequestCoin.Enabled = false;
            }
            else
                MessageBox.Show("You still need to pay for the stay"); // TODO: should the payment machine display this
        }

        private void btnInsert20p_Click(object sender, EventArgs e)
        {
            paymachine.insert20p();
            cangetcoin();
            UpdateDisplay();
        }

        private void btnInsert1p_Click(object sender, EventArgs e)
        {
            paymachine.insert1p();
            cangetcoin();
            UpdateDisplay();
        }

        private void btnInsert2p_Click(object sender, EventArgs e)
        {
            paymachine.insert2p();
            cangetcoin();
            UpdateDisplay();
        }

        private void btnInsert50p_Click(object sender, EventArgs e)
        {
            paymachine.insert50p();
            cangetcoin();
            UpdateDisplay();
        }

        private void btnInsert2Pound_Click(object sender, EventArgs e)
        {
            paymachine.insert2pound();
            cangetcoin();
            UpdateDisplay();
        }


    }
}
