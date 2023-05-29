using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitchButton : MonoBehaviour
{
    bool switched;
    public CinemachineVirtualCamera backCam;
    public CinemachineVirtualCamera frontCam;

    private void Update()
    {
        if(Input.GetKeyDown("c"))
        {
            switched= !switched;
            if(switched==true)
            {
                backCam.Priority= 0;
                frontCam.Priority= 1;
            }
            else
            {
                backCam.Priority = 1;
                frontCam.Priority = 0;
            }
        }
    }
}
