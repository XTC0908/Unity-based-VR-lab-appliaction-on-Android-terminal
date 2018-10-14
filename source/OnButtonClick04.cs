using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class OnButtonClick04 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        GameObject btnObj = GameObject.Find("Button4");
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
        Application.LoadLevel("board"); //application方法？
    }
}
