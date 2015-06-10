#pragma once
#include <string>
#include <iostream>
#include <sys/types.h>
#include <sys/timeb.h>
#include <ctime>

using namespace std;

struct timediff
{
	int year;
	int mounth;
	int day;
	int hour;
	int min;
	int second;
};

class coin
{
private:
	string state;
	struct tm& t;
	int id;
	struct tm& getcurrenttime();
public:
	coin(int setid);
	~coin();
	void setstate(string newstate);
	string getstate();
	timediff getstayedtime();
	int getid();
};

