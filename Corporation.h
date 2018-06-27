#pragma once
#include "Header.h"

class mainAccount
{
public:
	mainAccount();
	mainAccount(double amount, char currency, double fees);
	void GetDataMainAccount(double amount, char currency, double fees);
protected:
	double m_amount;
	char m_currency;
	double m_fees;
	std::vector<mainAccount*> mainAccountTab;
};

class Corporation : public mainAccount
{
public:
	Corporation();
	Corporation(int id, std::string name, int technologiesNumber, 
		int entitiesNumber, int shopsNumber, int RDCentersNumber, int factoriesNumber);
	void Show();
	void validParser();
	void GetDataCorporation(int id, std::string name, int technologiesNumber, int entitiesNumber, int shopsNumber, 
		int RDCentersNumber, int factoriesNumber);
protected:
	int _id;
	std::string m_name;
	int m_technologiesNumber;
	int m_entitiesNumber;
	int m_shopsNumber; 
	int m_RDCentersNumber;
	int m_factoriesNumber;
	std::vector<Corporation*> CorporationsTab;
};

class Shop : public Corporation
{
public:
	Shop();
	Shop(double price, int id, std::string location, double maxCapacity);
	void addShop();
	void GetDataShop(double price, int id, std::string location, double maxCapacity);
private:
	double m_shopPrice;
	int m_shopID;
	std::string m_shopLocation;
	double m_shopMaxCapacity;
	std::vector<Shop*> ShopsTab;
};

class RDCenter : public Corporation
{
public:
	RDCenter();
	RDCenter(int id, double price, int delay);
	void GetDataRDCenter(int id, double price, int delay);
	void addRDCenter();
private:
	int m_RDCenterID;
	double m_RDCenterPrice;
	double m_funds;
	int m_delay; // le temps minimum accordé apres une découverte (face aux autres joueurs)
	std::vector<RDCenter*> RDCentersTab;
};



class Factory : public Corporation
{
public:
	Factory();
	Factory(int id, double price, double maxCapacity, double effeciency);
	void GetDataFactory(int id, double price, double maxCapacity, double effeciency);
	void addFactory();
private:
	int m_factoryID;
	double m_factoryPrice;
	double m_factoryMaxCapacity;
	double m_effeciency;
	std::vector<Factory*> FactoriesTab;
};

class Transaction : public Corporation
{
public:
	struct transactions
	{
		double fees;
		std::string wording;
		std::string senderName;
		std::string recipientName;
	};
	Transaction();
	Transaction(transactions transaction);
	void GetDataTransaction(transactions transaction);
private:
	transactions m_transaction;
	std::vector<Transaction*> TransactionsTab;
};