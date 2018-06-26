#include "stdafx.h"
#include "Region.h"

using namespace std;


Region::Region(char* name, double id, demographieStructure demographie, macroEventProbaStructure macroEventProba, int entitiesNumber): m_name(name), m_id(id), m_demographie(demographie), m_macroEventProba(macroEventProba)
{
	fgets(*m_name, 100, stdin);
	RegionsTab.push_back(new Region(*m_name, m_id, m_demographie, m_macroEventProba, m_entitiesNumber));
	validParser;
	//vector<Regions*>::iterator it;
}

void Region::populationNumberVariations(demographieStructure demographie)
{
	m_demographie.m_populationNumber += (m_demographie.m_populationNumber*1.0001);
}


void Region::validParser()
{
	demographieStructure demographieStructureTestingVector;
	demographieStructureTestingVector.m_populationNumber = 325700000;
	demographieStructureTestingVector.m_PIB = 18570000000;
	demographieStructureTestingVector.m_currency = "dollar";
	macroEventProbaStructure macroEventProbaTestingVector;
	macroEventProbaTestingVector.m_superDepression = 0.1;
	macroEventProbaTestingVector.m_naturalCatastroph = 0.01;
	macroEventProbaTestingVector.m_superGrowth = 0.2;
	Region RegionTesting(*m_name, 536789535, demographieStructureTestingVector, macroEventProbaTestingVector, 10);

	if (RegionsTab.begin == RegionTesting)
		cout << "OK" << endl;
	else
		cout << "ERROR" << endl;
}