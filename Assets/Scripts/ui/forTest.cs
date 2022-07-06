using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forTest : MonoBehaviour
{
    //Test: eggs position
    bool isSpawn;
    List<GameObject> eggs;

    //

    void Start()
    {
        eggs = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        { spawn(); }

    }



    void spawn()
    {
        int ran_amounts_egg;
        ran_amounts_egg = -1;

        List<int> ran;
        ran = new List<int>();
        ran.Add(1); ran.Add(2); ran.Add(3); ran.Add(4);
        //ran_amounts_egg = ran[Random.Range(0, ran.Count)];
        ran_amounts_egg = 4;
        if (!isSpawn)
        {
            for (int k = 0; k < ran_amounts_egg; k++)
            {
                // play produce ani * ran_amounts_egg
               // transform.parent.gameObject.GetComponent<Panda.Ibis.MyIbis>().ani.Play("ibis_produceEggs");

                // eggs + new eggs(List)
                GameObject egg = Instantiate(Resources.Load("egg")) as GameObject;
                egg.name = "egg" + k.ToString();

//                egg.transform.position = transform.parent.gameObject.transform.position;
                //egg.transform.SetParent(null);

                egg.GetComponent<Rigidbody>().isKinematic = true;
                egg.GetComponent<SnapToNode>().enabled = false;

                if (!eggs.Contains(egg))
                {
                    eggs.Add(egg);
                }

                //set egg's position 
                //foreach (Transform child in GameObject.Find("ObjOnLand").transform)
                //{
                //    if (child.gameObject.name == "nest"
                //        && child.gameObject.GetComponent<objV2Pos>().thisV2 == GameObject.Find("ibisA").GetComponent<objV2Pos>().thisV2)
                //    {
                //        egg.transform.position = child.gameObject.transform.position;
                //    }
                //}

                for (int i = 0; i < eggs.Count; i++)
                {
                    float egg_x = eggs[i].transform.position.x;
                    float egg_y = eggs[i].transform.position.y;
                    float egg_z = eggs[i].transform.position.z;

                    //if (i == 0)
                    //{ eggs[0].transform.position = new Vector3(egg_x + 0.45f, egg_y + 0.633f, egg_z); }
                    //if (i == 1)
                    //{ eggs[1].transform.position = new Vector3(egg_x + 0.646f, egg_y + 0.552f, egg_z); }
                    //if (i == 2)
                    //{ eggs[2].transform.position = new Vector3(egg_x + 0.138f, egg_y + 0.639f, egg_z); }
                    //if (i == 3)
                    //{ eggs[3].transform.position = new Vector3(egg_x + 0.355f, egg_y + 0.42f, egg_z); }


                }

                //egg.transform.SetParent(GameObject.Find("ObjOnLand").transform);

                //if (k == ran_amounts_egg - 1)
                //{
                //    isSpawn = true;

                //    lightSpawn(ran_amounts_egg);
                //    print("spawn ");
                //    // monthSpawn = _outAI.month;
                //    ThisTask.Succeed();
                //}
            }

        }
    }
}
