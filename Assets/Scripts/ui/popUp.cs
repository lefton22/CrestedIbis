using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class popUp : MonoBehaviour
{
    float t;
    public float xiaoshiTime;
    void Start()
    {
        t = 0f;

        transform.DOPunchScale(new Vector3(0.4f, 0.4f, 0f), 0.5f, 5,0.5f);
       
    }

    void Update()
    {
        t = t + 1f;
       // print("t: " + t);

        if (t > xiaoshiTime)
        {
            xiaoShi();
        }
    }
    void xiaoShi()
    {
        Destroy(gameObject);
    }
}
