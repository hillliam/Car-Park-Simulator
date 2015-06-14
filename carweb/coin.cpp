#include "coin.h"


coin::coin(int setid)
{
	state = "Unpaid";
	id = setid;
	time_t now = time(0);
	struct tm& newt = *localtime(&now);
	stime.year = newt.tm_year;
	stime.mounth = newt.tm_mon;
	stime.day = newt.tm_mday;
	stime.hour = newt.tm_hour;
	stime.min = newt.tm_min;
	stime.second = newt.tm_sec;
}


coin::~coin()
{
}

void coin::setstate(string newstate)
{
	state = newstate;
}

string coin::getstate()
{
	return state;
}

timediff coin::getstayedtime()
{
	time_t now = time(0);
	struct tm& newt = *localtime(&now);
	timediff diff;
	diff.year = newt.tm_year - stime.year;
	diff.mounth = newt.tm_mon - stime.mounth;
	diff.day = newt.tm_mday - stime.day;
	diff.hour = newt.tm_hour - stime.hour;
	diff.min = newt.tm_min - stime.min;
	diff.second = newt.tm_sec - stime.second;
	return diff;
}

int coin::getid()
{
	return id;
}

struct tm& coin::getcurrenttime()
{
	time_t now = time(0);
	return *localtime(&now);
}
