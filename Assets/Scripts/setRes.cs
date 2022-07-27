using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setRes : MonoBehaviour
{
    float cameraSize;
    float solidValue;
    float startRatio;
    int n;

    float defaultWidth;
    public bool maintainWidth = true;

    public float adjust;

    void Start()
    {
        startRatio = 64.66f;
        solidValue = 28.55f;

       // adjust = 1f;

        // GetComponent<CanvasScaler>().referenceResolution = new Vector2(1366, 768);


        //if (Screen.width <= 500f)
        //{ n = 0; }
        //if (Screen.width > 500f && Screen.width <= 600)
        //{ n = 0; }
        //if (Screen.width > 600f && Screen.width <= 700)
        //{ n = 1; }


        //cameraSize = Screen.width / (startRatio + solidValue * n);

        if (Screen.width == 1920) { GetComponent<Camera>().orthographicSize = 5.4f; }

        if (Screen.width == 1366) { GetComponent<Camera>().orthographicSize = 5.31f; }


        //GetComponent<Camera>().orthographicSize = cameraSize;

        defaultWidth = Camera.main.orthographicSize * Camera.main.aspect;

    }


    void Update()
    {



        // print("scree res: " + Screen.currentResolution);
//         Debug.Log("Screen Width : " + Screen.width + ", Height: " + Screen.height);


        if (maintainWidth)
        {
            Camera.main.orthographicSize = defaultWidth / Camera.main.aspect  *adjust;

        }
    }
}
