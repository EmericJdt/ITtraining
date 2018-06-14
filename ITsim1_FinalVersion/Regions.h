#pragma once
#include "Header.h"

typedef demographieStructure demographieStructure;
struct demographieStructure
{
	double populationNumber;
	double PIB;
	double currency;
};

typedef macroEventProbaStructure macroEventProbaStructure;
struct macroEventProbaStructure
{
	double superDepression;
	double naturalCatastroph;
	double superGrowth;
};

class Regions
{
public:
	
private:
	std::string m_name;
	double IDnumber;
	demographieStructure demographie;
	macroEventProbaStructure macroEventProba;
	int entitiesNumberPerRegion;
};