using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridToBG : MonoBehaviour
{
    GameObject bg;
    void Start()
    {
        bg = GameObject.Find("bg0");
    }


    void Update()
    {
        transform.position = bg.transform.position;
    }
}
