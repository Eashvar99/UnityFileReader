#include "Wrapper.h"
Map map;

PLUGIN_API Vec3 locLoad()
{
	return map.locLoad();
}

PLUGIN_API void locSave(float x, float y, float z)
{
	return map.locSave(x, y, z);
}