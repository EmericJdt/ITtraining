#include "stdafx.h"
#include "Corporation.h"

using namespace std;

Corporation::Corporation()
{}

Corporation::Corporation(int id, char*, int technologiesNumber, vector<std::string> technologiesList,
	double mainAccount, int entities, int shopsNumber, int RDCentersNumber, int factoriesNumber) :
	_id(id), m_name(), m_technologiesNumber(technologiesNumber), m_technologiesList(technologiesList),
	m_mainAccount(mainAccount), m_entities(entities), m_shopsNumber(shopsNumber),
	m_RDCentersNumber(RDCentersNumber), m_factoriesNumber(factoriesNumber)
{
	char* number;
	fgets(number, 3, stdin); // récupération sécurisée de _id
	char b = *number; // convertion d'un char* en char pour pouvoir l'affecter a _id 
	_id = b - 48; // Sachant que 0 est codé 48

	fgets(*m_name, 100, stdin); // récupération sécurisée de m_name

	// Concernant le mainAccount Il me faut une fonction securisee pour recuperer un double

	char* number;
	fgets(number, 1, stdin); // récupération sécurisée du nombre de shops à ajouter
	char d = *number; // convertion d'un char* en char pour pouvoir l'affecter a m_shopsNumber
	m_shopsNumber = d - 48; // Sachant que 0 est codé 48

	char* number;
	fgets(number, 1, stdin); // récupération sécurisée du nombre de RDCenters à ajouter
	char f = *number; // convertion d'un char* en char pour pouvoir l'affecter a m_shopsNumber
	m_shopsNumber = f - 48; // Sachant que 0 est codé 48

	CorporationsTab.push_back(new Corporation(_id, *m_name, m_technologiesNumber, m_technologiesList,
		m_mainAccount, m_entities, m_shopsNumber, m_RDCentersNumber, m_factoriesNumber));

	//vector<Corporations*>::iterator it;

}

void Corporation::Show()
{
	cout << "You have created your own Corporation, your are the Corporation " << _id << "and your bases datas are : " << endl;
	cout << "Name : " << m_name << endl << "Technologies list : " << m_technologiesNumber << endl;
	cout << "Number of your created shop(s) : " << m_shopsNumber << endl << "Start amount of your account : " << m_mainAccount << endl;
	cout << "Number of your acting Research and Develop Center(s) : " << m_RDCentersNumber << endl;
	cout << "Number of your acting factory(ies) : " << m_factoriesNumber << endl;
}

mainAccount::mainAccount()
{}

mainAccount::mainAccount(double amount, char*, double fees) : m_amount(amount), m_currency(), m_fees(fees)
{
	// Il me faut une fonction securisee qui recupere le double m_amount
	m_mainAccount = m_amount;
	fgets(*m_currency, 1, stdin); // Recuperation securisee de la devise
	// Il me faut une fonction securisee qui recupere le double m_fees
	m_mainAccount -= m_mainAccount*m_fees;
}

Shop::Shop()
{}
Shop::Shop(int id, char*, double maxCapacity) : m_shopID(id), m_location(), m_shopMaxCapacity(maxCapacity)
{}
void Shop::addShop()
{
	if (m_mainAccount > m_shopPrice*m_shopsNumber)
	{
		for (int i = 0; i < m_shopsNumber; i++)
		{
			m_shopID = i;
			m_mainAccount -= m_shopPrice;
			fgets(*m_location, 100, stdin);
			// Il me faut une fonction securisee qui recupere le double m_maxCapacity
			ShopsTab.push_back(new Shop(m_shopID, *m_location, m_shopMaxCapacity));
		}
	}
}

RDCenter::RDCenter()
{}
RDCenter::RDCenter(int id, double price, double funds, int delay) : m_RDCenterID(id), m_RDCenterPrice(price), m_funds(funds), m_delay(delay)
{}

void RDCenter::addRDCenter()
{
	if (m_mainAccount > m_RDCenterPrice*m_RDCentersNumber)
	{
		for (int y = 0; y < m_RDCentersNumber; y++)
		{
			m_RDCenterID = y;
			m_mainAccount -= m_RDCenterPrice;
			// Il me faut une fonction securisee qui recupere le double m_funds
			char* delay;
			fgets(delay, 1, stdin); // récupération sécurisée du nombre de RDCenters à ajouter
			char f = *delay; // convertion d'un char* en char pour pouvoir l'affecter a m_shopsNumber
			m_delay = f - 48; // Sachant que 0 est codé 48

			RDCentersTab.push_back(new RDCenter(m_RDCenterID, m_RDCenterPrice, m_funds, m_delay));
		}
	}
}

Factory::Factory()
{}
Factory::Factory(int id, double price, double maxCapacity, double effeciency): m_factoryID(id), m_factoryPrice(price), m_factoryMaxCapacity(maxCapacity), m_effeciency(effeciency)
{}

void Factory::addFactory()
{
	if (m_mainAccount > m_factoryPrice*m_factoriesNumber)
	{
		for (int y = 0; y < m_factoriesNumber; y++)
		{
			m_factoryID = y;
			// Il me faut une fonction securisee qui recupere le double m_factoryPrice
			m_mainAccount -= m_factoryPrice;
			// Il me faut une fonction securisee qui recupere le double m_factoryMaxCapacity
			// Il me faut une fonction securisee qui recupere le double m_effeciency
			FactoriesTab.push_back(new Factory(m_factoryID, m_factoryPrice, m_factoryMaxCapacity, m_effeciency));
		}
	}
}





