#include "stdafx.h"
#include "Corporations.h"

using namespace std;

Corporations::Corporations(string name) : m_name(name)
{

}

void Corporations::Show()
{
	cout << "You have created your own Corporation, your bases datas are : " << endl;
	cout << "Name : " << m_name << endl << "Technologies list : " << m_technologies_number << endl;
	cout << "Number of your created shop(s) : " << m_shops << endl << "Start amount of your account : " << m_mainAccount << endl;
	cout << "Number of your acting Research and Develop Center(s) : " << m_RDCentersNumber << endl;
	cout << "Number of your acting factory(ies) : " << m_factoriesNumber << endl;
}