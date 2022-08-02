using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//use Setactive

public class ibisA_2D_Fx : MonoBehaviour
{
    public GameObject follow_;

    public List<GameObject> ibisA_FXs;

    void Start()
    {
        foreach (Transform child in gameObject.transform)
        {
            ibisA_FXs.Add(child.gameObject);
        }
    }

    void Update()
    {
        transform.position = follow_.transform.position;
    }

    public void awakeASF(string fxName, bool isAllClose)
    {
        if (isAllClose)
        {
            foreach (GameObject fx in ibisA_FXs)
            {
                fx.SetActive(false);
            }
        }

        if (!isAllClose)
        {
            foreach (GameObject fx in ibisA_FXs)
            {
                if (fx.name == fxName)
                {
                    fx.SetActive(true);

                  //  print("FX:"+ fx.name);
                }
                else { fx.SetActive(false); }
            }


                //for (int i = 0; i < ibisA_FXs.Count; i++)
                //{
                //if (ibisA_FXs[i].name == "brambles")
                //{
                //    ibisA_FXs[i].SetActive(false);

                //       ibisA_FXs[i].SetActive(true);
                //    }
                //}

        }
    }
}
