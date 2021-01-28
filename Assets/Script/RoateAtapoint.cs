﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoateAtapoint : MonoBehaviour
{
     public float degreesPerSec = 360f; 

    void Start() { 
    } 

    void Update() { 
        float rotAmount = degreesPerSec * Time.deltaTime; 
        float curRot = transform.localRotation.eulerAngles.z; 
        transform.localRotation = Quaternion.Euler(new Vector3(0,0,curRot+rotAmount)); 
    } 

}
