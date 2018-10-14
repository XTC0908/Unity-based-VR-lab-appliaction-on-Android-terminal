using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class OnButtonClick09 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject btnObj = GameObject.Find("play");
       Button btn = btnObj.GetComponent<Button>();
        btn.onClick.AddListener(delegate()
        {
            this.GoNextScene(btnObj);
        }
        );
	}
	
	// Update is called once per frame

    public void GoNextScene(GameObject NScene)
    {
        Application.LoadLevel("Scene"); //application方法？
    }
}
