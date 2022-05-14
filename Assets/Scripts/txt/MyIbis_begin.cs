using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Panda;

using DG.Tweening;


namespace Panda.Ibis {


    public class MyIbis_begin : MonoBehaviour
    {
        int aa;
        void Start()
        {
            aa = 0;

            transform.DOScaleX(-0.75f, 0.001f);
            transform.DOScaleY(0.75f, 0.001f);
        }

        
        void Update()
        {

        }


        [Task]
        void enableAILerp()
        {
            gameObject.transform.parent.gameObject.GetComponent<Pathfinding.AILerp>().enabled = true;

            print("enableAILerp()");
            ThisTask.Succeed();
        }




        //////TEST/////////////////////////
        [Task]
        void EnableAILerp()
        {
            //gameObject.GetComponent<Pathfinding.AILerp>().enabled = true;
            print("ibis begin 1");

            ThisTask.Succeed();
        }

        [Task]

        void EndTask()
        {
            print("ibis begin 2");
           // GetComponent<PandaBehaviour>().Reset();
            ThisTask.Succeed();
        }

        [Task]
        void ifA()
        {
            print("ifA");
            if (aa == 0) { ThisTask.Succeed(); }
        }

        [Task]
        void ifB()
        {
            print("ifB");
            GetComponent<PandaBehaviour>().Reset();

            ThisTask.Succeed(); 
        }

        [Task]
        void ifC()
        {
            print("C");
            ThisTask.Succeed();
        }

        [Task]
        void Next()
        {

            gameObject.transform.parent.gameObject.GetComponent<Pathfinding.AILerp>().enabled = true;

            GameObject nextChild;
            nextChild = null;

            for (int i = 0; i < transform.parent.childCount; i++)
            {
                if (transform.parent.GetChild(i).gameObject == gameObject)
                {
                    nextChild = transform.parent.GetChild(i + 1).gameObject;
                  //  print("next child: " + nextChild);
                }
            }


            nextChild.GetComponent<PandaBehaviour>().enabled = true;
            nextChild.GetComponent<PandaBehaviour>().Reset();

            gameObject.GetComponent<PandaBehaviour>().enabled = false;

            gameObject.GetComponent<MyIbis_begin>().enabled = false;

            print("next");

            ThisTask.Succeed();
        }


/*        [Task]
        void Previous()
        {
           // GameObject.Find("ibis_begin").SetActive(true);
           GameObject.Find("ibis_begin") .GetComponent<PandaBehaviour>().Reset();

            //gameObject.SetActive(false);
            GameObject.Find("ibis_begin").GetComponent<PandaBehaviour>().enabled = true;
            GameObject.Find("ibis_begin").GetComponent<PandaBehaviour>().Reset();

            gameObject.GetComponent<PandaBehaviour>().enabled = false;

            ThisTask.Succeed();
        }*/
    }
}

