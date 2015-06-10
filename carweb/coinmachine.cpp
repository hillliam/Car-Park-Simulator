#include "coinmachine.h"

coinmachine::coinmachine()
{
}


coinmachine::~coinmachine()
{
}

void coinmachine::entercoin(coin item)
{

}
void coinmachine::cararives()
{ //give user a coin
	coines.push_back(new coin(coines.size()));
}
void coinmachine::carexits()
{// remove users coin
	coines.pop_back();
}
void coinmachine::carexits(int index)
{// remove users coin
	coines.erase(coines.begin() + index);
}
coin coinmachine::presscoin()
{// give ref of coin to ui?
	return coines[coines.size() - 1];
}
int coinmachine::getnumberofcoins()
{
	return 10 - coines.size();
}
string coinmachine::getmessage()
{
	return message;
}
void coinmachine::setmessage(string newmessage)
{
	message = newmessage;
}
void coinmachine::clearmessage()
{
	message = "";
}
bool coinmachine::haspayed()
{
	if (coines[coines.size() - 1].getstate() != "Unpaid")
		return true;
	else
		return false;
}
bool coinmachine::haspayed(int index)
{
	if (coines[index].getstate() != "Unpaid")
		return true;
	else
		return false;
}