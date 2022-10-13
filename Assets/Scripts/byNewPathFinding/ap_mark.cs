using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ap_mark : MonoBehaviour
{
    public int land; 
        void Start()
        {
        
        }

    void OnCollisionEnter(Collision col) 
    {
            if (col.gameObject.name == "ibisA" 
            &&  GameObject.Find("thisTurn(Clone)").GetComponent<Panda.Ibis.MyTurn>().canDetectAPMark)
            {
                    print("ap_mark: ibisA collides with : " + name);
        // -AP
        Panda.Ibis.MyIbis.actionPoint = Panda.Ibis.MyIbis.actionPoint - 1;
            //disable the collider
            // gameObject.GetComponent<SphereCollider>().enabled = false;
            }
    }

    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.name == "ibisA")
        {
            print("ap_mark: ibisA exits : " + name);
        }
    }
}
