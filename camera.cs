using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {
  
        public float speed = 2f;
	// Update is called once per frame
	void Update () {//每一帧都执行update
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float v = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        Vector3 move = new Vector3(h, v, 0);
        transform.Translate(move);//大小写很重要,transform下的Translate方法
	}
}
