#pragma once
#include "Header.h"

class Transports
{
public:
	Transports();
	Transports(std::string transportType, double transportCosts, int transportDelay);
	void validParser(std::string type, double costs, int delay);
	void GetDataTransport(std::string transportType, double transportCosts, int transportDelay);
private:
	std::string m_transportType;
	double m_transportCosts;
	int m_transportDelay;
	std::vector<Transports*> TransportsTab;

};