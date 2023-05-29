using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionLight : MonoBehaviour
{
    
    public Quaternion dayRotation;
    public Quaternion nightRotation;
    // Start is called before the first frame update
    private void OnEnable()
    {
        Climate.onClimate += SunLight;
    }
    
    private void OnDisable()
    {
        Climate.onClimate -= SunLight;
    }

    void SunLight(bool day)
    {
        
        if (day==true)
        {
           /* Debug.Log("Flaashhhh");*/
            transform.rotation = dayRotation;
        }
        else
        {
            /*Debug.Log("pppp");*/
            transform.rotation = nightRotation;
        }
    }
}
