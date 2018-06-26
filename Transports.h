#pragma once
#include "Header.h"

class Transports
{
public:
	Transports(std::string type, double costs);
	void validParser(std::string type, double costs);

private:
	std::string m_transportType = "maritime";
	double m_costs = 49.99;
	std::vector<Transports*> TransportsTab;

};