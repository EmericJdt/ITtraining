#include "stdafx.h"
#include "Banks.h"

using namespace std;
void Banks::validParser()
{
	Banks BanksTesting(m_amount, m_currency);
	if (BanksTab.begin == BanksTesting)
		cout << "OK" << endl;
	else
		cout << "ERROR" << endl;
}


