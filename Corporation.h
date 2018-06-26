#pragma once
#include "Header.h"

class Corporation
{
public:
	Corporation();
	Corporation(int id, char* name, int technologiesNumber, std::vector<std::string> technologiesList, 
		double mainAccount, int entities, int shopsNumber, int RDCentersNumber, int factoriesNumber);
	void Show();
	void validParser();
	/*static bool TryParse(String^ s, [OutAttribute] double% result);
	virtual property String^ InnerText 
	{
		String^ get();
		void set(String^ value);
	}*/
protected:
	int _id;
	char* m_name[100] ;
	int m_technologiesNumber = 0;
	std::vector<std::string> m_technologiesList;
	double m_mainAccount;
	int m_entities;
	int m_shopsNumber;
	int m_RDCentersNumber;
	int m_factoriesNumber;
	std::vector<Corporation*> CorporationsTab;
};

class mainAccount : public Corporation
{
public:
	mainAccount();
	mainAccount(double amount, char* currency, double fees);
private:
	double m_amount;
	char* m_currency[1];
	double m_fees;
};

class Shop : public Corporation
{
public:
	Shop();
	Shop(int id, char* location, double maxCapacity);
	void addShop();
private:
	double m_shopPrice = 250000;
	int m_shopID;
	char* m_location[100];
	double m_shopMaxCapacity;
	std::vector<Shop*> ShopsTab;
};

class RDCenter : public Corporation
{
public:
	RDCenter();
	RDCenter(int id, double price, double funds, int delay);
	void addRDCenter();

private:
	int m_RDCenterID;
	double m_RDCenterPrice = 500000;
	double m_funds;
	int m_delay; // le temps minimum accordé apres une découverte (face aux autres joueurs)
	std::vector<RDCenter*> RDCentersTab;
};

class Factory : public Corporation
{
public:
	Factory();
	Factory(int id, double price, double maxCapacity, double effeciency);
	void addFactory();

private:
	int m_factoryID;
	double m_factoryPrice = 1000000;
	double m_factoryMaxCapacity;
	double m_effeciency;
	std::vector<Factory*> FactoriesTab;
};