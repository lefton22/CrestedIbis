using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapBreak : MonoBehaviour
{
    GameObject _ibisA;
    /*    bool hasCheck;
        float currentTime;*/

    public int lastTurn;

    Obj_icons _Obj_icons;

    void Start()
    {
        _ibisA = GameObject.Find("ibisA");
        //hasCheck = false;
        lastTurn = 4;

        _Obj_icons = GameObject.Find("Lists").GetComponent<Obj_icons>();

        for (int i = 0; i < lastTurn; i++)
        {
            GameObject trap_hp = Instantiate(Resources.Load("goj/HP-dot-Red")) as GameObject;
            trap_hp.transform.position = transform.position;
            trap_hp.transform.localScale = new Vector3(2f, 2f, 2f);
            trap_hp.transform.SetParent(transform);
            trap_hp.GetComponent<SpriteRenderer>().sprite = _Obj_icons.trapHP[i];
            trap_hp.name = "trapHP" + i.ToString();

        //    faceToCamera sc = trap_hp.AddComponent<faceToCamera>() as faceToCamera;


        }
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
