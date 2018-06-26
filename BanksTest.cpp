#include "stdafx.h"
#include "Banks.h"

using namespace std;

Banks::Banks(mainAccountStructure mainAccount) : m_mainAccount(mainAccount)
{
	BanksTab.push_back(new Banks(m_mainAccount));
	validParser;
	//vector<Banks*>::iterator it;
}

void Banks::validParser()
{
	mainAccountStructure mainAccountTestingVector;
	mainAccountTestingVector.m_amount = 10500;
	mainAccountTestingVector.m_currency = "dollar";
	mainAccountTestingVector.m_fees = 0.05;
	Banks BanksTesting(mainAccountTestingVector);

	if (BanksTab.begin == BanksTesting)
		cout << "OK" << endl;
	else
		cout << "ERROR" << endl;
}