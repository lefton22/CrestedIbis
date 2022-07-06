using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objEgret : MonoBehaviour
{
   
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        print("egret has an collision");
        if (collision.gameObject.name == "trap" /* && collision.gameObject.GetComponent<SpriteRenderer>() */)
        {
            print(collision.gameObject.name);

            GameObject[] npcOrders;
            npcOrders = GameObject.FindGameObjectsWithTag("npcOrder");

            for (int i = 0; i < npcOrders.Length; i++)
            {
                if (npcOrders[i].name == "NpcOrder_egret(Clone)")
                {
                    npcOrders[i].GetComponent<Panda.Ibis.MyNPC>().NextIfEgretDie();

                    Destroy(npcOrders[i]);
                }
            }

            

            //play the effect

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }

    //void enableTrapManOrder()
    //{
        
    //}
 }
