using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class allCheck : MonoBehaviour
{
    GameObject _NPCs;

    GameObject _ibisA;

    GameObject _ObjOnLand;

    void Start()
    {
        _NPCs = GameObject.Find("NPCs");
        _ibisA = GameObject.Find("ibisA");
        _ObjOnLand = GameObject.Find("ObjOnLand");

    }

    // Update is called once per frame
    void Update()
    {
        
    }



    ///check all of them everytimes some NPC or Ibis moves
    ///
    public void  check2NpcOnOneGrid(List<GameObject> _OnThis) // to check if there's NPC, ibis on this grid
                                                                                                 // check this when "v2 xx == v2 yy"
    {

        if (_OnThis.Count == 2)
        {
            // keep a distance

            float x0;
            x0 = _OnThis[0].transform.position.x;

            float x1;
            x1 = _OnThis[1].transform.position.x;

            _OnThis[0].transform.DOMoveX(x0 - 0.93f, 0.5f);
            _OnThis[1].transform.DOMoveX(x1 + 0.93f, 0.5f);
            //need to play ani?

            print(_OnThis[0].name + " and " + _OnThis[1].name + " keep distance.");
        }

        // >2??
    }

    public void checkNpcIbisOnAllGrids( ) // executed during drawCards
    {

        print("check all 0");

        GameObject[] lands;
        lands = GameObject.FindGameObjectsWithTag("land");
        
        foreach (GameObject land in lands)
        {
            land.GetComponent<genPos>().OnThis.Clear();

            print("check all 1");

          /// under NPCs(all other ibis)
            foreach (Transform child in _NPCs.transform) 
            {
                if (land.GetComponent<genPos>().thisCo == child.gameObject.GetComponent<objV2Pos>().thisV2)
                {
                    if (!land.GetComponent<genPos>().OnThis.Contains(child.gameObject))
                    {
                        land.GetComponent<genPos>().OnThis.Add(child.gameObject);

                        print("check all 2");
                    }
                }
            }

         /// ibisA
            if (land.GetComponent<genPos>().thisCo == _ibisA.GetComponent<objV2Pos>().thisV2) 
            {
                if (!land.GetComponent<genPos>().OnThis.Contains(_ibisA))
                {
                    land.GetComponent<genPos>().OnThis.Add(_ibisA);

                    print("check all 3");
                }
            }

        /// npc under ObjOnLand
        /// 
            foreach (Transform npc in _ObjOnLand.transform)
            {
                if (npc.transform.gameObject.GetComponent<whichObj>() && npc.transform.gameObject.GetComponent<whichObj>().which == 2)
                {
                    if (land.GetComponent<genPos>().thisCo == npc.gameObject.GetComponent<objV2Pos>().thisV2)
                    {
                        if (!land.GetComponent<genPos>().OnThis.Contains(npc.gameObject))
                        {
                            land.GetComponent<genPos>().OnThis.Add(npc.gameObject);

                            print("check all 4");
                        }
                    }
                }

            }
            
        }

        //thisGoj.GetComponent<gri>

    }
}
