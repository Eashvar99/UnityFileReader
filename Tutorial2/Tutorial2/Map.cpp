#include "Map.h"

Vec3 Map::locLoad()
{
	ifstream text;
	text.open("Map.txt");

	if (text.is_open()) 
	{
		text >> location.x;
		text >> location.y;
		text >> location.z;
	}

	text.close();

	return location;
}

void Map::locSave(float x, float y, float z)
{
	ofstream text;
	text.open("Map.txt");

	if (text.is_open()) 
	{
		text << x << endl;
		text << y << endl;
		text << z << endl;
	}

	text.close();
}