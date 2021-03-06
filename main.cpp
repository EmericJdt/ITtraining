// ITsim1_FinalVersion.cpp : définit le point d'entrée pour l'application console.
//

#include "stdafx.h"
#include "Header.h"

using namespace std;

struct Bite
{
	string gland = "Zbruuuuh";
	double verge = 18.5;
	int target = 75;
};
int main()
{
	Bite Biten;
	Transports BiteTransport;
	BiteTransport.GetDataTransport(Biten.gland, Biten.verge, Biten.target);

	// presentation du jeu
	cout << "hello everybody !! " << endl << "let's go to the game" << endl << "Please write the name of the first XMLfile.xml : ";
	cin >> nameFile;

	/*******utilisation de libxml2*************
	* ouverture du fichier XML + verification *
	* verification du contenue du fichier XML *
	* parcours du fichier XML				  *
	** cas pour la region				  *
	*** affichage des conteneurs	  *
	*** recuperation du data		  *
	*** mise du data dans un tableau  *
	** cas pour la corporation			  *
	*** affichage des conteneurs	  *
	*** recuperation du data		  *
	*** mise du data dans un tableau  *
	** cas pour la bank					  *
	*** affichage des conteneurs	  *
	*** recuperation du data		  *
	*** mise du data dans un tableau  *
	** cas pour le timstamp				  *
	*** affichage des conteneurs	  *
	*** recuperation du data		  *
	*** mise du data dans un tableau  *
	** cas pour le transport			  *
	*** affichage des conteneurs	  *
	*** recuperation du data		  *
	*** mise du data dans un tableau  *
	******************************************/

	// ouverture du fichier XML  
	xmlDocPtr doc;
	doc = xmlParseFile(nameFile);
	if (doc == NULL)
	{
		cout << "document XML introuvalble" << endl;
		return EXIT_FAILURE;
	}// le fichier est ouvert, sinon il indique qu'il y a une erreur


	 // verification que le fichier contient quelque chose
	xmlNodePtr World;
	World = xmlDocGetRootElement(doc);
	if (World == NULL)
	{
		cout << "Document XML vierge" << endl;
		xmlFreeDoc(doc);
		return EXIT_FAILURE;
	}// le fichier est complet, sinon il indique qu'il y a une erreur


	 // parcourir le fichier XML
	while (World)
	{
		xmlChar* Regions, Corporation, Transport, Bank, TimeStamp;
		xmlNodePtr nodeChildren = World->children;
		xmlChar* tag = xmlGetNodePath(nodeChildren);// ou est ce que c'ets la fonction xmlNodeGetContent?
		if (tag == Regions)
		{
			xmlNodePtr Regions = World->children;;
			xmlNodePtr Region = Regions->children;

			xmlNodePtr Demographie = Region->children;
			xmlNodePtr MacroEventproba = Region->children;
			xmlNodePtr nodeName = Region->children;

			xmlNodePtr nodePopulationNumber = Demographie->children;
			xmlNodePtr nodeEntitiesNbPerRegion = Region->children;
			xmlNodePtr nodePIB = Demographie->children;
			xmlNodePtr nodeEconomyPotential = Demographie->children;
			xmlNodePtr nodeSuperDepression = MacroEventproba->children;
			xmlNodePtr nodeNaturalCatastroph = MacroEventproba->children;
			xmlNodePtr nodeSuperGrowth = MacroEventproba->children;

			xmlChar* name = xmlNodeGetContent(nodeName);
			xmlChar* PopulationNumber = xmlNodeGetContent(nodePopulationNumber);
			xmlChar* EntitiesNbPerRegion = xmlNodeGetContent(nodeEntitiesNbPerRegion);
			xmlChar* PIB = xmlNodeGetContent(nodePIB);
			xmlChar* economyPotential = xmlNodeGetContent(nodeEconomyPotential);
			xmlChar* superDepression = xmlNodeGetContent(nodeSuperDepression);
			xmlChar* naturalCatastroph = xmlNodeGetContent(nodeNaturalCatastroph);
			xmlChar* superGrowth = xmlNodeGetContent(nodeSuperGrowth);
			//il faut changer certain xmlChar* en autre chose

			while (Regions)
			{
				while (Region)
				{
					string S1(name);
					int N1(PopulationNumber);
					int N2(EntitiesNbPerRegion);
					double D1(PIB);
					double D2(economyPotential);
					double D3(superDepression);
					double D4(naturalCatastroph);
					double D5(superGrowth);
				}
				Region R1(S1, N1, N2, D1, D2, D3, D4, D5);
				vectorDeRegion.push_back(R1);
			}
		}
		if (tag == Corporation)
		{
			string S1(name);
			string S2(technologiesList);
			int N1(maxCapacity);
			int N2(delay);
			int N3(maxCapacity);
			int N4(maxCapacity);
			double D1(effeciency);
			double D2(account);
			Corporation C1(S1, S2, N1, N2, N3, N4, D1, D2);
			vectorDeCorporation.push_back(C1);
		}
		if (tag == Transport)
		{
			string S1(transport);
			Transport T1(S1);
			vectorDeTransport.push_back(T1);
		}
		if (tag == Bank)
		{
			double D1(funds);
			double D2(fees);
			Bank B1(D1, D2);
			vectorDeBank.push_back(B1);
		}
		if (tag == TimeStamp)
		{
			int N1(maxQuarteur);
			TimeStamp T2(D1, D2);
			vectorDeTimeStamp.push_back(T2);
		}


		// fonction qui permet de passer à la lecture du noeudchildren suivant
	}
	// fin du parser de thibault
	return 0;
}

