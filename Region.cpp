#include "stdafx.h"
#include "Region.h"

using namespace std;
Region::Region()
{}
Region::Region(string name, double id, demographieStructure demographie, macroEventProbaStructure macroEventProba, int entitiesNumber) : m_name(name), m_id(id), m_demographie(demographie), m_macroEventProba(macroEventProba)
{
	validParser;
}
void Region::populationNumberVariations(demographieStructure demographie)
{
	m_demographie.populationNumber += (m_demographie.populationNumber*1.0001);
}
void Region::GetDataRegion(std::string name, double id, demographieStructure demographie, macroEventProbaStructure macroEventProba, int entitiesNumber)
{
	m_name = name;
	m_id = id;
	m_demographie.populationNumber = demographie.populationNumber;
	m_demographie.PIB = demographie.PIB;
	m_demographie.currency = demographie.currency;
	m_macroEventProba.superDepression = macroEventProba.superDepression;
	m_macroEventProba.naturalCatastroph = macroEventProba.naturalCatastroph;
	m_macroEventProba.superGrowth = macroEventProba.superGrowth;
	m_entitiesNumber = entitiesNumber;
	RegionsTab.push_back(new Region(m_name, m_id, m_demographie, m_macroEventProba, m_entitiesNumber));
	//vector<Regions*>::iterator it;
}