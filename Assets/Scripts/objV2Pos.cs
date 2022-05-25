using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//for any GameObject to get its Vector2

public class objV2Pos : MonoBehaviour
{
    public Vector2 thisV2;
    listObjOnLand _listObjOnLand;
    Panda.Ibis.MyIbis _myIbis;

    Vector3 ori_Rotation;
    void Start()
    {
        _listObjOnLand = GameObject.Find("Lists").GetComponent<listObjOnLand>();

        _myIbis = GameObject.Find("ibisA").GetComponent<Panda.Ibis.MyIbis>();

      //  ori_Rotation = transform.localRotation.eulerAngles;
    }

    void Update()
    {
      //  if (gameObject.name != "ibisA")
       // transform.localEulerAngles= ori_Rotation;
        transform.localEulerAngles = new Vector3(0f,0f,-18f);


    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "land" )
        {
            thisV2 = collision.gameObject.GetComponent<genPos>().thisCo;
            if (gameObject.tag == "food")
            {

                if (!_listObjOnLand.foodOnLand.Contains(thisV2))
                {
                    _listObjOnLand.foodOnLand.Add(thisV2);
                }
                if (!_listObjOnLand.foodOnLand_GO.Contains(gameObject))
                {
                    _listObjOnLand.foodOnLand_GO.Add(gameObject);
                }

            }
            if (!_myIbis.landsPassThrough.Contains(collision.gameObject) && gameObject.tag =="mainIbis")
            {
               // print("add a land into passthrough 1.");
                _myIbis.landsPassThrough.Add(collision.gameObject);

              
            }

            if (_myIbis.landsPassThrough.Contains(collision.gameObject) &&
                _myIbis.landsPassThrough[_myIbis.landsPassThrough.Count - 1] != collision.gameObject &&
                 gameObject.tag == "mainIbis")
            {
               // print("add a land into passthrough 2.");
                _myIbis.landsPassThrough.Add(collision.gameObject);

               
            }


            /*            if (gameObject.tag == "mainIbis")
                        { 

                        }*/
           // Debug.Log("touch the land");
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "land" )
        {
            if (gameObject.tag == "food" )
            {
                if (_listObjOnLand.foodOnLand.Contains(thisV2))
                {
                    _listObjOnLand.foodOnLand.Remove(thisV2);
                }
                if (_listObjOnLand.foodOnLand_GO.Contains(gameObject))
                {
                    _listObjOnLand.foodOnLand_GO.Remove(gameObject);
                }
            }
        }
    }
}
