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
       
        void Start()
        {
            end = false;

            _ObjOnLand = GameObject.Find("ObjOnLand");

            _targetPos = GameObject.Find("Target2");
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
                }
            }
            if (am_egret > 0)
            {
                ThisTask.Succeed();
            }
            else { ThisTask.Fail(); }
        }

        [Task]
        void egret_wander() //任意走一格
        {
            Debug.Log("ibis wander.");

            ThisTask.Succeed();
        }


        [Task]
        void checkTrapMan_appear(int max, int baseLine)
        {
            int ran;
            ran = Random.Range(0, max);

            if (ran > baseLine)
            {
                //
                Debug.Log("gen a trap man");
            }
        }

        [Task]
        void trapMan_goToRandomGrid()
        {
            Debug.Log("trap man goes to a random frid");
        }

        [Task]
        void trapMan_setTrap()
        {
            Debug.Log("trap man sets a trap");
        }

        [Task]
        void trapMan_leave()
        {
            Debug.Log("trap man leaves");
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



    }
}



