#include "stdafx.h"
#include "TimeStamp.h"

using namespace std;
void TimeStamp::validParser(double maxQuarter, int delay)
{
	TimeStamp TimeStampTesting(m_maxQuarter, m_delay);
	if (TimeStampTab.begin == TimeStampTesting)
		cout << "OK" << endl;
	else
		cout << "ERROR" << endl;
}
