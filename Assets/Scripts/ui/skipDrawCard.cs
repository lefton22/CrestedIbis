using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class skipDrawCard : MonoBehaviour
{
    float time;
    bool hasCheck;
    void Start()
    {
        time = 0;
        hasCheck = false;
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.deltaTime + time;
        // print("time: "+ time);
        if (time > 2f && !hasCheck)
        {
            // print("can i skip this turn?");
            gameObject.GetComponent<Image>().enabled = true;
            transform.GetChild(0).gameObject.GetComponent<Text>().enabled = true;

            hasCheck = true;
        }
    }

    public void skip()
    {
        bool hasPlaySound;
        hasPlaySound = false;
        if (!hasPlaySound)
        {
            GameObject.Find("clickButton3").GetComponent<playSoundEffect>().playThisSF();
            hasPlaySound = true;
        }

        print("skip");
        GameObject.Find("TurnBased").transform.GetChild(0).gameObject.GetComponent<Panda.Ibis.MyTurn>().drawCardShouldEnd = true;
     }
}
