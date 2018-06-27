#pragma once
#include "Header.h"

class Region
{
	struct demographieStructure
	{
		double populationNumber;
		double PIB;
		std::string currency;
	};
	struct macroEventProbaStructure
	{
		double superDepression;
		double naturalCatastroph;
		double superGrowth;
	};
public:
	Region();
	Region(std::string name, double id, demographieStructure demographie, macroEventProbaStructure macroEventProba, int entitiesNumber);
	void populationNumberVariations(demographieStructure demographie);
	void validParser();
	void GetDataRegion(std::string name, double id, demographieStructure demographie, 
		macroEventProbaStructure macroEventProba, int entitiesNumber);
private:
	std::string m_name;
	double m_id;
	struct demographieStructure m_demographie;
	struct macroEventProbaStructure m_macroEventProba;
	int m_entitiesNumber;
	std::vector<Region*> RegionsTab;
};