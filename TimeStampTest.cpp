#include "stdafx.h"
#include "TimeStamp.h"
#include <vector>

using namespace std;

TimeStamp::TimeStamp(double maxQuarter, int delay) : m_maxQuarter(maxQuarter), m_delay(delay)
{
	TimeStampTab.push_back(new TimeStamp(m_maxQuarter, m_delay));

	validParser;
	//vector<TimeStamp*>::iterator it;
}

void TimeStamp::validParser(double maxQuarter, int delay)
{
	TimeStamp TimeStampTesting(10.5, 1);
	if (TimeStampTab.begin == TimeStampTesting)
		cout << "OK" << endl;
	else
		cout << "ERROR" << endl;
}
