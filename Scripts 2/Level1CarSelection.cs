using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1CarSelection : MonoBehaviour
{
    public GameObject[] switches;
    public ShopSaveScriptable shopScriptable;
    private void Awake()
    {
        ActiveCar(shopScriptable.selectedIndex);
    }
    // Start is called before the first frame update
    void ActiveCar(int car)
    {
        /*Debug.Log(car);*/
        
        for (int i = 0; i < switches.Length; i++)
        {
            switches[i].SetActive(i==car);
            
        }
    }
}
