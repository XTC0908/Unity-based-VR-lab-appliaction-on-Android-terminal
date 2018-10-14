using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class toggle : MonoBehaviour
{
    private GameObject obj1;
 
    public Material light;

    // Use this for initialization
    void Start()
    {

        obj1 = GameObject.Find("Cube");
    }
    void OnMouseDown()
    {
     
        obj1.GetComponent<Renderer>().material=light;
    }
}

