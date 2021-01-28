using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Satellite : MonoBehaviour
{
    //Assign a GameObject in the Inspector to rotate around
    public GameObject target;
    public float Rspeed;

   private Vector3 zAxis = new Vector3(0, 0, 1);
 
     void FixedUpdate () {
         transform.RotateAround(target.transform.position, zAxis, Rspeed); 
     }
 }
 
