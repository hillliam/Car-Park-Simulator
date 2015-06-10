#include "EntryBarrier.h"


EntryBarrier::EntryBarrier()
{
	state = "LOWERED";
}

EntryBarrier::~EntryBarrier()
{
}

void EntryBarrier::lower()
{
	state = "LOWERED";
}

void EntryBarrier::raise()
{
	state = "RAISED";
}

string EntryBarrier::getstate()
{
	return state;
}