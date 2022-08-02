using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objFood : MonoBehaviour
{
    public int rich;
    public List<int> land; // suitable land

    public bool isToxic;

    Obj_icons _Obj_icons;

    void Start()
    {
        isToxic = false;

        _Obj_icons = GameObject.Find("Lists").GetComponent<Obj_icons>();


        for (int i = 0; i < rich ; i++)
        {
            GameObject foodEnergy = Instantiate(Resources.Load("goj/foodEnergy")) as GameObject;
            foodEnergy.transform.position = transform.position;
            foodEnergy.transform.localScale = new Vector3(1f, 1f, 2f);
            foodEnergy.transform.SetParent(transform);
            foodEnergy.GetComponent<SpriteRenderer>().sprite = _Obj_icons.foodEnergy[i];
            foodEnergy.name = "foodEnergy" + i.ToString();

          //  faceToCamera sc = foodEnergy.AddComponent<faceToCamera>() as faceToCamera;


        }

    }

    public void getPolluted()
    {
        isToxic = true;

        rich = rich - 1;
        if (rich < 0)
        { rich = 0; }
    }
}
