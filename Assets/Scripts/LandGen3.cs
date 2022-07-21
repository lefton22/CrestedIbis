using System.Collections;
using System.Collections.Generic;
using UnityEngine;




/// <summary>
/// ///ʣ�¼���β�Ӷ˵�������β������Ч��
/// </summary>
public class LandGen3 : MonoBehaviour
{
    public List<Vector3> LandV3s; //�����е����꼯

    public List<Vector3> LandCos; //����ϵ��
    public List<GameObject> LandCos_GO; //����ϵ���ϵ���Ϸ�����
    public List<bool> LandCos_hasHex;//����������ɵ��θ�ģ������ǰ���LIST��Ӧ��

    float offSetY;
    float offSetZ;

    Vector3 V3firstGrid;

    public int offset_weight_river;

    Vector2 v2_1stRiver;

    GameObject lastRiver;
    int lastRiver_dir2;

    listObjOnLand _listObjOnLand;

    public int TimesGen;//���ɵ�һ����������ɼ���

    void Start()
    {
        LandV3s = new List<Vector3>();
        LandV3s.Clear();

        LandCos = new List<Vector3>(); // ori is V2
        LandCos.Clear();
        LandCos_GO = new List<GameObject>();
        LandCos_GO.Clear();
        LandCos_hasHex = new List<bool>();
        LandCos_hasHex.Clear();

        _listObjOnLand = GameObject.Find("Lists").GetComponent<listObjOnLand>();

        for (int i = 0; i < 19; i++)
        {
            LandCos_hasHex.Add(false);
        }

        offSetY = 1.025f;
        offSetZ = 0.14f;

        foreach (GameObject obj in GameObject.FindGameObjectsWithTag("Respawn")) // ori '' = "land"
        {
            if (!LandV3s.Contains(obj.transform.position))
            {
                LandV3s.Add(obj.transform.position);

            }

            if (!LandCos.Contains(obj.transform.position) )// but v2 to v3?
            {
                LandCos.Add(obj.transform.position);
                //Debug.Log("genPos" +"( "+obj.name+" )"+ obj.GetComponent<genPos>().thisCo);
            }
            if (!LandCos_GO.Contains(obj))
            {
                LandCos_GO.Add(obj);
                // Debug.Log("LandCos_GO: "+ obj.name);
            }
            // Debug.Log(obj.name);

            //enable all the meshes

            // obj.GetComponent<MeshRenderer>().enabled = false;

        }

        GenLand();
    }

    void GenLand()
    {
        /////////////// gen 1st//
        //////////////// gen 1st//
        int r_index_1;
        r_index_1 = Random.Range(0, LandCos_GO.Count);

        LandCos_hasHex[r_index_1] = true;

        string r_name;
        r_name = _listObjOnLand.riverGridsSuffix[Random.Range(0, 14)];

        GenHexGrid(LandCos_GO[r_index_1], "river_grid_" + r_name, 999);

        print("gen 1st river.");

        ////////// // gen 1st//
        ///////// // gen 1st//
        ///
        ///////// Continue to Gen///////////
        ///////// Continue to Gen///////////

        /*        int _timesGen;
                _timesGen = Random.Range(0, TimesGen);*/

        for (int i = 0; i < TimesGen; i++)
        {

             Debug.Log(i + ": " + "last river: " + lastRiver);

            // Get Land attached,  Get Terminals
            int terNextofThisGrid;
            terNextofThisGrid = 999;
            if (i == 0)
            {
                int ori_dir1;
                int ori_dir2;
                ori_dir1 = lastRiver.GetComponent<grid>()._d1;
                ori_dir2 = lastRiver.GetComponent<grid>()._d2;
                 Debug.Log(i + ": " + " ori_dir1 : " + ori_dir1 + ", ori_dir2 : " + ori_dir2);


                //determine the attached terminal to the next river grid OF NEXT GRID

                int r1;
                r1 = Random.Range(0, 1);
                if (r1 == 0)
                { terNextofThisGrid = ori_dir1; }
                if (r1 == 1)
                { terNextofThisGrid = ori_dir2; }
                            Debug.Log("terNext of this grid : " + terNextofThisGrid);
            }
            if (i != 0)
            {
                int ori_dir1;

                ori_dir1 = lastRiver_dir2;
                  Debug.Log("last River's dir2 in this grid: " + ori_dir1);
                List<int> restSix;
                restSix = new List<int>();
                for (int p = 0; p < 6; p++)
                { restSix.Add(p); }
                if (ori_dir1 > 0 && ori_dir1 < 7)
                { restSix.Remove(ori_dir1); }
                terNextofThisGrid = restSix[Random.Range(0, restSix.Count)];


                terNextofThisGrid = lastRiver_dir2;
            }




            int cur_dir1;// will gen this time

            cur_dir1 = NextRiverDir(terNextofThisGrid);

            /*            Debug.Log(" cur_dir1 : " + cur_dir1);*/

            //check which only Vec2 can attach this terminal


            Vector3 ori_v3; // ori is ori_v2 Vector2
            ori_v3 = LandCos[r_index_1]; ////!!!???

            if (i != 0)
            {

                //get lastRiver's index;
                int index_lastRiver;
                index_lastRiver = LandCos_GO.IndexOf(lastRiver.transform.parent.gameObject);
                  Debug.Log("get lastRiver's index: " + index_lastRiver);

                ori_v3 = LandCos[index_lastRiver];
                   Debug.Log("lastRiver's V3 : " + index_lastRiver);
            }

            Vector3 cur_v3; // ori is cur_v2 Vector2
            cur_v3 = Check6Grids(terNextofThisGrid, ori_v3);

            //Debug.Log(i + ": " + "cur_v3: " + cur_v3);

            //Get the Land index
            int index_v2;
            index_v2 = LandCos.IndexOf(cur_v3);
            /*            Debug.Log("index_v2: " + index_v2);*/

            if (index_v2 < 0) { /*Debug.Log("����"); */}
            if (index_v2 > -1) //��δ����
            { // Get the cur_dir2
                List<int> restDir;
                restDir = new List<int>();
                for (int k = 1; k < 7; k++)
                {
                    restDir.Add(k);
                }
                restDir.Remove(cur_dir1);

                int cur_dir2;
                cur_dir2 = restDir[Random.Range(0, restDir.Count)];
                /*                Debug.Log("cur_dir2: " + cur_dir2);*/
                int _cur_dir2;
                _cur_dir2 = cur_dir2;

                // Gen
                if (cur_dir1 > cur_dir2)
                {
                    int _dir1; int _dir2;
                    _dir1 = cur_dir2; _dir2 = cur_dir1;
                    cur_dir1 = _dir1; cur_dir2 = _dir2;
                }

                string name;
                name = "river_grid_" + cur_dir1.ToString() + "_" + cur_dir2.ToString();
                  Debug.Log(i + ": " + "cur gen river name: " + name);

                if (!LandCos_hasHex[index_v2])
                {
                    Debug.Log("river: " +i + ": " + "attach this obj to gen: " +LandCos_GO[index_v2].name);

                    GenHexGrid(LandCos_GO[index_v2], name, _cur_dir2);
                    LandCos_hasHex[index_v2] = true;
                }
            }
        }
        ///////// Continue to Gen///////////
        ///////// Continue to Gen///////////
        ///


        ///////// Gen the Rest//////Start////
        ///////// Gen the Rest//////Start////
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

                    GenHexGrid(LandCos_GO[i], name_r, 999);

                }
            }

        }

        ///////// Gen the Rest//////End////
        ///////// Gen the Rest//////End////

    }


    void GenHexGrid(GameObject land, string asset_name, int curTerminal) // land means the hex grid attached to
                                                                         //name means new gameobject's name
                                                                         // asset_name can identify the two terminals of the river 
                                                                         //curTerminal: ��һ��Ҫ���ɵģ�����һ�����ӵ����������λ��
    {
        //gen

        GameObject grid_2d = Instantiate(Resources.Load(asset_name)) as GameObject;
        //need to gen exactly hex sprite//


        //in Hierarchy, position
        grid_2d.transform.SetParent(land.transform);
        grid_2d.transform.position = new Vector3(land.transform.position.x, land.transform.position.y, land.transform.position.z - offSetZ);

        grid_2d.name = asset_name;

        //rotation


        Vector3 eulerRotation = grid_2d.transform.rotation.eulerAngles;
        // grid_2d.transform.rotation = Quaternion.Euler(eulerRotation.x, eulerRotation.y, 31.55f);
        grid_2d.transform.localScale = new Vector3(1.85f, 1.85f, 0.5f);

        lastRiver = grid_2d;
        lastRiver_dir2 = curTerminal;

      //  Debug.Log("last river: " + lastRiver);

         Debug.Log("Gen a grid on " + land.name);
    }

    int NextRiverDir(int next1)
    {
        int nextRiverDir;
        nextRiverDir = 0;
        if (next1 < 4 && next1 > 0)
        { nextRiverDir = next1 + 3; }
        if (next1 > 3 && next1 < 7)
        { nextRiverDir = next1 - 3; }
        return nextRiverDir;
    }


    // big pos problem here!
    Vector2 Check6Grids(int dir, Vector3 v3_ori) // dir means 6 directions around a grid
                                                 // to find out your goal's grid's co.
    {
        ///left up:1
        ///right up: 2
        ///right:3
        ///right down: 4
        ///left down:5
        ///left: 6
        if (dir > 6 || dir < 1)
        { /*Debug.Log("dir is out of range.");*/ }

        Vector3 check6Grids;
        check6Grids = new Vector3(99f, 99f, 0f);
        if (dir == 1)
        { check6Grids = new Vector3(v3_ori.x -0.5f, v3_ori.y + 0.8f); }
        if (dir == 2)
        { check6Grids = new Vector3(v3_ori.x + 0.5f, v3_ori.y + 0.8f); }
        if (dir == 3)
        { check6Grids = new Vector3(v3_ori.x +1f, v3_ori.y); }
        if (dir == 4)
        { check6Grids = new Vector3(v3_ori.x +0.5f, v3_ori.y - 0.8f); }
        if (dir == 5)
        { check6Grids = new Vector3(v3_ori.x - 0.5f, v3_ori.y - 0.8f); }
        if (dir == 6)
        { check6Grids = new Vector3(v3_ori.x - 1f, v3_ori.y); }

        return check6Grids;
    }
}