using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objNPC : MonoBehaviour
{
    public string whichNPC;

    //objFood _objFood;
    void Start()
    {
        whichNPC = name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void checkWhichNPC()
    {
        if (whichNPC == "ibisAdult")
        {
            objFood sc = gameObject.AddComponent<objFood>() as objFood;
        }
    }
}
