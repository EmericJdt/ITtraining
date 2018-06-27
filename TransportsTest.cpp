#include "stdafx.h"
#include "Transports.h"
#include <vector>

using namespace std;
void Transports::validParser(std::string type, double costs, int delay)
{
	Transports TransportsTesting(m_transportType, m_transportCosts, m_transportDelay);
	if (TransportsTab.begin == TransportsTesting)
		cout << "OK" << endl;
	else
		cout << "ERROR" << endl;
}

