#include "stdafx.h"
#include "Corporation.h"

using namespace std;
void Corporation::validParser()
{
	Corporation CorporationTesting(_id, m_name, m_technologiesNumber, m_entitiesNumber, m_shopsNumber, 
		m_RDCentersNumber, m_factoriesNumber);

	if (CorporationsTab.begin == CorporationTesting)
		cout << "OK" << endl;
	else
		cout << "ERROR" << endl;
}


