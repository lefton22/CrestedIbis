using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objEgg : MonoBehaviour
{
    public int hatchNeedTurn;
    public int hatchCurrentTurn;
    void Start()
    {
        hatchCurrentTurn = 2; ////������25-28�졣���츸ĸ������������
    }

    public void checkHatch() //check if this egg can become baby ibis
                                         // if can , become babies
    {

            GameObject babyIbis = Instantiate(Resources.Load("obj/birdling")) as GameObject;

            babyIbis.transform.position =gameObject.transform.position;
            babyIbis.transform.SetParent(GameObject.Find("ObjOnLand").transform);

            Panda.Ibis.MyIbis.eggs.Remove(gameObject);

            Destroy(gameObject);


   }





}
