#pragma once
#include "stdafx.h"
#include <string>
#include <iostream>


class region
{
public:
	region();
	region(std::string nameRegion);
	void whatRegion(int nameRegion);
	void whatRegion();
	~region();

private:
	std::string m_NameRegion;
	int m_NumberPopulation;
	double m_EconomyPotential;
	double m_MarketMaturity;
	int m_MarketSize;
	double m_DevelopmentFactor;
};
