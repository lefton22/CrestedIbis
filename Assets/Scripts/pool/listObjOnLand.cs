using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listObjOnLand : MonoBehaviour
{
    public List <string> objOnLand; //not only foods,
    //public List <string>

    public List<string> LandType;// except type like river,pool...

    public List<string> riverGridsSuffix;





    // would change in run time
    public List<Vector2> foodOnLand; // record the current food occupy the land grid
    public List<GameObject> foodOnLand_GO;

    public List<bool> isObjOnLand; //indicate that if there is an obj on this grid. same index with LandGen2.LandCos

    public List<GameObject> NPCibisOnLand;

    public listObjOnLand(List<bool> isObjOnland)
    {
        this.isObjOnLand = isObjOnland;
    }

    void Start()
    {
        /*        foodOnLand = new List<Vector2>();
                foodOnLand.Clear();*/
        objOnLand = new List<string>();
        // jackDaw -> trapMan
        objOnLand.AddMany("loach", "crucian", "frog", "shrimp", "crab", "spiralShell", "shellFish",
            "snail", "cricket", "earthWorm", "rice", "bean", "treeSeed", "ibisEgg", "twig", "liana", "ibisAdult",
            "egret", "trapMan", "snake", "eagle", "nest", "cottage");

        NPCibisOnLand = new List<GameObject>();
        NPCibisOnLand.Clear();

        AddObjIntoList();

        // for(int i =0; i< GameObject.Find("LandGenerator").GetComponent<LandGen2>().LandCos.Count; i++)
        //Start oder problem

        for (int i = 0; i < 19; i++)
        {
            isObjOnLand.Add(false);
        }
      //  print(objOnLand[1]);
    }

    void AddObjIntoList() // this happened after drawing the card
    {
        //add all npc ibis
        GameObject[] NPCibisOnLand_array= GameObject.FindGameObjectsWithTag("ibis");
        for (int i = 0; i < NPCibisOnLand_array.Length; i++)
        {
            NPCibisOnLand.Add(NPCibisOnLand_array[i]);
        }
    }
}
