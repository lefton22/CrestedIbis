using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class pollutionPopUp : MonoBehaviour
{
    bool hasPopUp;
    float t;
    
    void Start()
    {
        t = Time.time;
        hasPopUp = false;
    }

    
    void Update()
    {
        if (!hasPopUp)
        {
            transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 1f, 10, 1);
            hasPopUp = true;
        }

        if (Time.time - t > 5f)
        {
            print("destrory");
            Destroy(gameObject);
        }
       // print("Time: " + Time.time);
    }
}
