﻿
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whenfause1 : MonoBehaviour
{
    private GameObject obj1, obj2, obj3;
    public Material off, Redlight;
    // Use this for initialization
    void Start()
    {
        obj1 = GameObject.Find("deng3");
        obj2 = GameObject.Find("deng4");
        obj3 = GameObject.Find("deng5");
    }
    void OnTriggerExit(Collider coll)

    {
        if (coll.gameObject.name == "chaba4")
        {
            obj1.GetComponent<Renderer>().material = Redlight;
            obj2.GetComponent<Renderer>().material = Redlight;
            obj3.GetComponent<Renderer>().material = Redlight;


        }
    }
    //  void OnTriggerEnter(Collider coll)
    //  {
    //if (coll.gameObject.name == "chaba4")
    //    {
    //          obj1.GetComponent<Renderer>().material = off;
    //        obj2.GetComponent<Renderer>().material = off;
    //         obj3.GetComponent<Renderer>().material = off;
    //     }
    // }
}
