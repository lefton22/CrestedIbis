using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Panda;

namespace Panda.Ibis
{
    public class MyNPC : MonoBehaviour
    {
       static public bool end;

        GameObject _ObjOnLand;
        void Start()
        {
            end = false;

            _ObjOnLand = GameObject.Find("ObjOnLand");
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
                }
            }
            if (am_snake > 0)
            {
                ThisTask.Succeed();
            }
            else { ThisTask.Fail(); }
        }


        [Task]
        void snake_seekNestWithEgg()
        {
            Debug.Log("snake seek Nest With Egg.");

            ThisTask.Succeed();
        }

        [Task]
        void snake_eatEgg()
        {
            Debug.Log("snake eat one egg.");

            ThisTask.Succeed();
        }



        [Task]
        void checkNoEgret() //没蛇就成功
        {
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

    }
}



