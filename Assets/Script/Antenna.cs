using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Antenna : MonoBehaviour
{
    private bool selected;
    public GameObject Text;
public GameObject Console;
    
    void Update()
    {
        if (selected == true)
        {
           Text.SetActive(true);
           Console.SetActive(true);
        }

        if (Input.GetMouseButtonUp(0))
        {
            selected = false;
        }
         if (Input.GetKeyDown(KeyCode.Escape))
        {
             Text.SetActive(false);
           Console.SetActive(false);
        }
    }

    void OnMouseOver()
    {
        Debug.Log("MouseOver");
        if(Input.GetMouseButtonDown(0))
        {
            selected = true;
        }
    }
    
}
