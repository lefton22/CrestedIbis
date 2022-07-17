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

    void Start()
    {
        startRatio = 64.66f;
        solidValue = 28.55f;


        // GetComponent<CanvasScaler>().referenceResolution = new Vector2(1366, 768);


        //if (Screen.width <= 500f)
        //{ n = 0; }
        //if (Screen.width > 500f && Screen.width <= 600)
        //{ n = 0; }
        //if (Screen.width > 600f && Screen.width <= 700)
        //{ n = 1; }
        //if (Screen.width > 700f && Screen.width <= 800)
        //{ n = 2; }
        //if (Screen.width > 800f && Screen.width <= 900)
        //{ n = 3; }
        //if (Screen.width > 900f && Screen.width <= 1000)
        //{ n = 4; }
        //if (Screen.width > 1000f && Screen.width <= 1100)
        //{ n = 5; }
        //if (Screen.width > 1100f && Screen.width <= 1200)
        //{ n = 6; }
        //if (Screen.width > 1100f && Screen.width <= 1200)
        //{ n = 7; }
        //if (Screen.width > 1200f && Screen.width <= 1300)
        //{ n = 8; }
        //if (Screen.width > 1300f && Screen.width <= 1400)
        //{ n = 9; }
        //if (Screen.width > 1400f && Screen.width <= 1500)
        //{ n = 10; }
        //if (Screen.width > 1500f && Screen.width <= 1600)
        //{ n = 11; }
        //if (Screen.width > 1600f && Screen.width <= 1700)
        //{ n = 12; }
        //if (Screen.width > 1700f && Screen.width <= 1800)
        //{ n = 13; }
        //if (Screen.width > 1800f && Screen.width <= 1900)
        //{ n = 14; }
        //if (Screen.width > 1900f && Screen.width <= 2000)
        //{ n = 15; }
        //if (Screen.width > 2000f && Screen.width <= 2100)
        //{ n = 16; }

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
            Camera.main.orthographicSize = defaultWidth / Camera.main.aspect;

        }
    }
}
