using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CarSelection : MonoBehaviour
{
    int currentCar;

    [SerializeField] Button leftCLick;
    [SerializeField] Button righttCLick;

    public ShopSaveScriptable obj;
   
    private void Awake()
    {
        
        ActiveCar(obj.selectedIndex);
        currentCar= obj.selectedIndex;
    }
    void ActiveCar(int car)
    {
        /*Debug.Log(car);*/
        leftCLick.interactable = (car != 0);
        righttCLick.interactable= (car !=transform.childCount-1);
        for(int i=0;i<transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i==car);
        }
    }
   public void ChangeCar(int change)
    {
        currentCar += change;
        ActiveCar(currentCar);
    }
}
