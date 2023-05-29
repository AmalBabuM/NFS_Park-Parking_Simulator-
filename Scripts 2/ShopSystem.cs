using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

namespace ShopUI
{
    public class ShopSystem : MonoBehaviour
    {
        public int totalCoin;
        public TextMeshProUGUI bounty;

        public ShopSaveScriptable shopData;

        public GameObject[] carModels;
        public TextMeshProUGUI unlockBtnText, carNameText;
        public TextMeshProUGUI powerText, speedText, accelerationText, totalCoinText;

        public Button unlockButton, rightButton, leftButton;

        int currentIndex = 0;
        private int selectedIndex;

        private void Start()
        {
            unlockButton.onClick.AddListener(() => UnlockBtnMethod());
            rightButton.onClick.AddListener(() => RightBtnMethod());
            leftButton.onClick.AddListener(() => LeftBtnMethod());
            totalCoin = PlayerPrefs.GetInt("HighScore", 0);
            bounty.text = PlayerPrefs.GetInt("HighScore").ToString();
            selectedIndex = shopData.selectedIndex;
            currentIndex = selectedIndex;
            totalCoinText.text = ""+totalCoin;
            SetCarInfo();

            

            UnlockButtonStatus();
            
        }
        private void SetCarInfo()
        {
            carNameText.text = shopData.shopItems[currentIndex].itemName;
            powerText.text = "" + shopData.shopItems[currentIndex].power;
            speedText.text = "" + shopData.shopItems[currentIndex].highSpeed;
            accelerationText.text = "" + shopData.shopItems[currentIndex].acceleration + "s";
            totalCoinText.text = "" + shopData.shopItems[currentIndex].unlockCost;
        }

        void RightBtnMethod()
        {
            currentIndex++;
            SetCarInfo();
            UnlockButtonStatus();
        }
        void LeftBtnMethod()
        {
            currentIndex--;
            SetCarInfo();
            UnlockButtonStatus();
        }
        public void UnlockBtnMethod()
        {
            bool yesSelected = false;
            if (shopData.shopItems[currentIndex].isUnlock)
            {
                yesSelected= true;
            }
            else
            {
                /*Debug.Log("omg");*/
                if (totalCoin >= shopData.shopItems[currentIndex].unlockCost)
                {
                    totalCoin -= shopData.shopItems[currentIndex].unlockCost;
                    PlayerPrefs.SetInt("HighScore", totalCoin);
                    bounty.text = PlayerPrefs.GetInt("HighScore").ToString();

                    totalCoinText.text = "" + totalCoin;
                    yesSelected= true;
                    shopData.shopItems[currentIndex].isUnlock = true;
                }
            }
            if(yesSelected)
            {
                
                unlockBtnText.text = "Selected";
                selectedIndex = currentIndex;
                shopData.selectedIndex = selectedIndex;
                Debug.Log(shopData.selectedIndex);
                
                unlockButton.interactable= false;
            }

            /*Debug.Log("Unlocked");*/
        }
        private void OnDisable()
        {
            Debug.Log(shopData.selectedIndex);
        }
        void UnlockButtonStatus()
        {
            if (shopData.shopItems[currentIndex].isUnlock)
            {
                /*unlockButton.interactable = selectedIndex != currentIndex ? true : false;*/
                unlockButton.interactable = selectedIndex != currentIndex;

                /*if (selectedIndex == currentIndex)
                    unlockButton.interactable = false;
                else
                    unlockButton.interactable = true;*/

                unlockBtnText.text = selectedIndex == currentIndex ? "Selected" : "Select";
                Debug.Log("if case");
            }
            else
            {
                Debug.Log("else case");
                unlockButton.interactable = true;
                unlockBtnText.text = "$ " + shopData.shopItems[currentIndex].unlockCost;
            }
            
        }
    } 

}

