using System.Collections;
using System.Collections.Generic;
using UnityEngine;



//for any GameObject to get its Vector2

public class objV2Pos : MonoBehaviour
{
    public Vector2 thisV2;
    public string thisLand;

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

       // transform.localEulerAngles = new Vector3(0f,0f,-18f);


    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Respawn" )
        {
            thisV2 = collision.gameObject.GetComponent<genPos>().thisCo;

            thisLand = collision.gameObject.GetComponent<genPos>().landName;

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

                if (!GameManager.istance.foodsNav.Contains(collision.gameObject.GetComponent<Nav>()))
                {
                    int index = Map.instance.transferV2ToIndex(thisV2);
                    GameManager.istance.foodsNav[index] =collision.gameObject.GetComponent<Nav>();
                }

            }
/*  old pathfinding calculate action point
            if (!_myIbis.landsPassThrough.Contains(collision.gameObject) && gameObject.tag =="mainIbis")
            {
                // print("add a land into passthrough 1.");

                if (_myIbis.landsPassThrough.Count != 0)
                { Panda.Ibis.MyIbis.actionPoint = Panda.Ibis.MyIbis.actionPoint - 1; }
                checkAP0(gameObject);

                _myIbis.landsPassThrough.Add(collision.gameObject);

              
            }

            if (_myIbis.landsPassThrough.Contains(collision.gameObject) &&
                _myIbis.landsPassThrough[_myIbis.landsPassThrough.Count - 1] != collision.gameObject &&
                 gameObject.tag == "mainIbis")
            {
                // print("add a land into passthrough 2.");

                if (_myIbis.landsPassThrough.Count != 0)
                { Panda.Ibis.MyIbis.actionPoint = Panda.Ibis.MyIbis.actionPoint - 1; }
                checkAP0(gameObject);

                _myIbis.landsPassThrough.Add(collision.gameObject);

               
            }*/


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

                if (GameManager.istance.foodsNav.Contains(collision.gameObject.GetComponent<Nav>()))
                {
                    int index = Map.instance.transferV2ToIndex(thisV2);
                    GameManager.istance.foodsNav[index] = collision.gameObject.GetComponent<Nav>();
                }
            }
        }
    }

/*    void checkAP0(GameObject ibisA) // if AP ==0, call "breakThisTurn()"
    {
        if (ibisA == GameObject.Find("ibisA"))
        {
            if (Panda.Ibis.MyIbis.actionPoint == 0)
            {
                gameObject.GetComponent<Panda.Ibis.MyIbis>().breakThisTurn();

                Debug.Log("AP = 0.");
              //  Panda.Ibis.MyIbis.breakThisTurn();
            }
        }
    }*/
}
