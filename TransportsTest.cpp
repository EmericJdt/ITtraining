#include "stdafx.h"
#include "Transports.h"
#include <vector>

using namespace std;

Transports::Transports(std::string type, double costs): m_transportType(type), m_costs(costs)
{
	TransportsTab.push_back(new Transports(m_transportType, m_costs));
	validParser;
	//vector<Transports*>::iterator it;
}

void Transports::validParser(std::string type, double costs)
{
	Transports TransportsTesting("maritime", 49.99);
	if (TransportsTab.begin == TransportsTesting)
		cout << "OK" << endl;
	else
		cout << "ERROR" << endl;
}