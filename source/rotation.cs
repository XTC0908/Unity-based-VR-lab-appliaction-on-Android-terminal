using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public float speed = 6f;
    void Update()
    {

     
        
            transform.Rotate(0, speed * Time.deltaTime, 0, Space.Self); //transform组件中的Rotate方法


            // Update is called once per frame

        
     

}

}