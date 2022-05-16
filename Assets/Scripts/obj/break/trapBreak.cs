using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapBreak : MonoBehaviour
{
    GameObject _ibisA;
/*    bool hasCheck;
    float currentTime;*/
    void Start()
    {
        _ibisA = GameObject.Find("ibisA");
        //hasCheck = false;
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

        }
    }
}
