using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class dragCard : MonoBehaviour
{
    private Vector3 mOffset;

    private float mZCoord;

    public  string objOnLandName;

    Color oriColor;

    Vector3 v3_ori;

    listObjOnLand _ListObjOnLand;
    LandGen2 _LandGen2;

    bool ifOverlap;
    bool isRightType;

     void Start()
    {
        v3_ori = transform.position;

        _ListObjOnLand = GameObject.Find("Lists").GetComponent<listObjOnLand>();
        _LandGen2 = GameObject.Find("LandGenerator").GetComponent<LandGen2>();

        ifOverlap = false;
        isRightType = false;
      //  transform.GetChild(0).gameObject.GetComponent<objV2Pos>().thisV2 = new Vector2(99f,99f);
    }


    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        mOffset = gameObject.transform.position - GetMouseWorldPos();

       // Debug.Log("Drag Mouse Down");
    }
    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;

        return Camera.main.ScreenToWorldPoint(mousePoint);
    }
    void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + mOffset;

        //当牌晃过来时，当前格子亮一下...
 
      //   Debug.Log("OnMouseDrag, " + gameObject.name);

        //Notification of Canput obj type

        bool richFood;
        bool aveFood;
        bool poorFood;
        bool NPC;
        bool nest;
        bool humanMadeBuilding;
        bool buildingMaterial;
        richFood = false;
        aveFood = false;
        poorFood = false;
        NPC = false;
        nest = false;
        humanMadeBuilding = false;
        buildingMaterial = false;
        
        if (transform.GetChild(0).gameObject.GetComponent<whichObj>().which == 1)
        {
            if (transform.GetChild(0).gameObject.GetComponent<objFood>().rich == 3) { richFood = true; }
            if (transform.GetChild(0).gameObject.GetComponent<objFood>().rich == 2) { aveFood = true; }
            if (transform.GetChild(0).gameObject.GetComponent<objFood>().rich == 1) { poorFood = true; }
        }
        if (transform.GetChild(0).gameObject.GetComponent<whichObj>().which == 2)
        { NPC = true; }
        if (transform.GetChild(0).gameObject.GetComponent<whichObj>().which == 3)
        { nest = true; }
        if (transform.GetChild(0).gameObject.GetComponent<whichObj>().which == 4)
        { humanMadeBuilding = true; }
        if (transform.GetChild(0).gameObject.GetComponent<whichObj>().which == 5)
        { buildingMaterial = true; }

        for (int i = 0; i < _LandGen2.LandCos_GO.Count; i++)
        {
            if (richFood && _LandGen2.LandCos_GO[i].transform.GetChild(0).gameObject.GetComponent<grid>().canRichFood)
                { _LandGen2.LandCos_GO[i].transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color(0.3f,0.3f,1,1);
                }
            if (aveFood && _LandGen2.LandCos_GO[i].transform.GetChild(0).gameObject.GetComponent<grid>().canAveFood)
                { _LandGen2.LandCos_GO[i].transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color(0.3f, 0.3f, 1, 1);
                }
            if (poorFood && _LandGen2.LandCos_GO[i].transform.GetChild(0).gameObject.GetComponent<grid>().canPoorFood)
                {_LandGen2.LandCos_GO[i].transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color(0.3f, 0.3f, 1, 1);
                }
            if (NPC && _LandGen2.LandCos_GO[i].transform.GetChild(0).gameObject.GetComponent<grid>().canNPC)
                {_LandGen2.LandCos_GO[i].transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color(0.3f, 0.3f, 1, 1);
            }
            if (nest && _LandGen2.LandCos_GO[i].transform.GetChild(0).gameObject.GetComponent<grid>().canNest)
            { _LandGen2.LandCos_GO[i].transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color(0.3f, 0.3f, 1, 1);
            }
            if (humanMadeBuilding && _LandGen2.LandCos_GO[i].transform.GetChild(0).gameObject.GetComponent<grid>().canHumanMade)
            {_LandGen2.LandCos_GO[i].transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color(0.3f, 0.3f, 1, 1);
            }
            if (buildingMaterial && _LandGen2.LandCos_GO[i].transform.GetChild(0).gameObject.GetComponent<grid>().canBuildingMaterial)
            {
                _LandGen2.LandCos_GO[i].transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color(0.3f, 0.3f, 1, 1);
            }
        }
    }

    private void OnMouseUp() // 鼠标起来的时候
    {
        for (int i = 0; i < _LandGen2.LandCos_GO.Count; i++)
        {

                _LandGen2.LandCos_GO[i].transform.GetChild(0).gameObject.GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, 1);

        }
        // delete the card objects
        // set the env object on the grid 

        //Debug.Log("OnMouseUp: " /*+ turnBased.MouseDrag_currentLand.name */);

        // turnBased.MouseUp_currentLand = null;


        if (turnBased.MouseUp_currentLand)
        {
            /////check if there is obj on the land to prevent from overlapping
                        transform.GetChild(0).transform.gameObject.GetComponent<objV2Pos>().thisV2 =
            turnBased.MouseUp_currentLand.GetComponent<genPos>().thisCo; //物品着陆

            int index_ifObj;
            index_ifObj = -1;
            for (int j = 0; j < _LandGen2.LandCos.Count; j++)
            {
                if (transform.GetChild(0).gameObject.GetComponent<objV2Pos>().thisV2
                                            == _LandGen2.LandCos[j])
                {
                    index_ifObj = j;
                    //print("index_ifObj :"+ index_ifObj ) ;
                   // print("cannot put 2 and index_ifObj: " + index_ifObj);
                }
            }

            for (int k = 0; k < _ListObjOnLand.isObjOnLand.Count; k++)
            {
                if (_ListObjOnLand.isObjOnLand[k] 
                    && k == index_ifObj) 
                {
                    ifOverlap = true;
                    transform.DOMove(v3_ori, 0.35f, false);
                    Debug.Log("cannot put this obj on this land.");
                }
            }

            ///Start
            //// check if it was the right land to put the right stuff on
               //  if (transform.GetChild(0).transform.gameObject.GetComponent<objV2Pos>)

            grid _grid;
            _grid = turnBased.MouseUp_currentLand.transform.GetChild(0).transform.gameObject.GetComponent<grid>();
            if (transform.GetChild(0).transform.gameObject.GetComponent<whichObj>().which == 1)
            {
                if (_grid.canRichFood && transform.GetChild(0).transform.gameObject.GetComponent<objFood>().rich == 3)
                {
                //    print("rich food.");
                    isRightType = true;
                }
                if (_grid.canAveFood && transform.GetChild(0).transform.gameObject.GetComponent<objFood>().rich == 2)
                {
               //     print("ave food.");
                    isRightType = true;
                }
                if (_grid.canPoorFood && transform.GetChild(0).transform.gameObject.GetComponent<objFood>().rich == 1)
                {
               //     print("poor food.");
                    isRightType = true;
                }

            }

            if (transform.GetChild(0).transform.gameObject.GetComponent<whichObj>().which == 2 && _grid.canNPC)
            {
              //      print("npc.");
                    isRightType = true;
            }
            if (transform.GetChild(0).transform.gameObject.GetComponent<whichObj>().which == 3 && _grid.canNest)
            {
              //  print("nest.");
                isRightType = true;
            }
            if (transform.GetChild(0).transform.gameObject.GetComponent<whichObj>().which == 4 && _grid.canHumanMade)
            {
              //  print("human-made building.");
                isRightType = true;
            }
            if (transform.GetChild(0).transform.gameObject.GetComponent<whichObj>().which == 5 && _grid.canBuildingMaterial)
            {
              //  print("building material.");
                isRightType = true;
            }

            //// check if it was the right land to put the right stuff on
            ///End

            if (!ifOverlap && isRightType)
            {
                for (int i = 0; i < _LandGen2.LandCos.Count; i++)
                {
                    if (turnBased.MouseUp_currentLand.GetComponent<genPos>().thisCo
                        == _LandGen2.LandCos[i])
                    {
                        _ListObjOnLand.isObjOnLand[i] = true;
                        //  print("cannot put 1");
                    } 
                }

             //   print("turnBased.MouseUp_currentLand: " + turnBased.MouseUp_currentLand);
                transform.GetChild(0).transform.position = turnBased.MouseUp_currentLand.transform.position;
                transform.GetChild(0).GetComponent<SnapToNode>().enabled = true;
                transform.GetChild(0).transform.gameObject.GetComponent<faceToCamera>().faceToCamera2();

                transform.GetChild(0).transform.SetParent(GameObject.Find("ObjOnLand").transform);


                Destroy(gameObject);
            }

            ifOverlap = false;

        }

        if (!turnBased.MouseUp_currentLand)
        {
            transform.DOMove(v3_ori, 0.35f, false);
        }

        if (!isRightType)
        {
            transform.DOMove(v3_ori, 0.35f, false);
        }
    }




}
