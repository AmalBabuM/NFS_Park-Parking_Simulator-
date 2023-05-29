using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="ShopData",menuName ="ScriptableObjects/Create ShopData")]
public class ShopSaveScriptable : ScriptableObject
{
    public int selectedIndex;
    public ShopItem[] shopItems;
}

[System.Serializable]
public class ShopItem
{
    public string itemName;
    public bool isUnlock;
    public int unlockCost;
    public int power;
    public int highSpeed;
    public float acceleration;
    
}

/*[System.Serializable]
public class CarInfo
{
    public int unlockCost;
    public int power;
    public int highSpeed;
    public int acceleration;
    public int nitrous;
}
*/