using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.InteropServices;


public class Save : MonoBehaviour
{
    
    const string DLL_NAME = "Tutorial2";

    [DllImport(DLL_NAME)]
    private static extern Vector3 locLoad();

    [DllImport(DLL_NAME)]
    private static extern void locSave(float x, float y, float z);

    Vector3 loc;
    
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.O))
        {
            SaveLocation();
        }

        if (Input.GetKey(KeyCode.P))
        {
            LoadLocation();
        }
    }

    public void SaveLocation()
    {

        float x = transform.localPosition.x;
        float y = transform.localPosition.y;
        float z = transform.localPosition.z;

        locSave(x, y, z);
    }

    public void LoadLocation()
    {
        loc = locLoad();
        transform.localPosition = loc;
    }

}
