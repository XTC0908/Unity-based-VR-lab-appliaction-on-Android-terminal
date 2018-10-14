using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TRigger2 : MonoBehaviour {
    private GameObject obj1, obj2, obj3;
    public Material light,off;
    // Use this for initialization
    void Start() {
                obj1 = GameObject.Find("Object02");
    }

    // Update is called once per frame

    void OnTriggerEnter(Collider coll)
    {
        if (coll.gameObject.name == "LED01")
        {
            obj1.GetComponent<Renderer>().material = light;
            //亮
        }
    }
    void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject.name == "LED01")
        {
            obj1.GetComponent<Renderer>().material = light;
            //亮
        }
    }
    void OnTriggerExit(Collider coll)
   
        {if (coll.gameObject.name == "LED01")
        {
            obj1.GetComponent<Renderer>().material = off;
            //灭
        }
        }
    
   
}