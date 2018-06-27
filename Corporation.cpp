#include "stdafx.h"
#include "Corporation.h"

using namespace std;
mainAccount::mainAccount()
{}
mainAccount::mainAccount(double amount, char currency, double fees) : m_amount(amount), m_currency(currency), m_fees(fees)
{}
void mainAccount::GetDataMainAccount(double amount, char currency, double fees)
{
	m_amount = amount;
	m_currency = currency;
	m_fees = fees;
	mainAccountTab.push_back(new mainAccount(m_amount, m_currency, m_fees));
}

Corporation::Corporation()
{}
Corporation::Corporation(int id, string name, int technologiesNumber, 
	int entitiesNumber, int shopsNumber, int RDCentersNumber, int factoriesNumber) :
	_id(id), m_name(name), m_technologiesNumber(technologiesNumber), m_entitiesNumber(entitiesNumber), 
	m_shopsNumber(shopsNumber), m_RDCentersNumber(RDCentersNumber), m_factoriesNumber(factoriesNumber)
{}
void Corporation::GetDataCorporation(int id, string name, int technologiesNumber, int entitiesNumber, int shopsNumber, int RDCentersNumber, int factoriesNumber)
{
	_id = id;
	m_name = name;
	m_technologiesNumber = technologiesNumber;
	m_entitiesNumber = entitiesNumber;
	m_shopsNumber = shopsNumber;
	m_RDCentersNumber = RDCentersNumber;
	m_factoriesNumber = factoriesNumber;
	CorporationsTab.push_back(new Corporation(_id, m_name, m_technologiesNumber, m_entitiesNumber, m_shopsNumber,
		m_RDCentersNumber, m_factoriesNumber));
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

Shop::Shop()
{}
Shop::Shop(double price, int id, std::string location, double maxCapacity) : m_shopPrice(price), m_shopID(id), m_shopLocation(location), m_shopMaxCapacity(maxCapacity)
{}
void Shop::GetDataShop(double price, int id, std::string location, double maxCapacity)
{
	m_shopPrice = price;
	m_shopID = id;
	m_shopLocation = location;
	m_shopMaxCapacity = maxCapacity;
	ShopsTab.push_back(new Shop(m_shopPrice, m_shopID, m_shopLocation, m_shopMaxCapacity));
}
void Shop::addShop()
{
	if (m_amount > m_shopPrice*m_shopsNumber)
		for (int i = 0; i < m_shopsNumber; i++)
			GetDataShop;
}

RDCenter::RDCenter()
{}
RDCenter::RDCenter(int id, double price, int delay) : m_RDCenterID(id), m_RDCenterPrice(price), m_delay(delay)
{}
void RDCenter::GetDataRDCenter(int id, double price, int delay)
{
	m_RDCenterID = id;
	m_RDCenterPrice = price;
	m_delay = delay;
	RDCentersTab.push_back(new RDCenter(m_RDCenterID, m_RDCenterPrice, m_funds, m_delay));
}
void RDCenter::addRDCenter()
{
	if (m_amount > m_RDCenterPrice*m_RDCentersNumber)
		for (int y = 0; y < m_RDCentersNumber; y++)
			GetDataRDCenter;
}

Factory::Factory()
{}
Factory::Factory(int id, double price, double maxCapacity, double effeciency): m_factoryID(id), m_factoryPrice(price), m_factoryMaxCapacity(maxCapacity), m_effeciency(effeciency)
{}
void Factory::GetDataFactory(int id, double price, double maxCapacity, double effeciency)
{
	m_factoryID = id;
	m_factoryPrice = price;
	m_factoryMaxCapacity = maxCapacity;
	m_effeciency = effeciency;
	FactoriesTab.push_back(new Factory(m_factoryID, m_factoryPrice, m_factoryMaxCapacity, m_effeciency));
}
void Factory::addFactory()
{
	if (m_amount > m_factoryPrice*m_factoriesNumber)
		for (int y = 0; y < m_factoriesNumber; y++)
			GetDataFactory;
		
}

Transaction::Transaction()
{}
Transaction::Transaction(transactions transaction): m_transaction(transaction)
{}
void Transaction::GetDataTransaction(transactions transaction)
{
	m_transaction.fees = transaction.fees;
	m_transaction.wording = transaction.wording;
	m_transaction.senderName = transaction.senderName;
	m_transaction.recipientName = transaction.recipientName;
	TransactionsTab.push_back(new Transaction(m_transaction));
}

