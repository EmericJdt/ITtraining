#pragma once
#include "Header.h"

class Corporations
{
public:
	Corporations(std::string name);
	void Show();

protected:
	std::string m_name;
	int m_technologies_number = 0;
	std::vector<std::string> m_technologiesList;
	double m_mainAccount = 500000;
	int m_entities = 0;
	int m_shops = 0;
	int m_RDCentersNumber = 0;
	int m_factoriesNumber = 0;
};