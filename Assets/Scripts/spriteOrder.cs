using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// from 3000
// if shows up in the same grid: trap (+90) > obj(+50) > npc (+30) > ibisA (+10) > nest　(+0)

public class spriteOrder : MonoBehaviour
{
    //bool hasAdd;

    void Start()
    {
       // hasAdd = false;
    }

    public void adjustOrder()
    {
        adjustOrder0(2,3000);
        adjustOrder0(1,3200);
        adjustOrder0(0,3300);
        adjustOrder0(-1, 3400);
        adjustOrder0(-2, 3500);

    }

    void adjustOrder0(int y, int layer)
    {
        if (GetComponent<objV2Pos>() && GetComponent<objV2Pos>().thisV2.y == y)
        {
            if (gameObject.name == "ibisA")
                GetComponent<SpriteRenderer>().sortingOrder = layer +10;

            if (gameObject.name == "trap")
                GetComponent<SpriteRenderer>().sortingOrder = layer + 90;

            if (gameObject.tag == "material" || gameObject.tag == "food" /*|| gameObject.tag == "nest" */)
                GetComponent<SpriteRenderer>().sortingOrder = layer + 50;

            if (gameObject.tag == "npc")
                GetComponent<SpriteRenderer>().sortingOrder = layer + 30;

            if (gameObject.tag == "nest")
                GetComponent<SpriteRenderer>().sortingOrder = layer;
        }

        //if (!hasAdd)
        //{
        //    if (gameObject.name == "trap")
        //    { GetComponent<SpriteRenderer>().sortingOrder = GetComponent<SpriteRenderer>().sortingOrder + 90; }

        //    if (gameObject.tag == "material" || gameObject.tag == "food" || gameObject.tag == "nest")
        //    { GetComponent<SpriteRenderer>().sortingOrder = GetComponent<SpriteRenderer>().sortingOrder + 50; }

        //    if (gameObject.tag == "npc")
        //    { GetComponent<SpriteRenderer>().sortingOrder = GetComponent<SpriteRenderer>().sortingOrder + 10; }

        //    hasAdd = true;
        //}
    }

    //public void sameGridAdjustOrder() // call this from the meet methods or place
    //{
        
    //}
}
