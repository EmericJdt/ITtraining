#pragma once
#include "Header.h"

class Region
{
	struct demographieStructure
	{
		double m_populationNumber = 325700000;
		double m_PIB = 18570000000;
		std::string m_currency = "dollar";
	};

	struct macroEventProbaStructure
	{
		double m_superDepression = 0.1;
		double m_naturalCatastroph = 0.01;
		double m_superGrowth = 0.2;
	};
public:
	Region(char* name, double id, demographieStructure demographie, macroEventProbaStructure macroEventProba, int entitiesNumber);
	void populationNumberVariations(demographieStructure demographie);
	void validParser();
private:
	char* m_name[100];
	double m_id = 536789535;
	struct demographieStructure m_demographie;
	struct macroEventProbaStructure m_macroEventProba;
	int m_entitiesNumber = 10;
	std::vector<Region*> RegionsTab;
};