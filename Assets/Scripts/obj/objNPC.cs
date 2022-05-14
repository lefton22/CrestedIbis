using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objNPC : MonoBehaviour
{
    public string whichNPC;

    //objFood _objFood;
    void Start()
    {
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
            faceToCamera _ftc = gameObject.AddComponent<faceToCamera>() as faceToCamera;
            objV2Pos _ovp = gameObject.AddComponent<objV2Pos>() as objV2Pos;
            // Capsule collider & Rigidbody need to be on the obj
            Animator _ani = gameObject.AddComponent<Animator>() as Animator;
            MoveNPC _mn = gameObject.AddComponent<MoveNPC>() as MoveNPC;

            GetComponent<CapsuleCollider>().enabled = true;
        }
        //  if (whichNPC == "trapMan")
    }
}
