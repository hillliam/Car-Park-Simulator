#include "carweb.h"
#include <emscripten.h>

carweb::carweb()
{
}


carweb::~carweb()
{
}

extern "C"
{
	carpark carPark;
	coinmachine machine;
	ExitBarrier exitdoor;
	EntryBarrier enterdoor;
	FullSign full;
	payment paymachine;
	// The purpose of this private object is to store coins collected by drivers from the coin machine upon their entry to the car park.
	vector<coin> CollectedCoins;
	int exitindex;
	extern "C" void setfulltext(const char* text);// Pointer_stringify(text)
	extern "C" void setAvailableCoinsText(const char* text);// Pointer_stringify(text)
	extern "C" void setAvailableSpacesText(const char* text);// Pointer_stringify(text)
	extern "C" void setEntryBarrierText(const char* text);// Pointer_stringify(text)
	extern "C" void setExitBarrierTextp(const char* text);// Pointer_stringify(text)
	extern "C" void setCoinMachineText(const char* text);// Pointer_stringify(text)
	extern "C" void setPaymentDisplayText(const char* text);// Pointer_stringify(text)
	void setbtnCarArrivesv(bool visible)
	{
		EM_ASM_({
			if ($0=1)
			    document.getElementById("btnCarArrives").style.display = "none";
			else
				document.getElementById("btnCarArrives").style.display = "block";
		}, visible);
	}
	void setbtnCarArrivesAtExitv(bool visible)
	{
		EM_ASM_({
			if ($0 = 1)
			document.getElementById("btnCarArrivesAtExit").style.display = "none";
			else
				document.getElementById("btnCarArrivesAtExit").style.display = "block";
		}, visible);
	}
	void setbtnEnterCarParkv(bool visible)
	{
		EM_ASM_({
			if ($0 = 1)
			document.getElementById("btnEnterCarPark").style.display = "none";
			else
				document.getElementById("btnEnterCarPark").style.display = "block";
		}, visible);
	}
	void setbtnEnterCoinv(bool visible)
	{
		EM_ASM_({
			if ($0 = 1)
			document.getElementById("btnEnterCoin").style.display = "none";
			else
				document.getElementById("btnEnterCoin").style.display = "block";
		}, visible);
	}
	void setbtnExitCarParkv(bool visible)
	{
		EM_ASM_({
			if ($0 = 1)
			document.getElementById("btnExitCarPark").style.display = "none";
			else
				document.getElementById("btnExitCarPark").style.display = "block";
		}, visible);
	}
	void setbtnPressForCoinv(bool visible)
	{
		EM_ASM_({
			if ($0 = 1)
			document.getElementById("btnPressForCoin").style.display = "none";
			else
				document.getElementById("btnPressForCoin").style.display = "block";
		}, visible);
	}
	void setbtnInsertCoinv(bool visible)
	{
		EM_ASM_({
			if ($0 = 1)
			document.getElementById("btnInsertCoin").style.display = "none";
			else
				document.getElementById("btnInsertCoin").style.display = "block";
		}, visible);
	}
	void setbtnCalculateValuev(bool visible)
	{
		EM_ASM_({
			if ($0 = 1)
			document.getElementById("btnCalculateValue").style.display = "none";
			else
				document.getElementById("btnCalculateValue").style.display = "block";
		}, visible);
	}
	void setbtnRequestCoinv(bool visible)
	{
		EM_ASM_({
			if ($0 = 1)
			document.getElementById("btnRequestCoin").style.display = "none";
			else
				document.getElementById("btnRequestCoin").style.display = "block";
		}, visible);
	}
	void setbtnInsert1pv(bool visible)
	{
		EM_ASM_({
			if ($0 = 1)
			document.getElementById("btnInsert1p").style.display = "none";
			else
				document.getElementById("btnInsert1p").style.display = "block";
		}, visible);
	}
	void setbtnInsert2pv(bool visible)
	{
		EM_ASM_({
			if ($0 = 1)
			document.getElementById("btnInsert2p").style.display = "none";
			else
				document.getElementById("btnInsert2p").style.display = "block";
		}, visible);
	}
	void setbtnInsert5pv(bool visible)
	{
		EM_ASM_({
			if ($0 = 1)
			document.getElementById("btnInsert5p").style.display = "none";
			else
				document.getElementById("btnInsert5p").style.display = "block";
		}, visible);
	}
	void setbtnInsert10pv(bool visible)
	{
		EM_ASM_({
			if ($0 = 1)
			document.getElementById("btnInsert10p").style.display = "none";
			else
				document.getElementById("btnInsert10p").style.display = "block";
		}, visible);
	}
	void setbtnInsert20pv(bool visible)
	{
		EM_ASM_({
			if ($0 = 1)
			document.getElementById("btnInsert20p").style.display = "none";
			else
				document.getElementById("btnInsert20p").style.display = "block";
		}, visible);
	}
	void setbtnInsert50pv(bool visible)
	{
		EM_ASM_({
			if ($0 = 1)
			document.getElementById("btnInsert50p").style.display = "none";
			else
				document.getElementById("btnInsert50p").style.display = "block";
		}, visible);
	}
	void setbtnInsert1Poundv(bool visible)
	{
		EM_ASM_({
			if ($0 = 1)
			document.getElementById("btnInsert1Pound").style.display = "none";
			else
				document.getElementById("btnInsert1Pound").style.display = "block";
		}, visible);
	}
	void setbtnInsert2Poundv(bool visible)
	{
		EM_ASM_({
			if ($0 = 1)
			document.getElementById("btnInsert2Pound").style.display = "none";
			else
				document.getElementById("btnInsert2Pound").style.display = "block";
		}, visible);
	}
	int main()
	{
		// All the objects, which are used in the application, are initialiased here.
		carPark = new carpark(5);
		machine = new coinmachine();
		exitdoor = new ExitBarrier();
		enterdoor = new EntryBarrier();
		full = new FullSign();
		paymachine = new payment();

		//  TO BE COMPLETED BY YOU
		// add event lisener for buttions
		EM_ASM(document.getElementById("btnCarArrives").onclick = function() { _btnCarArrives_Click(); });
		EM_ASM(document.getElementById("btnCarArrivesAtExit").onclick = function() { _btnCarArrivesAtExit_Click(); });
		EM_ASM(document.getElementById("btnEnterCarPark").onclick = function() { _btnEnterCarPark_Click(); });
		EM_ASM(document.getElementById("btnEnterCoin").onclick = function() { _btnEnterCoin_Click(); });
		EM_ASM(document.getElementById("btnExitCarPark").onclick = function() { _btnExitCarPar_Click(); });
		EM_ASM(document.getElementById("btnPressForCoin").onclick = function() { _btnPressForCoin_Click(); });
		EM_ASM(document.getElementById("btnInsertCoin").onclick = function() { _btnInsertCoin_Click(); });
		EM_ASM(document.getElementById("btnCalculateValue").onclick = function() { _btnCalculateValue_Click(); });
		EM_ASM(document.getElementById("btnRequestCoin").onclick = function() { _btnRequestCoin_Click(); });
		EM_ASM(document.getElementById("btnInsert1p").onclick = function() { _btnInsert1p_Click(); });
		EM_ASM(document.getElementById("btnInsert2p").onclick = function() { _btnInsert2p_Click(); });
		EM_ASM(document.getElementById("btnInsert5p").onclick = function() { _btnInsert5p_Click(); });
		EM_ASM(document.getElementById("btnInsert10p").onclick = function() { _btnInsert10p_Click(); });
		EM_ASM(document.getElementById("btnInsert20p").onclick = function() { _btnInsert20p_Click(); });
		EM_ASM(document.getElementById("btnInsert50p").onclick = function() { _btnInsert50p_Click(); });
		EM_ASM(document.getElementById("btnInsert1Pound").onclick = function() { _btnInsert1Pound_Click(); });
		EM_ASM(document.getElementById("btnInsert2Pound").onclick = function() { _btnInsert2Pound_Click(); });
		//set buttion visability
		setbtnCarArrivesv(true); //turn to functions with js 
		setbtnCarArrivesAtExitv(false);
		setbtnEnterCarParkv(false);
		setbtnEnterCoinv(false);
		setbtnExitCarParkv(false);
		setbtnPressForCoinv(false);
		setbtnInsertCoinv(false);
		setbtnCalculateValuev(false);
		setbtnRequestCoinv(false);
		setbtnInsert1pv(false);
		setbtnInsert2pv(false);
		setbtnInsert5pv(false);
		setbtnInsert10pv(false);
		setbtnInsert20pv(false);
		setbtnInsert50pv(false);
		setbtnInsert1Poundv(false);
		setbtnInsert2Poundv(false);
		setbtnCalculateValuev(false);
		UpdateDisplay();
		UpdateCoinsDisplay();
	}

	void btnCarArrives_Click()
	{
		string displayMessage = "Please press for coin";

		// TO BE COMPLETED BY YOU
		machine.cararives();
		machine.setmessage(displayMessage);
		setbtnCarArrivesv(false);
		setbtnPressForCoinv(true);

		UpdateDisplay();
	}

	void btnPressForCoin_Click()
	{
		// TO BE COMPLETED BY YOU
		CollectedCoins.push_back(machine.presscoin());
		cout<<"Your coin id is " << CollectedCoins[CollectedCoins.size() - 1].getid()<<endl;// TODO: should the coinmachine display this
		enterdoor.raise();
		machine.clearmessage();
		setbtnPressForCoinv(false);
		setbtnEnterCarParkv(true);

		UpdateDisplay();
	}

	void btnEnterCarPark_Click()
	{
		// TO BE COMPLETED BY YOU
		carPark.increment();
		enterdoor.lower();
		setbtnEnterCarParkv(false);
		if (carPark.hasAvailableSpaces())
			setbtnCarArrivesv(true);
		else
			full.setstate("True");
		if (EM_ASM_INT_V({
			if (btnEnterCoin.Visible)
				return 1;
			else
				return 0;
		}) == 0 && EM_ASM_INT_V({
			if (btnExitCarPark.Visible)
			return 1;
			else
				return 0;
		}) == 0)
			setbtnCarArrivesAtExitv(true);

		UpdateDisplay();
	}

	void btnCarArrivesAtExit_Click()
	{
		string displayMessage = "Please enter coin";

		// TO BE COMPLETED BY YOU
		machine.setmessage(displayMessage);
		setbtnCarArrivesAtExitv(false);
		setbtnEnterCoinv(true);
		setbtnInsertCoinv(true);
		UpdateDisplay();
	}

	void btnEnterCoin_Click()
	{
		// TO BE COMPLETED BY YOU
		int number = 0;//improve
		cin >> number;
		machine.entercoin(CollectedCoins[number]);
		if (machine.haspayed(number))
		{
			exitindex = number;
			exitdoor.raise();
			machine.clearmessage();
			setbtnEnterCoinv(false);
			setbtnExitCarParkv(true);
		}
		else
		{
			setbtnEnterCoinv(false);
			setbtnCarArrivesAtExitv(true);
			machine.setmessage("Please pay for your stay");// TODO: should the payment machine display this
		}
		UpdateDisplay();
	}

	void btnExitCarPark_Click()
	{
		// TO BE COMPLETED BY YOU
		machine.carexits(exitindex);
		carPark.decroment();
		CollectedCoins.erase(CollectedCoins.begin() + exitindex);
		setbtnExitCarParkv(false);
		if (carPark.getAvailableSpace() != carPark.getTotalSpace())
			setbtnCarArrivesAtExitv(true);
		if (carPark.hasAvailableSpaces() && EM_ASM_INT("btnPressForCoin.Visible") == 0 && EM_ASM_INT("btnEnterCarPark.Visible") == 0)
			setbtnCarArrivesv(true);
		if (carPark.getAvailableSpace() == carPark.getTotalSpace())
			setbtnInsertCoinv(false);

		UpdateDisplay();
	}

	void UpdateDisplay()
	{
		setfulltext(full.getstate().c_str());// "full" or "avalible"
		setAvailableCoinsText(to_string(machine.getnumberofcoins()).c_str());  // coins avalible to give
		setAvailableSpacesText(to_string(carPark.getAvailableSpace()).c_str()); // a number between the the size of the car park and 0
		setEntryBarrierText(enterdoor.getstate().c_str());    // am i up or down
		setExitBarrierTextp(exitdoor.getstate().c_str()); // am i up or down
		setCoinMachineText(machine.getmessage().c_str());
		setPaymentDisplayText(paymachine.getrequiredbalence().c_str());
		UpdateCoinsDisplay();
	}

	// This procedure updates the listbox that contains coins collected by drivers after entering the car park
	void UpdateCoinsDisplay()
	{
		
		for(coin it : CollectedCoins)
		{
			cout << "Coin " << it.getid() << endl;
		}
	}

	void btnInsertCoin_Click()
	{
		int number = 0; //improve
		cin >> number;
		paymachine.insertcoin(CollectedCoins[number]);
		paymachine.setcoinid(number);
		UpdateDisplay();
		setbtnCalculateValuev(true);
	}

	void btnInsert1Pound_Click()
	{
		paymachine.insert1pound();
		cangetcoin();
		UpdateDisplay();
	}

	void btnInsert5p_Click()
	{
		paymachine.insert5p();
		cangetcoin();
		UpdateDisplay();
	}

	void btnInsert10p_Click()
	{
		paymachine.insert10p();
		cangetcoin();
		UpdateDisplay();
	}
	void cangetcoin()
	{
		if (paymachine.haspayedinfull())
			setbtnRequestCoinv(true);
	}

	void btnCalculateValue_Click()
	{
		paymachine.calculatevalue();
		UpdateDisplay();
		setbtnInsert1pv(true);
		setbtnInsert2pv(true);
		setbtnInsert5pv(true);
		setbtnInsert10pv(true);
		setbtnInsert20pv(true);
		setbtnInsert50pv(true);
		setbtnInsert1Poundv(true);
		setbtnInsert2Poundv(true);
	}

	void btnRequestCoin_Click()
	{
		if (paymachine.haspayedinfull())
		{
			CollectedCoins[paymachine.getcoinid()] = paymachine.returncoin();
			setbtnInsert1pv(false);
			setbtnInsert2pv(false);
			setbtnInsert5pv(false);
			setbtnInsert10pv(false);
			setbtnInsert20pv(false);
			setbtnInsert50pv(false);
			setbtnInsert1Poundv(false);
			setbtnInsert2Poundv(false);
			setbtnCalculateValuev(false);
			setbtnRequestCoinv(false);
		}
	}

	void btnInsert20p_Click()
	{
		paymachine.insert20p();
		cangetcoin();
		UpdateDisplay();
	}

	void btnInsert1p_Click()
	{
		paymachine.insert1p();
		cangetcoin();
		UpdateDisplay();
	}

	void btnInsert2p_Click()
	{
		paymachine.insert2p();
		cangetcoin();
		UpdateDisplay();
	}

	void btnInsert50p_Click()
	{
		paymachine.insert50p();
		cangetcoin();
		UpdateDisplay();
	}

	void btnInsert2Pound_Click()
	{
		paymachine.insert2pound();
		cangetcoin();
		UpdateDisplay();
	}
};
