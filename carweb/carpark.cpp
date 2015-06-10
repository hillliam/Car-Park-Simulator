#include "carpark.h"


carpark::carpark(int numspace)
{
	maxspaces = numspace;
}

carpark::~carpark()
{

}

bool carpark::hasAvailableSpaces()
{
    return (spaces == maxspaces ? false : true); // TODO: understand me
}

int carpark::getAvailableSpace()
{
    return maxspaces - spaces; // TODO: understand me
}

int carpark::getTotalSpace()
{
    return maxspaces; // TODO: understand me
}
bool carpark::isfull()
{
    return (spaces == maxspaces ? true : false);
}
void carpark::increment()
{
    spaces++;
}
void carpark::decroment()
{
    spaces--;
}