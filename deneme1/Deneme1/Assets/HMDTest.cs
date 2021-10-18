using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class HMDTest : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Is device active: " + XRSettings.isDeviceActive);
        Debug.Log("Device name: " + XRSettings.loadedDeviceName);
        
    }


    void Update()
    {
        
    }
}
