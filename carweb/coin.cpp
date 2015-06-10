#include "coin.h"


coin::coin(int setid)
{
	state = "Unpaid";
	time_t now = time(0);
	t = *localtime(&now);
	id = setid;
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
	diff.year = newt.tm_year - t.tm_year;
	diff.mounth = newt.tm_mon - t.tm_mon;
	diff.day = newt.tm_mday - t.tm_mday;
	diff.hour = newt.tm_hour - t.tm_hour;
	diff.min = newt.tm_min - t.tm_min;
	diff.second = newt.tm_sec - t.tm_sec;
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
