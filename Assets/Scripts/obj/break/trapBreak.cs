using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapBreak : MonoBehaviour
{
    GameObject _ibisA;
    /*    bool hasCheck;
        float currentTime;*/

    public int lastTurn;

    void Start()
    {
        _ibisA = GameObject.Find("ibisA");
        //hasCheck = false;
        lastTurn = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "ibisA")
        {
/*            if (!hasCheck)
            {
                currentTime = Time.deltaTime;
               
                hasCheck = true;
            }*/
            _ibisA.GetComponent<Panda.Ibis.MyIbis>().breakWhenIbisAAct();
            Debug.Log(gameObject.name + " meet ibisA.");

            //GetComponent<SpriteRenderer>().enabled = false;
            //GetComponent<CapsuleCollider2D>().enabled = false;

            // play FX

            Destroy(gameObject);
        }
    }


    public void reduce1LastTurn()
    {
        lastTurn = lastTurn - 1;

        print("trap -1");
    }
    public void checkIfLast()
    {
        if (lastTurn < 0)
        {
            //play FX

            print("remove trap.");

            Destroy(gameObject);
        }
    }
}
