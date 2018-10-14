
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class whenfause2 : MonoBehaviour
{
    private GameObject obj1, obj2, obj3;
    public Material off, Redlight;
    public bool isShow = false;
    // Use this for initialization

    void OnTriggerExit(Collider coll)

    {
        if (coll.gameObject.name == "chaba4")
        {
            isShow = !isShow;

        }
    }
        void OnGUI()

{

            if (isShow)

                GUI.Label(new Rect(10, 200, 100, 30), "错误！！！！");
        }
    
}
