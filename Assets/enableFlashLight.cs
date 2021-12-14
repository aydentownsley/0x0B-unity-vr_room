using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enableFlashLight : MonoBehaviour
{
    public GameObject flashLight;

    public void enableLight()
    {
        if (flashLight.activeSelf == false)
        {
            flashLight.SetActive(true);
        }
        else
        {
            flashLight.SetActive(false);
        }
    }
}
