#pragma once
#include "coin.h"
#include <vector>
#include <string>

using namespace std;

class coinmachine
{
private:
	vector<coin> coines;
	string message;
public:
	coinmachine();
	~coinmachine();
	void entercoin(coin item);
	void cararives();
	void carexits();
	void carexits(int index);
	coin presscoin();
	int getnumberofcoins();
	string getmessage();
	void setmessage(string newmessage);
	void clearmessage();
	bool haspayed();
	bool haspayed(int index);
};

