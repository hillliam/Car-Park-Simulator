#include "ExitBarrier.h"


ExitBarrier::ExitBarrier()
{
	state = "LOWERED";
}


ExitBarrier::~ExitBarrier()
{
}

void ExitBarrier::lower()
{
	state = "LOWERED";
}
void ExitBarrier::raise()
{
	state = "RAISED";
}
string ExitBarrier::getstate()
{
	return state;
}