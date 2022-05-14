using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UIElements;
using UnityEngine.UI;

// skip to next turn buttom when there's no card can be drew
public class skipToNextTurn : MonoBehaviour
{
    float time;
    GameObject _ibisA;
    bool hasCheck;
    void Start()
    {
        time = 0;
        _ibisA = GameObject.Find("ibisA");
        hasCheck = false;
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.deltaTime + time;
        // print("time: "+ time);
        if (time > 2f && !hasCheck)
        {
            print("can i skip this turn?");
            GameObject.Find("skipTurn").GetComponent<Image>().enabled = true;
            GameObject.Find("skipTurn").transform.GetChild(0).gameObject.SetActive(true);

            hasCheck = true;
        }
    }

    public void skip()
    {
        print("click the buttom and skip this turn");
        _ibisA.GetComponent<Panda.Ibis.MyIbis>().breakThisTurn();
        GameObject.Find("skipTurn").GetComponent<Image>().enabled = false;
        GameObject.Find("skipTurn").transform.GetChild(0).gameObject.SetActive(false);

        hasCheck = false;
    }
}
