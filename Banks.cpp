#include "stdafx.h"
#include "Banks.h"

using namespace std;
Banks::Banks()
{}
Banks::Banks(double amount, string currency) : m_amount(amount), m_currency(currency)
{
	validParser;
}
void Banks::GetDataBanks(double amount, std::string currency)
{
	m_amount = amount;
	m_currency = currency;
	BanksTab.push_back(new Banks(m_amount, m_currency));
	//vector<Banks*>::iterator it;
}