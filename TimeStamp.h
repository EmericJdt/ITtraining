#pragma once
#include "Header.h"
#include <vector>

class TimeStamp
{
public:
	TimeStamp();
	TimeStamp(double maxQuarter, int delay);
	void validParser(double maxQuarter, int delay);
	void GetDataTimeStamp(double maxQuarter, int delay);
private:
	double m_maxQuarter = 10.5;
	int m_delay = 1;
	std::vector<TimeStamp*> TimeStampTab;
};