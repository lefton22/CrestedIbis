using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class blink : MonoBehaviour
{
    bool isMax;
    bool isMin;

    float t;

    Vector3 scaleChange;

    void Start()
    {
        isMax = false;
        isMin = true;

        scaleChange = new Vector3(0.001f, 0.001f,0f);
    }

    // Update is called once per frame
    void Update()
    {
        /*        if ( isMin)
                {
                    transform.DOScale(new Vector3(1.15f, 1.15f, 1.2f), 2f);

                    //print(transform.localScale.x);

                }
                if (transform.localScale.x == 1.15f)
                {
                    isMax = true;
                    isMin = false;
                }

                if (isMax)
                {
                    transform.DOScale(new Vector3(1f, 1f, 1f), 2f);
                }

                if (transform.localScale.x == 1.000002f )
                {
                    isMin = true;
                    isMin = false;
                }*/
        /*
                print("isMin: " + isMin + " , isMax: " + isMax);

                if (transform.localScale.x > 1.146f)
                    transform.DOScale(new Vector3(1f, 1f, 1f), 1f);*/

        // transform.DOPunchScale( new Vector3(1.2f, 1.2f, 1f), 2f, 10, 0.1f);


       // print(Time.deltaTime);

        t = t + Time.deltaTime;
        if (t <2f)
        {
            //transform.DOScale(new Vector3(1.3f, 1.3f, 1.2f), 1f);
            transform.localScale += scaleChange;
            //print("++++ "  + t); 
        }
        if (t > 2F)
        {  
            //print("=== " +t);
            //transform.DOScale(new Vector3(1f,1f,1f),0.001f);
            transform.localScale -= scaleChange;
        }

        if (t > 4f)
        {
            t = 0f;
        }

/*        if (transform.localScale.x < 0f)
        {

        }*/
    }
}
