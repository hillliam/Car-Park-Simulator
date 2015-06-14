#include "payment.h"

payment::~payment()
{
}

void payment::setcoinid(int id)
{
	coinid = id;
}
int payment::getcoinid()
{
	return coinid;
}
void payment::insertcoin(coin coin)
{
	insertedcoin = coin;
}
coin payment::returncoin()
{
	return insertedcoin;
}
void payment::calculatevalue()
{
	requiredmoney = insertedcoin.getstayedtime().second;
}
string payment::getrequiredbalence()
{
	return to_string(requiredmoney);
}
void payment::insert1p()
{
	calculateAmountRemaining(0.01);
}
void payment::insert2p()
{
	calculateAmountRemaining(0.02);
}
void payment::insert5p()
{
	calculateAmountRemaining(0.05);
}
void payment::insert10p()
{
	calculateAmountRemaining(0.1);
}
void payment::insert20p()
{
	calculateAmountRemaining(0.2);
}
void payment::insert50p()
{
	calculateAmountRemaining(0.5);
}
void payment::insert1pound()
{
	calculateAmountRemaining(1);
}
void payment::insert2pound()
{
	calculateAmountRemaining(2);
}
bool payment::haspayedinfull()
{
	if (requiredmoney <= 0)
	{
		insertedcoin.setstate("payed");
		return true;
	}
	else
		return false;
}

void payment::calculateAmountRemaining(double coinInserted)
{
	if ((requiredmoney - coinInserted) >= 0)
		requiredmoney -= coinInserted;
	else
		requiredmoney = 0;
}