#pragma once
#include "coin.h"

using namespace std;

class payment
{
private:
	coin insertedcoin;
	int coinid;
	double requiredmoney;
	void calculateAmountRemaining(double coinInserted);
public:
	payment() : insertedcoin(-1){};
	~payment();
	void setcoinid(int id);
	int getcoinid();
	void insertcoin(coin coin);
	coin returncoin();
	void calculatevalue();
	string getrequiredbalence();
	void insert1p();
	void insert2p();
	void insert5p();
	void insert10p();
	void insert20p();
	void insert50p();
	void insert1pound();
	void insert2pound();
	bool haspayedinfull();
};

