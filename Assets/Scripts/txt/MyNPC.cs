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

        GameObject _ObjOnLand;

        GameObject _targetPos;

        GameObject _snake;

        GameObject _egg;

        GameObject _disappearLand;

        GameObject _egret;

        Vector2 v2_des;

        GameObject _LandGenerator;

        listObjOnLand _listObjOnLand;

        GameObject _trapMan;

        //Vector3 v3_trapMan;
       
        void Start()
        {
            end = false;

            _ObjOnLand = GameObject.Find("ObjOnLand");

            _targetPos = GameObject.Find("Target2");

            _LandGenerator = GameObject.Find("LandGenerator");

            _listObjOnLand = GameObject.Find("Lists").GetComponent<listObjOnLand>();

           // v3_trapMan = new Vector3();

        }


        void Update()
        {

        }


        [Task]
        void checkNoSnake() //没蛇就成功
        {
            print("check no snake");
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
                ThisTask.Succeed();
            }
            else { ThisTask.Fail(); }
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
        void snake_seekNestWithEgg()
        {
            Debug.Log("snake seek Nest With Egg.");

            // go to the nest. There can only have one nest in the scene.
            GameObject[] eggs;
            eggs = GameObject.FindGameObjectsWithTag("egg");

            if (eggs.Length == 0)
            {
                ThisTask.Fail();
            }

            int ran;
            ran = Random.Range(0, eggs.Length - 1);

            _egg = eggs[ran];

            seekLocation(_snake, eggs[ran].transform.position /*, "snake_move" */); // ani name

            Vector2 v2_egg;
            Vector2 v2_snake;
            v2_snake = _snake.GetComponent<objV2Pos>().thisV2;
            v2_egg = eggs[ran].GetComponent<objV2Pos>().thisV2;
            print("egg v2: " + v2_egg+ " , v2 snake: " + v2_snake);
            //Debug.Log("going to nest: " + nests[ran].name);

            if (v2_snake == v2_egg)//ibisA reach the nest
            {
                // Debug.Log("reach to a nest.");

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
                Destroy(_snake);
                ThisTask.Succeed();
            }
        }

        [Task]
        void checkNoEgret() //没蛇就成功
        {
            print("check no egret");
            int am_egret;
            am_egret = 0;
            foreach (Transform child in _ObjOnLand.transform)
            {
                if (child.gameObject.name == "egret")
                {
                    am_egret = am_egret + 1;
                    _egret = child.gameObject;
                }
            }
            if (am_egret > 0)
            {
                ThisTask.Succeed();
            }
            else { ThisTask.Fail(); }
        }

        [Task]
        void egret_seekWander() //任意走一格
        {

            v2_des = NearGrid1(_egret.GetComponent<objV2Pos>().thisV2);
            Debug.Log("ibis wander to: " + v2_des);

            ThisTask.Succeed();

        }

        [Task]
        void egret_wander()
        {
            int index_v2;
            index_v2 = _LandGenerator.GetComponent<LandGen2>().LandCos.IndexOf(v2_des);
            Vector3 v3;
            v3 = _LandGenerator.GetComponent<LandGen2>().LandV3s[index_v2];
            seekLocation(_egret, v3);

            Vector2 v2_egret;
            v2_egret = _egret.GetComponent<objV2Pos>().thisV2;

            print("v2_egret : " + v2_egret +" , v2_des: " + v2_des);

            if (v2_egret == v2_des)
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
                //build empty list of grids
                List<Vector2> v2_emptyLands;
                v2_emptyLands = new List<Vector2>();
                for (int i = 0; i < _LandGenerator.GetComponent<LandGen2>().LandCos.Count; i++)
                {
                    if (!_listObjOnLand.isObjOnLand[i])
                    {
                        if (!v2_emptyLands.Contains(_LandGenerator.GetComponent<LandGen2>().LandCos[i]))
                        {
                            v2_emptyLands.Add(_LandGenerator.GetComponent<LandGen2>().LandCos[i]);
                        }
                    }
                }
                //get the random v3
                int ran2;
                ran2 = Random.Range(0, v2_emptyLands.Count - 1);
                v2_des = v2_emptyLands[ran2];
                print("v2_des: " + v2_des);

                int index_Land;
                index_Land = _LandGenerator.GetComponent<LandGen2>().LandCos.IndexOf(v2_emptyLands[ran2]);

                Vector3 v3_des;
                v3_des = _LandGenerator.GetComponent<LandGen2>().LandCos_GO[index_Land].transform.position;

                //gen
                GameObject trapMan = Instantiate(Resources.Load("obj/obj")) as GameObject;
                trapMan.name = "trapMan";
                trapMan.GetComponent<objNPC>().whichNPC = "trapMan";
                trapMan.GetComponent<whichObj>().which = 2;
                trapMan.transform.position = v3_des;
                trapMan.transform.SetParent(GameObject.Find("ObjOnLand").transform);

                _trapMan = trapMan;

                // _trapMan = GameObject.Find("trapMan");

                Debug.Log("gen a trap man");

                ThisTask.Succeed();
            }
            else { ThisTask.Fail(); }
        }

        [Task]
        void trapMan_goToRandomGrid()
        {
            Debug.Log("trap man goes to a random grid");

            Vector2 v2_des;
            v2_des = new Vector2();

            //build empty list of grids
            List<Vector2> v2_emptyLands;
            v2_emptyLands = new List<Vector2>();
            for (int i = 0; i < _LandGenerator.GetComponent<LandGen2>().LandCos.Count; i++)
            {
                if (!_listObjOnLand.isObjOnLand[i])
                {
                    if (!v2_emptyLands.Contains(_LandGenerator.GetComponent<LandGen2>().LandCos[i]))
                    {
                        v2_emptyLands.Add(_LandGenerator.GetComponent<LandGen2>().LandCos[i]);       
                    }
                }
            }

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
                 Debug.Log("reach to a ran grid.");

               // Destroy(_trapMan);
                ThisTask.Succeed();
            }
            
        }

        [Task]
        void trapMan_setTrap()
        {
            GameObject trap = Instantiate(Resources.Load("goj/trap")) as GameObject;
            trap.transform.position = _trapMan.transform.position;
            trap.transform.SetParent(GameObject.Find("ObjOnLand").transform);

            Debug.Log("trap man sets a trap");

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
            print("next");

            GameObject nextChild;
            nextChild = null;

            for (int i = 0; i < transform.parent.childCount; i++)
            {
                if (transform.parent.GetChild(i).gameObject == gameObject)
                {
                    nextChild = transform.parent.GetChild(i + 1).gameObject;
                }
            }

            gameObject.GetComponent<PandaBehaviour>().enabled = false;
            nextChild.GetComponent<PandaBehaviour>().enabled = true;
            nextChild.GetComponent<PandaBehaviour>().Reset();
            nextChild.GetComponent<Panda.Ibis.MyNPC>().enabled = true;

            gameObject.GetComponent<Panda.Ibis.MyNPC>().enabled = false;

            ThisTask.Succeed();
        }

        /////////////////////////Functions//////////////////
        ///
        void seekLocation(GameObject goj, Vector3 destination /*, string ani_name */)
        {
            _targetPos.transform.DOMove(destination, 0.000001f, false);
            // go 
            // transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play(ani_name);
           //goj.GetComponent<Animator>().Play(ani_name);

            goj.GetComponent<MoveNPC>().Move1();

            //  Debug.Log("move to destination: " + destination);


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



