using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Panda;

using DG.Tweening;

namespace Panda.Ibis
{
    public class MyNPC : MonoBehaviour
    {
       static public bool end;

        static bool hasCheckDes;

        GameObject _ObjOnLand;

        GameObject _targetPos;

        GameObject _snake;

        GameObject _egg;

        GameObject _disappearLand;

        // GameObject _egret;
        public List<GameObject> _egrets;

        Vector2 v2_des;
        public List<Vector2> v2_dess;

        int trapMan_empty_index;

        GameObject _LandGenerator;
        LandGen2 _LandGen2;

        listObjOnLand _listObjOnLand;

        GameObject _trapMan;

        //Vector3 v3_trapMan;

        bool isSnake_seekNestWithEgg;

        GameManager  _Gamemanager;

        bool hasCheckMovingGoalIndex;

        void Start()
        {
            end = false;

            hasCheckDes = false;

            _ObjOnLand = GameObject.Find("ObjOnLand");

            _targetPos = GameObject.Find("Target2");

            _LandGenerator = GameObject.Find("LandGenerator");
            _LandGen2 = GameObject.Find("LandGenerator").GetComponent<LandGen2>();

            _listObjOnLand = GameObject.Find("Lists").GetComponent<listObjOnLand>();

            // v3_trapMan = new Vector3();

            _egrets = new List<GameObject>();
            v2_dess = new List<Vector2>();

            isSnake_seekNestWithEgg = false;

            trapMan_empty_index = -1;

            _Gamemanager = GameObject.Find("GameManager").GetComponent<GameManager>();

            hasCheckMovingGoalIndex = false;
        }


        void Update()
        {

        }


        [Task]
        void checkNoSnake() //没蛇就成功
        {
           
            int am_snake;
            am_snake = 0;
            foreach (Transform child in _ObjOnLand.transform)
            {
                if (child.gameObject.name == "snake")
                {
                    am_snake = am_snake + 1;
                    _snake = child.gameObject;
                    print("check no snake: " +_snake.name);
                }
            }
            if (am_snake > 0)
            {
                print("check has snake");
                ThisTask.Succeed();
            }
            else
            {
                print("check no snake");
                ThisTask.Fail(); }
        }

        [Task]
        void checkNest()
        {
            print("check nest");
            GameObject[] nests;
            nests = GameObject.FindGameObjectsWithTag("nest");
            if (nests.Length > 0)
            { ThisTask.Succeed(); }
            else { ThisTask.Fail(); }
        }

        [Task]
        void checkEggs()
        {
           

            GameObject[] eggs;
            eggs = GameObject.FindGameObjectsWithTag("egg");

            if (eggs.Length == 0)
            {
                Debug.Log("snake: check no egg.");
                ThisTask.Fail();
            }
            else
            {
                Debug.Log("snake: has egg.");
                ThisTask.Succeed(); }
        }

        [Task]
        void snake_seekNestWithEgg() // add a bool to this script to make sure this Task only execute for only once
        {

                int ran;
                ran = -1;

                GameObject[] eggs;
                eggs = GameObject.FindGameObjectsWithTag("egg");
                if (!isSnake_seekNestWithEgg)
                {
                    Debug.Log("snake seek Nest With Egg.");

                    // go to the nest. There can only have one nest in the scene.
  
                    ran = Random.Range(0, eggs.Length - 1);

                    _egg = eggs[ran];

                    seekLocation(_snake, eggs[ran].transform.position /*, "snake_move" */); // ani name

                    isSnake_seekNestWithEgg = true;
                }
                if (isSnake_seekNestWithEgg)
                {
                ran = Random.Range(0, eggs.Length - 1);
                }
                

                print("snake: egg's amount: " + ran);

                Vector2 v2_egg;
                Vector2 v2_snake;
                v2_snake = _snake.GetComponent<objV2Pos>().thisV2;
                v2_egg = eggs[ran].GetComponent<objV2Pos>().thisV2;
                print("egg v2: " + v2_egg + " , v2 snake: " + v2_snake);
                //Debug.Log("going to nest: " + nests[ran].name);
           

                if (v2_snake == v2_egg)//ibisA reach the nest
                {
                    // Debug.Log("reach to a nest.");

                    hasCheckDes = false;
                    ThisTask.Succeed();
                }
            

        }

        [Task]
        void snake_eatEgg() // if ibis is here, ibis leave by a grid 
        {
           // play the ani
          //  _snake.GetComponent<Animator>().Play();

            Destroy(_egg);

            Debug.Log("snake eat one egg.");

            //after playing this ani
            ThisTask.Succeed();
        }

        [Task]
        void snake_SeekLeave()
        {
            //find the boundry grid


            GameObject[] lands;
            lands = GameObject.FindGameObjectsWithTag("land");

            GameObject des_land;
            des_land = null;

            List<GameObject> boundryLands;
            boundryLands = new List<GameObject>();

            for (int i = 0; i < lands.Length; i++)
            {
                if (lands[i].GetComponent<genPos>().isBoundry)
                {
                    if (!boundryLands.Contains(lands[i]))
                    { boundryLands.Add(lands[i]); }
                }
            }

            int ran;
            ran = Random.Range(0, boundryLands.Count - 1);

            _disappearLand = boundryLands[ran];

             print("des_land: " + _disappearLand.name);
            ThisTask.Succeed();

        }

        [Task]
        void snake_leave()
        {
            //leave
            seekLocation(_snake, _disappearLand.transform.position /*, "snake_move" */);

            //disappear
            Vector2 v2_land;
            Vector2 v2_snake;
            v2_snake = _snake.GetComponent<objV2Pos>().thisV2;
            v2_land = _disappearLand.GetComponent<genPos>().thisCo;

            //Debug.Log("going to nest: " + nests[ran].name);

            if (v2_snake == v2_land)//ibisA reach the nest
            {
                // Debug.Log("reach to a nest.");

                //play snake disappear ani


                //after play this ani
                hasCheckDes = false;
                Destroy(_snake);
                ThisTask.Succeed();
            }
        }

        [Task]
        void checkNoEgret() //没鹭就成功
        {
           
            /*            int am_egret;
                        am_egret = 0;*/
            _egrets.Clear();

            foreach (Transform child in _ObjOnLand.transform)
            {
                if (child.gameObject.name == "egret")
                {
                   // am_egret = am_egret + 1;
                    if (!_egrets.Contains(child.gameObject))
                    { //_egret = child.gameObject;
                        _egrets.Add(child.gameObject);
                        print("egret +1");
                    }
                }
            }
         //   if (am_egret > 0)
                if(_egrets.Count>0)
            {
                print("check has egret");
                ThisTask.Succeed();
            }
            else
            {
                print("check no egret");
                ThisTask.Fail(); }
        }

        [Task]
        void egret_seekWander() //任意走一格
        {
            v2_dess.Clear();

            for (int i =0; i<_egrets.Count; i++)
            {
                Vector2 c_v2;
                c_v2 = NearGrid1(_egrets[i].GetComponent<objV2Pos>().thisV2);
                if (!v2_dess.Contains(c_v2))
                {
                    //// add if not hills
                    Vector2 v2_except;
                    v2_except = new Vector2(999,999);
                        
                    foreach (Transform child in GameObject.Find("Chesses").transform)
                    {
                        if (child.gameObject.tag == "land")
                        {
                            if (child.GetChild(0).gameObject.name == "highHill")
                            {
                                v2_except = child.gameObject.GetComponent<genPos>().thisCo;
                            }
                        }
                    }
                    ////
                    ///
                    if (c_v2 != v2_except)
                    {
                        v2_dess.Add(c_v2);
                        Debug.Log("egret wander to: " + c_v2);
                    }
                }
            }

            if (v2_dess.Count > 0)
            { ThisTask.Succeed(); }

        }

        [Task]
        void egret_AILerp_Close()   // for a bug
        {
            foreach (GameObject egret in _egrets)
            {egret.GetComponent<Pathfinding.AILerp>().enabled = false;
            }
            ThisTask.Succeed();
        }

        [Task]
        void egret_AILerp_Open()    // for a bug
        {
            foreach (GameObject egret in _egrets)
            {egret.GetComponent<Pathfinding.AILerp>().enabled = true;
            }
            ThisTask.Succeed();
        }

        [Task]
        void egret_wander()
        {
            List<Vector3> des_v3s;
            des_v3s = new List<Vector3>();
            for(int i =0; i < _egrets.Count; i++)// pls use for loop
            {
                _egrets[i].GetComponent<SnapToNode>().enabled = false;
                _egrets[i].GetComponent<CapsuleCollider>().enabled = true;

                //_egrets[i].GetComponent<Pathfinding.AILerp>().enabled = false; // debug
                //_egrets[i].GetComponent<Pathfinding.AILerp>().enabled = true; // debug

                int index_v2;
                index_v2 = _LandGenerator.GetComponent<LandGen2>().LandCos.IndexOf(v2_dess[i]);
                Vector3 v3;
                v3 = _LandGenerator.GetComponent<LandGen2>().LandV3s[index_v2];

                if (!des_v3s.Contains(v3))
                {
                    des_v3s.Add(v3);
                }


                print("egret: " + _egrets[i].name + " , v2: " + v2_dess[i]);

                // seekLocation(_egrets[i], v3); // old method

            }
            seekMultiLocations(_egrets, des_v3s);

            int amount_hasMoved;
            amount_hasMoved = 0;
            for (int i = 0; i < _egrets.Count; i++)
            {
                Vector2 v2_egret;
                v2_egret = _egrets[i].GetComponent<objV2Pos>().thisV2;

                print("v2_egret : " + v2_egret + " , v2_des: " + v2_dess[i]);

                bool hasAdd;
                hasAdd = false;
                if (v2_egret == v2_dess[i] &&!hasAdd)
                {
                    hasCheckDes = false;

                   // _egrets[i].GetComponent<SnapToNode>().enabled = true;
                    amount_hasMoved = amount_hasMoved + 1;
                    hasAdd = true;
                    // ThisTask.Succeed();
                }
            }

            if (amount_hasMoved == _egrets.Count)
            {
                ThisTask.Succeed();
            }
        }


        [Task]
        void checkTrapMan_appear(int max, int baseLine)
        {
            int ran;
            ran = Random.Range(0, max);

            if (ran > baseLine)
            {
                //
                // //build empty list of grids

                int index_ibisA = aboutGirdIndex.getGirdIndex(GameObject.Find("ibisA_ray"));

                List<bool> index_emptyLands;  // is this land empty
                index_emptyLands = new List<bool>();
                for (int i = 0; i < 19; i++)
                { index_emptyLands.Add(true); }

                for (int i = 0; i < Map.instance.allItemList.Count; i++)
                {
                    if (Map.instance.allItemList[i].Has
                          && i == index_ibisA
                          && Map.instance.girds[i].state == GirdState.Wall)
                    {
                        index_emptyLands[i] = false;
                    }
                }

                ////get the random v3
                List<int> canAppear;
                canAppear = new List<int>();
                for (int i = 0; i < index_emptyLands.Count; i++)
                {
                    if (index_emptyLands[i] && !canAppear.Contains(i))
                    {
                        canAppear.Add(i);
                    }
                }

                int ran_index = Random.Range(0, canAppear.Count-1);

                //int ran_index = index_emptyLands[ran2];
                trapMan_empty_index = ran_index;
                //v2_des = index_emptyLands[ran2];
                print("ran_index: " + ran_index);
            
/*                int index_Land;
                index_Land = _LandGenerator.GetComponent<LandGen2>().LandCos.IndexOf(v2_emptyLands[ran2]);

                Vector3 v3_des;
                v3_des = _LandGenerator.GetComponent<LandGen2>().LandCos_GO[index_Land].transform.position;*/

                //gen
                GameObject trapMan = Instantiate(Resources.Load("obj/obj")) as GameObject;
                trapMan.name = "trapMan";
                trapMan.GetComponent<objNPC>().whichNPC = "trapMan";
                trapMan.GetComponent<whichObj>().which = 2;
                // trapMan.transform.position = v3_des;
                trapMan.transform.position = Map.instance.girds[trapMan_empty_index].transform.position;
                 trapMan.transform.SetParent(GameObject.Find("ObjOnLand").transform);

                trapMan.GetComponent<SnapToNode>().enabled = false;

                  _trapMan = trapMan;

                // _trapMan = GameObject.Find("trapMan");

                Debug.Log("gen a trap man");

                ThisTask.Succeed();
            }
            else { ThisTask.Fail(); }
        }

        [Task]
        void trapMan_goToRandomGrid_newPathFinding()
        {
            Debug.Log("trap man goes to a random grid - new path finding");
            //remove all lands has obj,highhill, ibisA and trapMan on
            // actuall only need highHill and ibisA

            int index_ibisA = aboutGirdIndex.getGirdIndex(GameObject.Find("ibisA_ray"));

            List<bool> index_emptyLands;  // is this land empty
            index_emptyLands = new List<bool>();
            for(int i =0; i< 19; i++)
            { index_emptyLands.Add(true); }

            for (int i = 0; i < Map.instance.allItemList.Count; i++)
            {
                if (Map.instance.allItemList[i].Has 
                      && i == index_ibisA
                      && Map.instance.girds[i].state == GirdState.Wall )
                {
                    index_emptyLands[i] = false;
                }
            }

            int ran = -1;
            if (!hasCheckMovingGoalIndex)
            {
                ran = Random.Range(0, index_emptyLands.Count - 1);
                print("ran: " + ran);

                GameManager.istance.setSelectNav(_trapMan.GetComponent<Nav>());
                hasCheckMovingGoalIndex = true;
            }

            foreach (bool index in index_emptyLands)
            { print("trapMan can go to: " + index); }

            //move
            seekLocation2(ran);
              


            /*            // check if reaching
                        Vector2 v2_land;
                        Vector2 v2_trapMan;
                        v2_trapMan = _trapMan.GetComponent<objV2Pos>().thisV2;
                        v2_land = v2_des;

                        //Debug.Log("going to nest: " + nests[ran].name);

                        if (v2_trapMan == v2_land)//ibisA reach the nest
                        {
                            hasCheckDes = false;

                            Debug.Log("reach to a ran grid.");

                            // Destroy(_trapMan);
                            ThisTask.Succeed();
                        }*/

            int index_trapManFinal = aboutGirdIndex.getGirdIndex(_trapMan);
            if (ran == index_trapManFinal)
            {
                hasCheckDes = false;

                Debug.Log("reach to a ran grid.");

                // Destroy(_trapMan);
                ThisTask.Succeed();
            }
        }

        [Task]
        void trapMan_goToRandomGrid()
        {
            Debug.Log("trap man goes to a random grid");

            //Vector2 v2_des;
            v2_des = new Vector2();

            //build empty list of grids
            List<Vector2> v2_emptyLands;
            v2_emptyLands = new List<Vector2>();
            /*            for (int i = 0; i < _LandGenerator.GetComponent<LandGen2>().LandCos.Count; i++)
                        {
                            if (!_listObjOnLand.isObjOnLand[i])
                            {
                                if (!v2_emptyLands.Contains(_LandGenerator.GetComponent<LandGen2>().LandCos[i]))
                                {
                                    v2_emptyLands.Add(_LandGenerator.GetComponent<LandGen2>().LandCos[i]);
                                }
                            }
                        }*/
            for(int i =0; i< _listObjOnLand.isObjOnLand.Count; i++)
            {
                int index_empty;
                index_empty = -1;
                if (!_listObjOnLand.isObjOnLand[i])
                {
                    index_empty = i;
                   //print("empty lands : " + index_empty);
                    if (!v2_emptyLands.Contains(_LandGen2.LandCos[index_empty]))
                    {
                        v2_emptyLands.Add(_LandGen2.LandCos[index_empty]);
                       // print("empty land: " + _LandGen2.LandCos[index_empty]);
                    }
                }
            }

            GameObject[] lands;
            lands = GameObject.FindGameObjectsWithTag("land");
            foreach (GameObject land in lands)
            {
                if (land.transform.GetChild(0).transform.gameObject.name == "highHill")
                {
                    Vector2 v2_hillLand;
                    v2_hillLand = land.GetComponent<genPos>().thisCo;
                    if (v2_emptyLands.Contains(v2_hillLand))
                    {
                        v2_emptyLands.Remove(v2_hillLand);
                    }
                }
            }
            Vector2 v2_ibisA;
            v2_ibisA = GameObject.Find("ibisA").GetComponent<objV2Pos>().thisV2;
            if (v2_emptyLands.Contains(v2_ibisA))
            {
                v2_emptyLands.Remove(v2_ibisA); 
            }

            print("empty land's count: " + v2_emptyLands.Count);

            foreach (Vector2 v2 in v2_emptyLands)
            {
                print("empty grid : " + v2);
            }

            //get the random v3
            int ran;
            ran = Random.Range(0, v2_emptyLands.Count-1);
            v2_des = v2_emptyLands[ran];
            print("v2_des: " + v2_des);

            int index_Land;
            index_Land = _LandGenerator.GetComponent<LandGen2>().LandCos.IndexOf(v2_des);

            Vector3 v3_des;
            v3_des = _LandGenerator.GetComponent<LandGen2>().LandV3s[index_Land];
            print("v3_des: " + v3_des);

            //move
            seekLocation(_trapMan, v3_des);
            //v3_trapMan = v3_des;

            // check if reaching
            Vector2 v2_land;
            Vector2 v2_trapMan;
            v2_trapMan = _trapMan.GetComponent<objV2Pos>().thisV2;
            v2_land = v2_des;

            //Debug.Log("going to nest: " + nests[ran].name);

            if (v2_trapMan == v2_land)//ibisA reach the nest
            {
                hasCheckDes = false;

                Debug.Log("reach to a ran grid.");

               // Destroy(_trapMan);
                ThisTask.Succeed();
            }
            
        }

        [Task]
        void trapMan_setTrap()
        {
            GameObject trap = Instantiate(Resources.Load("goj/trap")) as GameObject;

            trap.GetComponent<CapsuleCollider>().enabled = true;

            trap.transform.position = _trapMan.transform.position;
            trap.transform.SetParent(GameObject.Find("ObjOnLand").transform);
            trap.name = "trap";

            trap.transform.localScale = new Vector3(0.5f, 0.5f,1f);
            
           // Destroy(trap.GetComponent<Rigidbody>());
/*            bool hasSet;
            hasSet = false;
            // mark on isObjOnLand list
            if (!hasSet)
            {
                int index_Land;
                index_Land = _LandGenerator.GetComponent<LandGen2>().LandCos.IndexOf(v2_des);
                _listObjOnLand.isObjOnLand[index_Land] = true;
                hasSet = true;

                Debug.Log("trap man sets a trap: " + v2_des);
            }
*/
            

            ThisTask.Succeed();
        }

        [Task]
        void trapMan_leave()
        {
            Debug.Log("trap man leaves");

            // play effect or ani
            Destroy(_trapMan);

            ThisTask.Succeed();
        }



        [Task]
        void endAllNPC()
        {
            end = true;
            ThisTask.Succeed();
        }


        [Task]
        void Next()
        {
            print("next: " + gameObject.name);

            GameObject nextChild;
            nextChild = null;

            for (int i = 0; i < transform.parent.childCount; i++)
            {
                if (transform.parent.GetChild(i).gameObject == gameObject)
                {
                    nextChild = transform.parent.GetChild(i + 1).gameObject;
                    print("next child: " + nextChild.name);
                }
            }

            //gameObject.GetComponent<PandaBehaviour>().enabled = false;
            nextChild.GetComponent<PandaBehaviour>().enabled = true;
            nextChild.GetComponent<PandaBehaviour>().Reset();
            nextChild.GetComponent<Panda.Ibis.MyNPC>().enabled = true;

            gameObject.GetComponent<Panda.Ibis.MyNPC>().enabled = false;

            ThisTask.Succeed();
        }


        public void NextIfEgretDie()
        {
            print("next: " + gameObject.name);

            GameObject nextChild;
            nextChild = null;

            for (int i = 0; i < transform.parent.childCount; i++)
            {
                if (transform.parent.GetChild(i).gameObject == gameObject)
                {
                    nextChild = transform.parent.GetChild(i + 1).gameObject;
                    print("next child: " + nextChild.name);
                }
            }

            //gameObject.GetComponent<PandaBehaviour>().enabled = false;
            nextChild.GetComponent<PandaBehaviour>().enabled = true;
            nextChild.GetComponent<PandaBehaviour>().Reset();
            nextChild.GetComponent<Panda.Ibis.MyNPC>().enabled = true;

           // gameObject.GetComponent<Panda.Ibis.MyNPC>().enabled = false; // debug

            
        }

        /////////////////////////Functions//////////////////
        ///
        void seekLocation(GameObject goj, Vector3 destination /*, string ani_name */)
        {
            if (!hasCheckDes)
            {
                _targetPos.transform.DOMove(destination, 0.000001f, false);
                hasCheckDes = true;
            }
            // go 
            // transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play(ani_name);
           //goj.GetComponent<Animator>().Play(ani_name);

            goj.GetComponent<MoveNPC>().Move1();

            //  Debug.Log("move to destination: " + destination);

        }

        void seekLocation2(int _index) // might need a string to play action 
        {
            if (!hasCheckDes)
            {

                hasCheckDes = true;

                // go 
                // transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_walk");

                _Gamemanager.setMovingGoal(_index);

            }
        }

        void seekMultiLocations(List<GameObject> gojs, List<Vector3> destination)
        {
            for (int i = 0; i < gojs.Count; i++)
            {
                gojs[i].GetComponent<MoveNPC>().Move2(destination[i]);
            }

        }

        Vector2 NearGrid1(Vector2 this_v2)
        {
            Vector2 des_v2;
            des_v2 = new Vector2();

            bool hasPass;
            hasPass = false;

            while (!hasPass)
            {
                int ran;
                ran = Random.Range(1, 6);
                if (ran == 1)
                { des_v2 = new Vector2(this_v2.x, this_v2.y + 1); }
                if (ran == 2)
                { des_v2 = new Vector2(this_v2.x - 1, this_v2.y + 1); }
                if (ran == 3)
                { des_v2 = new Vector2(this_v2.x - 1, this_v2.y); }
                if (ran == 4)
                { des_v2 = new Vector2(this_v2.x, this_v2.y - 1); }
                if (ran == 5)
                { des_v2 = new Vector2(this_v2.x + 1, this_v2.y - 1); }
                if (ran == 6)
                { des_v2 = new Vector2(this_v2.x + 1, this_v2.y ); }

                for (int i = 0; i < _LandGenerator.GetComponent<LandGen2>().LandCos.Count; i++)
                {
                    if (des_v2 == _LandGenerator.GetComponent<LandGen2>().LandCos[i])
                    {
                        hasPass = true;
                    }
                }
            }

            return des_v2;
        }



    }
}



