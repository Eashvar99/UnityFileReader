#pragma once
#include "PluginSettings.h"

#include <iostream>
#include <fstream>
#include <string>
using namespace std; 

struct Vec3
{
	float x;
	float y;
	float z;
};

class PLUGIN_API Map
{
public:
	Vec3 locLoad();
	void locSave(float x, float y, float z);

	Vec3 location;
};