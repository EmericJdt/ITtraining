#include "stdafx.h"
#include "Region.h"

using namespace std;
void Region::validParser()
{
	demographieStructure demographieStructureTestingVector;
	macroEventProbaStructure macroEventProbaTestingVector;
	Region RegionTesting(m_name, m_id, demographieStructureTestingVector, macroEventProbaTestingVector, 10);
	if (RegionsTab.begin == RegionTesting)
		cout << "OK" << endl;
	else
		cout << "ERROR" << endl;
}