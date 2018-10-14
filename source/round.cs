using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class round : MonoBehaviour
{
    private Vector3 v = new Vector3();
    public float speed = 0.0375f;
    // Use this for initialization
    void Start()
    {
        v.z = speed;
        v.x = 0;
        StartCoroutine(Routine());
    }
    private void FixedUpdate()
    {
        transform.position += v;

    }
    IEnumerator Routine()       //协程返回变量为IEnumerator数据类型；
    {
        yield return new WaitForSeconds(3f);
        v.z = 0;
        v.x = -speed;
        yield return new WaitForSeconds(3f);
        v.x = 0;
        v.z = -speed;
        yield return new WaitForSeconds(3f);
        v.z = 0;
        v.x = speed;
        yield return new WaitForSeconds(3f);
        v.x = 0;
        v.z = speed;
        yield return new WaitForSeconds(3f);
        StartCoroutine(Routine());

    }
}
