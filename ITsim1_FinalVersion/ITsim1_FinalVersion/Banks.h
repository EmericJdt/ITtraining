#pragma once
#include "Header.h"

typedef mainAccountStructure mainAccountStructure;
struct mainAccountStructure
{
	double amount;
	std::string currency;
	double fees;
};
class Banks
{
public:

private:
	mainAccountStructure mainAccount;
};