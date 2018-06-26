#include "stdafx.h"
#include "Corporation.h"

using namespace std;

void Corporation::validParser()
{
	Corporation CorporationTesting(_id, *m_name, 0, m_technologiesList, 500000, 0, 0, 0, 0);

	if (CorporationsTab.begin == CorporationTesting)
		cout << "OK" << endl;
	else
		cout << "ERROR" << endl;
}