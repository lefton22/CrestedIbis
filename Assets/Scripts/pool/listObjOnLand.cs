using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listObjOnLand : MonoBehaviour
{
    public List <string> objOnLand; //not only foods,
    //public List <string>

    public List<string> LandType;// except type like river,pool...

    public List<string> riverGridsSuffix;

    public List<string> poolLandName;

    public List<string> landNameThisTurn;



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
        landNameThisTurn = new List<string>();

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

        poolLandName.AddMany("刘庄村", "乡桂沟", "白火石沟", "刘家沟", "张赵村", "高家河水库", "党河", "贯溪", "范坝河",
            "石槽河乡","毕家河乡","大爷山","若陀","山后村","方湾","柳家沟","刘杨村", "陈家河", "诸葛岭", "红庙沟", "白家坪", "头道岭", "李家院", "李家山", "道士岩", "小龙山", "石四湾", "代家沟", "前次湾", "马道村", "鹰岩沟", "水甜地", "韩家岭",
            "二道岭", "庄房", "杜家槽", "胡家沟", "鸭河", "何沟", "小垭", "马梁", "胡家沟", "天星窝", "代家沟", "天星窝", "雷家沟", "边沟", "马面", "史家村", "龙窝", "唐经寺", "各伴沟", "姚家沟", "大沟", "东沟", "瓦屋", "鼓儿坪", "新渔坝", "小沟村",
            "大沟村", "三叉河", "高坡", "黄滩", "大黄", "黑湾", "竹园沟", "蔡家河");
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
