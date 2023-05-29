using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadLight : MonoBehaviour
{
    public GameObject Light;
    void OnEnable()
    {
        Climate.onClimate += LightGlow;
    }
    private void OnDisable()
    {
        Climate.onClimate -= LightGlow;
    }

    void LightGlow(bool day)
    {
        Light.SetActive(!day);
    }
}
