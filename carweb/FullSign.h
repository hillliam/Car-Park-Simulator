#pragma once
#include <string>
#include <iostream>

using namespace std;

class FullSign
{
private:
	string state;
public:
	FullSign();
	~FullSign();
	string getstate();
	void setstate(string newstate);
};

