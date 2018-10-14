using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collider : MonoBehaviour {
    private GameObject obj3;
    
    private Toggle Toggle,Toggleno;
	// Use this for initialization
	void Start () {
        obj3 = GameObject.Find("Y0");
       
        Toggleno.onValueChanged.AddListener(OnValueChanged);
	}
	
	// Update is called once per frame
	void OnValueChanged(bool check)
    {

        obj3.gameObject.SetActive(false);

    }
		
}
