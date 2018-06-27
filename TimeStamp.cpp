#include "stdafx.h"
#include "TimeStamp.h"

using namespace std;
TimeStamp::TimeStamp()
{}
TimeStamp::TimeStamp(double maxQuarter, int delay) : m_maxQuarter(maxQuarter), m_delay(delay)
{
	validParser;
}
void TimeStamp::GetDataTimeStamp(double maxQuarter, int delay)
{
	m_maxQuarter = maxQuarter;
	m_delay = delay;
	TimeStampTab.push_back(new TimeStamp(m_maxQuarter, m_delay));
	//vector<TimeStamp*>::iterator it;
}