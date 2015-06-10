#pragma once

class carpark
{
private:
	int spaces;
	int maxspaces;
public:
	carpark(int numspace);
	~carpark();
	bool hasAvailableSpaces();
	int getAvailableSpace();
	int getTotalSpace();
	bool isfull();
	void increment();
	void decroment();
};

