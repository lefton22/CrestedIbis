using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;



//check grid旋转的问题//
//继续生成河流的问题
//接下来随机生成其它格子

//继续第2Gen的首尾端不对//
//计算不对

public class LandGeneration : MonoBehaviour
{
    public List<Vector3> LandV3s;

    public List<Vector2> LandCos;
    public List<GameObject> LandCos_GO;
    public List<bool> LandCos_hasHex;

    float offSetY;
    float offSetZ;

    Vector3 V3firstGrid;

    public int offset_weight_river;

    Vector2 v2_1stRiver;

    GameObject lastRiver;

    int lastRiver_tail;

    void Start()
    {
/*     Debug.Log(Check6Grids(1, new Vector2(0, 0)));
        Debug.Log(Check6Grids(2, new Vector2(0, 0)));
        Debug.Log(Check6Grids(3, new Vector2(0, 0)));
        Debug.Log(Check6Grids(4, new Vector2(0, 0)));
        Debug.Log(Check6Grids(5, new Vector2(0, 0)));
        Debug.Log(Check6Grids(6, new Vector2(0, 0)));*/

        LandV3s = new List<Vector3>();
        LandV3s.Clear();

        LandCos = new List<Vector2>();
        LandCos.Clear();
        LandCos_GO = new List<GameObject>();
        LandCos_GO.Clear();
        LandCos_hasHex = new List<bool>();
        LandCos_hasHex.Clear();

        for (int i = 0; i < 19; i++)
        {
            LandCos_hasHex.Add(false);
        }


        offSetY = 1.025f;
        offSetZ = 0.14f;

        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("land"))
        {
            if (!LandV3s.Contains(obj.transform.position))
            {
                LandV3s.Add(obj.transform.position);

            }

            if (!LandCos.Contains(obj.GetComponent<genPos>().thisCo))
            {
                LandCos.Add(obj.GetComponent<genPos>().thisCo);
                //Debug.Log("genPos" +"( "+obj.name+" )"+ obj.GetComponent<genPos>().thisCo);
            }
            if (!LandCos_GO.Contains(obj))
            {
                LandCos_GO.Add(obj);
                // Debug.Log("LandCos_GO: "+ obj.name);
            }
            // Debug.Log(obj.name);
        }

        lastRiver_tail = 0;

        GenLand();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void GenLand()
    {
        // identify range
        // set   先随机是否某一格有河流，有的话逐格生成完毕
        ///     查找剩下的格子生成其它地形
        ///river

        V3firstGrid = LandV3s[Random.Range(0, LandV3s.Count)];
        GameObject obj = Instantiate(Resources.Load("hex_grid_0")) as GameObject;

        ///Start///generate 1st river//////////
        ////Start/////generate 1st ////////////

        int r_index;
        r_index = Random.Range(0, LandCos.Count + offset_weight_river);

        r_index = Random.Range(0, LandCos.Count);//

        if (r_index < LandCos.Count)
        {
            v2_1stRiver = LandCos[r_index];

            string river_name;
            river_name = "river_grid_" + GameObject.Find("Lists").GetComponent<listObjOnLand>().riverGridsSuffix[Random.Range(0, 11)];
            //Debug.Log("river_name: " + river_name);
            GenHexGrid(LandCos_GO[r_index], "river", 1, river_name);

            LandCos_hasHex[r_index] = true;
            // Debug.Log("v2_1stRiver <LandCos.Count,  so gen a river : " + v2_1stRiver);
            Debug.Log("-1st river: " + river_name);

            ///End///generate 1st river///////////
            ////End/////generate 1st river//////////

            ///Start///continue to generate river//////////
            ////Start/////continue to generate river ////////////

            int times_gen;
            times_gen = Random.Range(0,5);// 0-5次，一次1个
            times_gen = 5;//
            Debug.Log("Gen " + times_gen +" times.");

            for (int i = 0; i < times_gen; i++)
            {

                //generate next river grid
                // need to define it as a river grid and give it the river dir art asset
                //equals to above gameObject gened





                int r_here;
                //r_here = Random.Range(1,2);

                r_here = 1;//

                if (r_here == 1) //若只有一端有生成
                {
                    // the last river has  two ends, gen two river according to this two ends 
                    int ori_dir1;
                    int ori_dir2;
                    ori_dir1 = lastRiver.GetComponent<grid>()._d1;
                    ori_dir2 = lastRiver.GetComponent<grid>()._d2;
                    Debug.Log("ori_dir1: " + ori_dir1);
                    Debug.Log("ori_dir2: " + ori_dir2);

                    int next_dir1;
                    int next_dir2;

                    // find the river asset which has the correct figure suffix

                    next_dir1 = NextRiverDir(ori_dir1);
                    next_dir2 = NextRiverDir(ori_dir2);

                    Debug.Log(" next_dir1: " + next_dir1);
                    Debug.Log(" next_dir2: " + next_dir2);


                    List<int> randomTwo;
                    randomTwo = new List<int>();
                    randomTwo.Add(lastRiver.GetComponent<grid>()._d1);
                    randomTwo.Add(lastRiver.GetComponent<grid>()._d2);

                    int amount_branch_river;
                    amount_branch_river = randomTwo[Random.Range(0, randomTwo.Count)];

                    // Debug.Log("amount_branch_river: " + amount_branch_river).
                    randomTwo.Clear();

                    //得到位置
                    Vector2 v2;
                    v2 = Check6Grids( amount_branch_river, v2_1stRiver); // random dir = amount///!!!???

                    //得到LIST中的位置
                    int index_v2;
                    index_v2 = LandCos.IndexOf(v2);//index in the list

                    Debug.Log("this river's end: " + amount_branch_river);

                    string as_name;
                    // dir1, dir2 顺序可以互调
                    as_name = "0";
/*                    int r1;
                    r1 = Random.Range(1,2); //?!将得到得已知端随机放前或放后*/
                    List<int> oneToSix;
                    oneToSix = new List<int>();
                    oneToSix.Add(1); oneToSix.Add(2); oneToSix.Add(3); oneToSix.Add(4); oneToSix.Add(5); oneToSix.Add(6);

                    //应先根据next_dir1确定一个,剩下的一个随机
                    if (oneToSix.Contains(next_dir1))
                    { oneToSix.Remove(next_dir1); }
                    next_dir2 = oneToSix[Random.Range(0, oneToSix.Count)];

                    if (next_dir1 < next_dir2)
                    { 
                    }
                    if (next_dir1 > next_dir2)
                    {
                        int _n_dir1; int _n_dir2;
                        _n_dir1 = next_dir1; _n_dir2 = next_dir2;
                        next_dir2 = _n_dir1; next_dir1 = _n_dir2;
                    }

                    as_name = "river_grid_" + next_dir1.ToString() + "_" + next_dir2.ToString();
                    ////??!
/*                    if (r1 == 1)
                    {
                           // Debug.Log("r1, " + "next_dir1:" + next_dir1);
                        as_name = "river_grid_" + next_dir1.ToString() + "_" + next_dir2.ToString();
                    }
                    if (r1 ==2)
                    {
                      //  Debug.Log("r2");
                        as_name = "river_grid_" + next_dir2.ToString() + "_" + next_dir1.ToString(); }*/

                    oneToSix.Clear();
                  //   Debug.Log("as_name: "+ as_name);

                    //Debug.Log("index_v2: " + index_v2);
                    //  Debug.Log(" has there a river grid before: " + LandCos_hasHex[index_v2]);
                    if (index_v2 > 0 && !LandCos_hasHex[index_v2]) // also not be generate there before
                    {

                        GenHexGrid(LandCos_GO[index_v2], "river2", 1, as_name);

                        LandCos_hasHex[index_v2] = true;
                        Debug.Log(i+"st , " + "to gen a river, its name is " + as_name);
                    }

                }

            }

               

            ///End///continue to generate river//////////
            ////End/////continue to generate river ////////////

        }
        if (r_index >= LandCos.Count)
        {
            v2_1stRiver = new Vector2(9999f, 999f);
            Debug.Log("v2_1stRiver <LandCos.Count. No river gened");
        }

        ////gen the rest type of grid on the rest empty grids.
        ///riverside        
        ///pool
        ///field
        ///dry land, idle dry land, dry land field, slope with grass,grass land, tree land, tree with nest,
        ///


        if (LandCos_hasHex.Count > 0)
        {
            for (int i = 0; i < LandCos_hasHex.Count; i++)
            {
               
               // Debug.Log("LandCos_hashex: " + LandCos_hasHex[i]);
                if (LandCos_hasHex[i] == false)
                {
                    int index_r;
                    listObjOnLand _listObjOnLand;
                    _listObjOnLand = GameObject.Find("Lists").GetComponent<listObjOnLand>();
                    index_r = Random.Range(0, _listObjOnLand.LandType.Count);
                    string name_r;
                    name_r = _listObjOnLand.LandType[index_r];

                    //Debug.Log("name_r "+ i+ "st: " + name_r);

                    GenHexGrid(LandCos_GO[i], name_r, 1, name_r); 

                }
            }
        }

       

    }

    Vector2 Check6Grids(int dir, Vector2 v2_ori) // dir means 6 directions around a grid
                                                 // to find out your goal's grid's co.
    {
        ///left up:1
        ///right up: 2
        ///right:3
        ///right down: 4
        ///left down:5
        ///left: 6
        if (dir > 6 || dir < 1)
        { Debug.Log("dir is out of range."); }

        Vector2 check6Grids;
        check6Grids = new Vector2(99f, 99f);
        if (dir == 1)
        { check6Grids = new Vector2(v2_ori.x, v2_ori.y + 1); }
        if (dir == 2)
        { check6Grids = new Vector2(v2_ori.x - 1, v2_ori.y + 1); }
        if (dir == 3)
        { check6Grids = new Vector2(v2_ori.x - 1, v2_ori.y); }
        if (dir == 4)
        { check6Grids = new Vector2(v2_ori.x, v2_ori.y - 1); }
        if (dir == 5)
        { check6Grids = new Vector2(v2_ori.x + 1, v2_ori.y - 1); }
        if (dir == 6)
        { check6Grids = new Vector2(v2_ori.x + 1, v2_ori.y); }

        return check6Grids;
    }

    int NextRiverDir(int next1)
        {
        int nextRiverDir;
        nextRiverDir = 0;
        if (next1 < 4 && next1 > 0)
        { nextRiverDir = next1 + 3; }
        if(next1 >3 && next1 <7)
            { nextRiverDir = next1 - 3; }
        return nextRiverDir;
        }

    void GenHexGrid(GameObject land, string name, int amount, string asset_name) // land means the hex grid attached to
                                                                                                                                                 //name means new gameobject's name
    {
        //gen

        GameObject grid_2d = Instantiate(Resources.Load(asset_name)) as GameObject;
        //need to gen exactly hex sprite//

        
        //in Hierarchy, position
        grid_2d.transform.SetParent(land.transform);
        grid_2d.transform.position = new Vector3(land.transform.position.x, land.transform.position.y, land.transform.position.z - offSetZ);


        //rotation


        Vector3 eulerRotation = grid_2d.transform.rotation.eulerAngles;
        grid_2d.transform.rotation = Quaternion.Euler(eulerRotation.x, eulerRotation.y, 35f);


        lastRiver = grid_2d;

        Debug.Log("last river: " + lastRiver);

       // Debug.Log("Gen a grid on " + land.name);
    }
}
