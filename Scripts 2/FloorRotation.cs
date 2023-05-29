using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorRotation : MonoBehaviour
{
    public float rotSpeed;
    
    void FixedUpdate()
    {
        transform.Rotate(Vector3.up *rotSpeed*Time.deltaTime);
    }
}
