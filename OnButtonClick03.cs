﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class OnButtonClick03 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject btnObj = GameObject.Find("Button3");
       Button btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate()
        {
            this.GoNextScene(btnObj);
        }
        );
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void GoNextScene(GameObject NScene)
    {
        Application.LoadLevel("74LS139"); //application方法？
    }
}
