using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TRigger4 : MonoBehaviour {
    private GameObject obj1, obj2, obj3,obj4;
    public Material light,off;
    // Use this for initialization
    void Start() {
        obj1 = GameObject.Find("Object03");
        obj2 = GameObject.Find("Object02");
        obj3 = GameObject.Find("deng1");
        obj4 = GameObject.Find("deng2");

    }

    // Update is called once per frame

    //void OnTriggerEnter(Collider coll)
    // {
    //  obj1.GetComponent<Renderer>().material = light;
    //亮
    //} 
    void onTriggerStay(Collider coll)
    {

        if (coll.gameObject.name == "chaba3")
        {
            obj1.GetComponent<Renderer>().material = light;
            obj2.GetComponent<Renderer>().material = light;
            obj3.GetComponent<Renderer>().material = light;
            obj4.GetComponent<Renderer>().material = light;
            //liang
        }
    }
    void OnTriggerExit(Collider coll)

    {
        if (coll.gameObject.name == "chaba3")
        {
            obj1.GetComponent<Renderer>().material = off;
            obj2.GetComponent<Renderer>().material = off;
            obj3.GetComponent<Renderer>().material = off;
            obj4.GetComponent<Renderer>().material = off;
            //灭
        }
    }
   
}