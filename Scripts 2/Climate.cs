using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class Climate : MonoBehaviour
{
    public static UnityAction<bool> onClimate;
    public GameObject day;
    public GameObject night;
    public Material dayMaterial; // The material with the day skybox cubemap
    public Material nightMaterial; // The material with the night skybox cubemap

    public Material currentMaterial; // The current skybox material
    public Cubemap cubemap;

    bool light = false;

    private void OnEnable()
    {
        onClimate += ClimateCondition;
    }
    private void OnDisable()
    {
        onClimate-= ClimateCondition;
    }
    private void Start()
    {


        
       
        Switch();
        
       
    }
    public void Switch()
    {

          
        
        light = !light;
        onClimate?.Invoke(light);

        


    }

    void ClimateCondition(bool light)
    {
        if(light)
        {
            RenderSettings.ambientIntensity = 1f;
            currentMaterial.SetFloat("_Exposure", 1.1f);
            currentMaterial.SetTexture("_Tex", dayMaterial.GetTexture("_Tex"));
            day.SetActive(true);
            night.SetActive(false);
        }
        else
        {
            RenderSettings.ambientIntensity = 0.1f;
            currentMaterial.SetFloat("_Exposure", 0.3f);
            currentMaterial.SetTexture("_Tex", nightMaterial.GetTexture("_Tex"));
            day.SetActive(false);
            night.SetActive(true);
        }
    }
}
