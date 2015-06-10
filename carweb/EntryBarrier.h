#pragma once
#include <string>
#include <iostream>

using namespace std;

class EntryBarrier
{
private:
	string state;
public:
	EntryBarrier();
	~EntryBarrier();
	void lower();
	void raise();
	string getstate();
};

