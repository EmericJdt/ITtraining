#include "stdafx.h"
#include "Header.h"
using namespace std;



region::region()
{
}

region::region(string nameRegion):m_NameRegion(nameRegion)
{
}

void region::whatRegion(int nameRegion)
{
	switch (nameRegion)
	{
	case 1:
		m_NameRegion = "USA";
		m_NumberPopulation = 325;
		m_MarketSize = 300;
		break;
	case 2:
		m_NameRegion = "Mexique";
		m_NumberPopulation = 127;
		m_MarketSize = 125;
		break;
	case 3:
		m_NameRegion = "France";
		m_NumberPopulation = 77;
		m_MarketSize = 86;
		break;
	case 4:
		m_NameRegion = "Russie";
		m_NumberPopulation = 147;
		m_MarketSize = 97;
		break;
	case 5:
		m_NameRegion = "Chine";
		m_NumberPopulation = 1400;
		m_MarketSize = 278;
		break;
	case 6:
		m_NameRegion = "Japon";
		m_NumberPopulation = 126;
		m_MarketSize = 60;
		break;
	case 7:
		m_NameRegion = "Inde";
		m_NumberPopulation = 1340;
		m_MarketSize = 142;
		break;
	default:
		break;
	}

	cout << endl << "perfect" << endl << "You've juste choose "<<m_NameRegion <<". This region had "<<m_NumberPopulation<<" million of habitants. "<< endl;
	cout << "The Region can receive " << m_MarketSize << " corporation on this area" << endl;
}

void region::whatRegion()
{
}

region::~region()
{
}
