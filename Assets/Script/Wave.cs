using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
   public float MoveSpeed = 5.0f;
 
     public float frequency = 20.0f;  // Speed of sine movement
     public float magnitude = 0.5f;   // Size of sine movement
     private Vector3 axis;
 
     private Vector3 pos;
    private Rigidbody2D rb;
     public float speed = 5f;
     Vector2 movement;
     bool isBouncing;

 
     void Start () {
         pos = transform.position;
         //Destroy(gameObject, 1.0f);
         axis = transform.up;  // May or may not be the axis you want
         rb = GetComponent<Rigidbody2D>();
     }

     void Update () {if(isBouncing == false)
         {pos += transform.right * Time.deltaTime * MoveSpeed;
         transform.position = pos + axis * Mathf.Sin (Time.time * frequency) * magnitude;}
         if(isBouncing == true)
         {pos -= transform.right * Time.deltaTime * MoveSpeed;
         transform.position = pos + axis * Mathf.Sin (Time.time * frequency) * magnitude;
         
         }
     }
     void OnCollisionEnter2D(Collision2D collision)
 {
     if(collision.gameObject.tag == "Wall")
     {
        
         isBouncing = true;
      
     }
      if(collision.gameObject.tag == "BWall")
     {
        
         isBouncing = false;
      
     }
 }
 void StopBounce()
 {
     isBouncing = false;
 }
 }