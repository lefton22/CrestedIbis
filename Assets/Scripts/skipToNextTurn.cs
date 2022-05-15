using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UIElements;
using UnityEngine.UI;

using Panda;

// skip to next turn buttom when there's no card can be drew
public class skipToNextTurn : MonoBehaviour
{
    float time;
    GameObject _ibisA;
    bool hasCheck;
    GameObject _turnBased;

    void Start()
    {
        time = 0;
        _ibisA = GameObject.Find("ibisA");
        hasCheck = false;
        _turnBased = GameObject.Find("TurnBased");
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
      //  _ibisA.GetComponent<Panda.Ibis.MyIbis>().breakThisTurn();
        GameObject.Find("skipTurn").GetComponent<Image>().enabled = false;
        GameObject.Find("skipTurn").transform.GetChild(0).gameObject.SetActive(false);


        ///copy from MyTurn.cs
        ///
        _ibisA.GetComponent<Pathfinding.AILerp>().enabled = false;
        _ibisA.GetComponent<Panda.Ibis.MyIbis>().landsPassThrough.Clear();
        _ibisA.GetComponent<CapsuleCollider>().enabled = false;
        // _ibisA.GetComponent<PandaBehaviour>().enabled = false;
        foreach (Transform child in _ibisA.transform)
        {
            child.gameObject.GetComponent<PandaBehaviour>().enabled = false;
            child.gameObject.GetComponent<PandaBehaviour>().Reset();

        }

        _turnBased.GetComponent<turnBased>().newTurnStart();

        // gameObject.GetComponent<PandaBehaviour>().enabled = false;

        GameObject.FindGameObjectWithTag("thisTurn").GetComponent<PandaBehaviour>().Reset();

        Destroy(GameObject.FindGameObjectWithTag("thisTurn"));

        GameObject[] cards;
        cards = GameObject.FindGameObjectsWithTag("card");
        foreach (GameObject card in cards)
        {
            Destroy(card);
        }
        ///

        hasCheck = false;
    }
}
