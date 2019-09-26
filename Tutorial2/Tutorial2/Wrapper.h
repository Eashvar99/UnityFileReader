#pragma once
#include "PluginSettings.h"
#include "Map.h"
#ifdef __cplusplus
extern "C"
{
#endif
	// Put your functions here
	PLUGIN_API Vec3 locLoad();
	PLUGIN_API void locSave(float x, float y, float z);

#ifdef __cplusplus
}
#endif