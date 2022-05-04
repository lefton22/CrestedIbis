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
        if (whichNPC == "egret")
        {
            objEgret sc = gameObject.AddComponent<objEgret>() as objEgret;
        }
        if (whichNPC == "jackdaw")
        {
            objJackDaw sc = gameObject.AddComponent<objJackDaw>() as objJackDaw;
        }
        if (whichNPC == "snake")
        {
            objSnake sc = gameObject.AddComponent<objSnake>() as objSnake;
        }
        if (whichNPC == "eagle")
        {
            objEagle sc = gameObject.AddComponent<objEagle>() as objEagle;
        }

        if (whichNPC == "ibisAdult")
        {
            objIbisAdult sc = gameObject.AddComponent<objIbisAdult>() as objIbisAdult;

            GameObject ibisNPC = Instantiate(Resources.Load("ibisB")) as GameObject;
            ibisNPC.transform.SetParent(gameObject.transform);
            ibisNPC.transform.position = gameObject.transform.position;
        }
    }
}
