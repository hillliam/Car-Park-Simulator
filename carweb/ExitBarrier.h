#pragma once
#include <string>
#include <iostream>

using namespace std;

class ExitBarrier
{
private:
	string state;
public:
	ExitBarrier();
	~ExitBarrier();
	void lower();
	void raise();
	string getstate();
};

