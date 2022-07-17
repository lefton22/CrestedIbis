using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grid : MonoBehaviour
{

    //Land Type: (on GameObject: Lists)
    //0  dryLand
    //1  idleDryLand
    //2  dryLandField
    //3  slopeWithGrass
    //4  grassLand
    //5  treeLand
    //6  treeWithNest

    //7  river

    //8 polluted grass land

   public  int landType;
    bool isRiver;

    int dir1;// river's direction1 
    int dir2;

/*    public char d1;
    public char d2;
    public char d3;
    public char d4;*/

    public int _d1;
    public int _d2;

    public bool canRichFood;
    public bool canAveFood;
    public bool canPoorFood;

    public bool canNPC;
    public bool canNest;
    public bool canHumanMade;
    public bool canBuildingMaterial;
    

    public bool hasPolluted;

    void Start()
    {
        getLandType("dryLand", 0);
        getLandType("idleDryLand", 1);
        getLandType("dryLandField", 2);
        getLandType("slopeWithGrass", 3);
        getLandType("grassLand", 4);
        getLandType("treeLand", 5);
        getLandType("treeWithNest", 6);
        // 

        if (gameObject.GetComponent<riverLand>() != null)
        {  isRiver = true;  }
        else { isRiver = false; }

        if (isRiver) { landType = 7; }
    }

    void getLandType(string name, int type)
    {
        if (gameObject.name == name)
        { landType = type; }
    }
    public void polluteThis()
    {
        if (landType == 3)
        {
            hasPolluted = true;

            //play pollution ani
            GameObject pollution_PU = Instantiate(Resources.Load("goj/popup-pollution")) as GameObject;
            pollution_PU.transform.position = gameObject.transform.position;

            //change sprite
        }
        if (landType == 4)
        {
            hasPolluted = true;

            //play pollution ani
            GameObject pollution_PU = Instantiate(Resources.Load("goj/popup-pollution")) as GameObject;
            pollution_PU.transform.position = gameObject.transform.position;

            //change sprite}
        }

        if (landType == 7) // river
        {
            hasPolluted = true;

            //play pollution ani
            GameObject pollution_PU = Instantiate(Resources.Load("goj/popup-pollution")) as GameObject;
            pollution_PU.transform.position = gameObject.transform.position;

            //change sprite}
        }

        print("pollute " + gameObject.name +" .");
    }

        public void checkHasPolluted()// check after evevry turn's get pollution turn
                                      // -> may change the landtype
                                      // -> may pollute the food(fish, crickets..)
                                      // -> may reduce the quality of the food
    {
                if (hasPolluted)
                {
                    print(gameObject.name + " has checked as being polluted.");
                    //change the sprite


                    //change the landtype
                    if (landType == 3 || landType == 4)
                    {
                        landType = 8;
                    }

                    //pollute the food
                    Vector2 v2_thisLand;
                    v2_thisLand = transform.parent.gameObject.GetComponent<genPos>().thisCo;

                    foreach (Transform child in GameObject.Find("ObjOnLand").transform)
                    {
                        if (child.gameObject.GetComponent <objV2Pos>().thisV2
                              == v2_thisLand && child.gameObject.tag == "food")
                        {
                            // obj's sprite change
                            gameObject.GetComponent<SpriteRenderer>().color = new Color(1f, 0.3f, 0.5f, 1);

                            //play pollution ani ===> should be food be polluted ani
                            GameObject pollution_PU = Instantiate(Resources.Load("goj/popup-pollution")) as GameObject;
                            pollution_PU.transform.position = gameObject.transform.position;

                            // obj's food's rich change; isToxic = true
                            child.gameObject.GetComponent<objFood>().getPolluted();
                        }
                    }

                }
    }

    public void getNPCPolluted() // NPC, obj get effect from the pollution
                                        // check when every NPC, obj end moving
    {
        if (hasPolluted)
        {
            
        }
    }

    void OnCollisionEnter(Collision collision)
    {
       // Debug.Log( gameObject.name +"'s collision: " +collision.gameObject.name);
    }

    void OnCollisionExit(Collision collision)
    { }

}