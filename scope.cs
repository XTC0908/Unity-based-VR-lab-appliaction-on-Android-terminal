using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scope : MonoBehaviour {
     Rigidbody m_Rigidbody;
    Transform m_Transform;
    private void Start()
    {
        m_Rigidbody = gameObject.GetComponent<Rigidbody>();                   //刚体调用
        m_Transform = gameObject.GetComponent<Transform>();       //transform组件调用
        m_Rigidbody.MovePosition(m_Transform.position + Vector3.forward);
    }
    } 
