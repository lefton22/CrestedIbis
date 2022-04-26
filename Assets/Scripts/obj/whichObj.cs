using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whichObj : MonoBehaviour
{
    public int which; // 1= food, 2= npc, 3= nest, 4= human-made building, 5 = building material...
    //public GameObject whichGoj;

    listObjOnLand _listObjOnLand;

    int random_index;
    void Start()
    {
        _listObjOnLand = GameObject.Find("Lists").GetComponent<listObjOnLand>();
        random_index = -1;

        if (which == 1) 
        { GetComponent<objFood>().enabled = true;

            Destroy(GetComponent<objNPC>());
            Destroy(GetComponent<objNest>());
            Destroy(GetComponent<objEgg>());
            tag = "food";
        }
        if (which == 2) 
        {
            Destroy(GetComponent<objFood>());
            GetComponent<objNPC>().enabled = true;
            Destroy(GetComponent<objNest>());
            Destroy(GetComponent<objEgg>());
            tag = "npc";
        }
        if (which == 3)
        {
            Destroy(GetComponent<objFood>());
            Destroy(GetComponent<objNPC>());
            GetComponent<objNest>().enabled = true;
            Destroy(GetComponent<objEgg>());
            tag = "nest";
        }
        if (which == 4)
        {
            Destroy(GetComponent<objFood>());
            Destroy(GetComponent<objNPC>());
            Destroy(GetComponent<objNest>());
            Destroy(GetComponent<objEgg>());
            tag = "humanStaff";
        }
        if (which == 5)
        {
            Destroy(GetComponent<objFood>());
            Destroy(GetComponent<objNPC>());
            Destroy(GetComponent<objNest>());
            Destroy(GetComponent<objEgg>());
            tag = "material";
        }

        /*        foreach (string s in _listObjOnLand.objOnLand)
                {
                    print(" _listObjOnLand: " + s);
                }*/
    }

    //to define which obj exactly
    //1=rich food , 2= ave food ,3= poor food,,,,
    // 6= neutral NPC, 7 = mal NPC, 
    //11 = nest
    //16 = human-made building
    //21 = building material

    void range_e_index(int a, int b, int _which)
    {
        random_index = Random.Range(a, b);
       print(" _listObjOnLand: " + _listObjOnLand.objOnLand);


   
        print("name: " + _listObjOnLand.objOnLand.Count);
        name = _listObjOnLand.objOnLand[random_index];
        
        which = _which;
    }
    //////////////////
    public void richFood()
    {
 /*       random_index = Random.Range(0, 8);
        name = _listObjOnLand.objOnLand[random_index];
        which = 1;*/


      //  range_e_index(0, 8, 1);

        GetComponent<objFood>().rich = 3;
    }

    public void aveFood()
    {
       // range_e_index(9, 11, 1);

        GetComponent<objFood>().rich = 2;
    }

    public void poorFood()
    {
      //  range_e_index(12, 12, 1);

        GetComponent<objFood>().rich = 1;
    }

/*    public void goodNPC()
    {
    }*/

    public void neutralNPC()
    {
        range_e_index(16, 19, 2);

        //???
    }

    public void malNPC()
    {

        range_e_index(20, 21, 2);
        ////???...
    }

    public void nest()
    {
        range_e_index(22, 22, 3);

        ///properties are on nest itself
    }

    public void building()
    {
        range_e_index(23, 23, 4);

        //???...
    }

    public void material()
    {
        range_e_index(14, 15, 5);

        //???...
    }

 

}
