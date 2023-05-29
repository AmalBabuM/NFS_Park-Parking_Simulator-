using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public OldController RR;
   /* public NitrusBar NN;*/
    public GameObject needle;
    private float startPosition=-381f, endPosition=-571f;
    private float desiredPosition;

    private float vehicleSpeed;
    public Text kph;
    public Text gearBox;
    private int gearNum;
    /*public Slider nitroSlider;*/
    // Start is called before the first frame update
    public void SpeedObject(OldController RR)
    {
        this.RR = RR;
    }
   /* private void Update()
    {
       *//* if (Input.GetKeyDown("k"))
        {
            SceneManager.LoadScene(1);
        }*/
        /*if (Input.GetKeyDown("m"))
        {
            ScoreManager.instance.AddScore();
        }*//*
    }*/

    // Update is called once per frame
    void FixedUpdate()
    {
       

        kph.text = Mathf.Clamp(RR.kph,0,450).ToString("0");
        /*vehicleSpeed = Mathf.Clamp(RR.kph, 0, 450);*/
        vehicleSpeed = Mathf.Lerp(vehicleSpeed, RR.kph, Time.deltaTime);
        updateNeedle();
        ChangeGear();
        /*NitroUI();*/
    }
    public void updateNeedle()
    {
        desiredPosition = startPosition - endPosition;
        float temp = vehicleSpeed / 350;
        needle.transform.eulerAngles = new Vector3(0, 0, (startPosition - temp * desiredPosition));
        /*Debug.Log(desiredPosition);*/
    }

   /* public void NitroUI()
    {
        *//*Debug.Log(NN.nitrusValue);*//*
        nitroSlider.value = NN.nitrusValue/2;
    }*/
    public void ChangeGear()
    {
      if(RR.kph<50f)
        {
            /*Debug.Log();*/
            gearNum = 1;
            /*gearBox.text = gearNum.ToString();*/
        }
        if (RR.kph >= 50f&& RR.kph<100f)
        {
            /*Debug.Log();*/
            gearNum = 2;
            /*gearBox.text = gearNum.ToString();*/
        }
        if (RR.kph >= 100f && RR.kph < 250f)
        {
            /*Debug.Log();*/
            gearNum = 3;
            /*gearBox.text = gearNum.ToString();*/
        }
        if (RR.kph >= 250f && RR.kph < 300f)
        {
            /*Debug.Log();*/
            gearNum = 4;
            /*gearBox.text = gearNum.ToString();*/
        }
        if (RR.kph >= 300f)
        {
            /*Debug.Log();*/
            gearNum = 5;
            /*gearBox.text = gearNum.ToString();*/
        }
        gearBox.text = gearNum.ToString();

    }
}
