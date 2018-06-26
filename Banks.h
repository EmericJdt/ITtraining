#pragma once
#include "Header.h"

class Banks
{
	struct mainAccountStructure
	{
		double m_amount = 10500;
		std::string m_currency = "dollar";
		double m_fees = 0.05;
	};

public:
	Banks(mainAccountStructure mainAccount);
	void validParser();

private:
	struct mainAccountStructure m_mainAccount;
	std::vector<Banks*> BanksTab;
};