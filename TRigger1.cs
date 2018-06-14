using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TRigger1 : MonoBehaviour {
    private GameObject obj1, obj2, obj3;
    public Material light,off;
    // Use this for initialization
    void Start() {
        obj1 = GameObject.Find("deng2");
    }

    // Update is called once per frame
  
    void OnTriggerEnter(Collider coll)
            {
            obj1.GetComponent<Renderer>().material = light;
                //亮
        } 
    void OnTriggerExit(Collider coll)
   
        {
            obj1.GetComponent<Renderer>().material = off;
            //灭
        }
    
   
}