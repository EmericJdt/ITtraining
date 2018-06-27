#include "stdafx.h"
#include "Transports.h"

using namespace std;
Transports::Transports()
{}
Transports::Transports(std::string type, double costs, int delay) : m_transportType(type), m_transportCosts(costs), m_transportDelay(delay)
{
	validParser;
}
void Transports::GetDataTransport(std::string transportType, double transportCosts, int transportDelay)
{
	m_transportType = transportType;
	m_transportCosts = transportCosts;
	m_transportDelay = transportDelay;
	TransportsTab.push_back(new Transports(m_transportType, m_transportCosts, m_transportDelay));
	//vector<Transports*>::iterator it;
}