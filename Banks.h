#pragma once
#include "Header.h"

class Banks
{
	struct borrow
	{
		double m_fees;
		double m_amount;
		double m_repaymentDelay;
		double m_repaymentDelayed;
	};
public:
	Banks();
	Banks(double amount, std::string currency);
	void validParser();
	void GetDataBanks(double amount, std::string currency);
private:
	double m_amount;
	std::string m_currency;
	std::vector<Banks*> BanksTab;
};