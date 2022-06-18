using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class objNPC : MonoBehaviour
{
    public string whichNPC;

    listObjOnLand _listObjOnLand;
    //objFood _objFood;
    void Start()
    {
        _listObjOnLand = GameObject.Find("Lists").GetComponent<listObjOnLand>();

        //  whichNPC = name;
        checkWhichNPC();


    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void checkWhichNPC()
    {
        if (name == "egret")
        {
            objEgret sc = gameObject.AddComponent<objEgret>() as objEgret;

            Pathfinding.Seeker seeker = gameObject.AddComponent<Pathfinding.Seeker>() as Pathfinding.Seeker;
            Pathfinding.AILerp aiLerp = gameObject.AddComponent<Pathfinding.AILerp>() as Pathfinding.AILerp;
            sc.GetComponent<Pathfinding.AILerp>().autoRepath.mode = Pathfinding.AutoRepathPolicy.Mode.Never;
            faceToCamera _ftc = gameObject.AddComponent<faceToCamera>() as faceToCamera;
           objV2Pos _ovp = gameObject.AddComponent<objV2Pos>() as objV2Pos;
            // Capsule collider & Rigidbody need to be on the obj
            Animator _ani = gameObject.AddComponent<Animator>() as Animator;
            MoveNPC _mn = gameObject.AddComponent<MoveNPC>() as MoveNPC;

            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("obj/egret");

            GetComponent<CapsuleCollider>().enabled = true;

            // transform.localScale = new Vector3(1f, 1f,1f);
            name = "egret";

        }
/*        if (whichNPC == "jackdaw")
        {
            objJackDaw sc = gameObject.AddComponent<objJackDaw>() as objJackDaw;
        }*/
        if (name == "snake")
        {
            objSnake sc = gameObject.AddComponent<objSnake>() as objSnake;

            Pathfinding.Seeker seeker = gameObject.AddComponent<Pathfinding.Seeker>() as Pathfinding.Seeker;
            Pathfinding.AILerp aiLerp = gameObject.AddComponent<Pathfinding.AILerp>() as Pathfinding.AILerp;
            sc.GetComponent<Pathfinding.AILerp>().autoRepath.mode = Pathfinding.AutoRepathPolicy.Mode.Never;
            //  faceToCamera _ftc = gameObject.AddComponent<faceToCamera>() as faceToCamera;
            // objV2Pos _ovp = gameObject.AddComponent<objV2Pos>() as objV2Pos;
            // Capsule collider & Rigidbody need to be on the obj
            Animator _ani = gameObject.AddComponent<Animator>() as Animator;
            MoveNPC _mn = gameObject.AddComponent<MoveNPC>() as MoveNPC;

            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("obj/snake");

            GetComponent<CapsuleCollider>().enabled = true;

            transform.localScale = new Vector3(1f, 1f, 1f);
            name = "snake";
        }
        /*        if (whichNPC == "eagle")
                {
                    objEagle sc = gameObject.AddComponent<objEagle>() as objEagle;
                }*/

        if (name == "trapMan")
        {
            objTrapMan sc = gameObject.AddComponent<objTrapMan>() as objTrapMan;

            Pathfinding.Seeker seeker = gameObject.AddComponent<Pathfinding.Seeker>() as Pathfinding.Seeker;
            Pathfinding.AILerp aiLerp = gameObject.AddComponent<Pathfinding.AILerp>() as Pathfinding.AILerp;
            sc.GetComponent<Pathfinding.AILerp>().autoRepath.mode = Pathfinding.AutoRepathPolicy.Mode.Never;
            //  faceToCamera _ftc = gameObject.AddComponent<faceToCamera>() as faceToCamera;
            // objV2Pos _ovp = gameObject.AddComponent<objV2Pos>() as objV2Pos;
            // Capsule collider & Rigidbody need to be on the obj
            Animator _ani = gameObject.AddComponent<Animator>() as Animator;
            MoveNPC _mn = gameObject.AddComponent<MoveNPC>() as MoveNPC;

            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("obj/trapMan");

            GetComponent<CapsuleCollider>().enabled = true;
            transform.localScale = new Vector3(1f, 1f, 1f);
            name = "trapMan";

        }


        if (name == "ibisAdult")
        {
            objIbisAdult sc = gameObject.AddComponent<objIbisAdult>() as objIbisAdult;

/*            GameObject ibisNPC = Instantiate(Resources.Load("ibisB")) as GameObject;
            ibisNPC.transform.SetParent(gameObject.transform);
            ibisNPC.transform.position = gameObject.transform.position;*/

            Pathfinding.Seeker seeker = gameObject.AddComponent<Pathfinding.Seeker>() as Pathfinding.Seeker;
            Pathfinding.AILerp aiLerp = gameObject.AddComponent<Pathfinding.AILerp>() as Pathfinding.AILerp;
           // faceToCamera _ftc = gameObject.AddComponent<faceToCamera>() as faceToCamera;
          //  objV2Pos _ovp = gameObject.AddComponent<objV2Pos>() as objV2Pos;
            // Capsule collider & Rigidbody need to be on the obj
            Animator _ani = gameObject.AddComponent<Animator>() as Animator;
            MoveNPC _mn = gameObject.AddComponent<MoveNPC>() as MoveNPC;

            GetComponent<CapsuleCollider>().enabled = true;

            GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("obj/ibisB");
            NPCIbis _NPCIbis = gameObject.AddComponent<NPCIbis>() as NPCIbis;
            //ramdomize npc ibis property

            //GetComponent<NPCIbis>().gender = Random.Range(1,2);
            if (chooseGender.cGender == 1) { GetComponent<NPCIbis>().gender = 2; }
            if (chooseGender.cGender == 2) { GetComponent<NPCIbis>().gender = 1; }

            /*            int ranSingle;
                        ranSingle = Random.Range(0,1);
                        if (ranSingle == 0) { GetComponent<NPCIbis>().isSingle = false; }
                        if (ranSingle == 1) { GetComponent<NPCIbis>().isSingle = true; }*/

            GetComponent<NPCIbis>().isMate = false;
            GetComponent<NPCIbis>().mate = null;
            GetComponent<NPCIbis>().isSingle = true;


            //transform.localScale= new Vector3(0.9f, 0.9f,1f);
            transform.DOScale(new Vector3 (0.9f, 0.9f, 0.9f), 0.001f);

            //_listObjOnLand.NPCibisOnLand.Add(gameObject);

            GameObject showInfo = Instantiate(Resources.Load("goj/showInfo")) as GameObject;
            showInfo.transform.SetParent(gameObject.transform);
            showInfo.name = "showInfo";
           
        }
        //  if (whichNPC == "trapMan")
    }
}
