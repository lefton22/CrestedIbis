using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objNest : MonoBehaviour
{


    public int build_finished; //(需要几个回合才能筑完)
    public int build_current;//目前建了几个回合

    public List<string> materials;

    public int _rateProduce;


    void Start()
    {
        materials = new List<string>();

        build_finished = 2;
        build_current = 0;
        //checkRateProduce();
        _rateProduce= rateProduce();
    }

    void Update()
    {
        //show UI
    }

    public void addOneBuildPoint()
    {
        build_current = build_current + 1;
    }
    public bool isFinished()
    {
        bool _isFin;
        _isFin = false;

        if (build_finished <= build_current)
        { _isFin = true; }

        return _isFin;
    }
    
    public int rateProduce() //在觅食地附近，位置对繁殖率有直接关系 ,？ 等同于巢的质量？
    {
        int _rateProduce;
        _rateProduce = 0;

        Vector2  this_v2= new Vector2();

        listObjOnLand _listObjOnLand;
        _listObjOnLand = GameObject.Find("Lists").GetComponent<listObjOnLand>();
        for (int i = 0; i < _listObjOnLand.foodOnLand.Count; i++)
        {
            //(x,y+1)
            //(x-1,y+1)
            //(x-1,y)
            //(x, y-1)
            //(x+1, y-1)
            //(x+1,y)
            List<Vector2> arounds;
            arounds = new List<Vector2>();
            arounds.InsertRange(arounds.Count,
                new Vector2[] {new Vector2(this_v2.x,  this_v2.y +1f),
                                       new Vector2(this_v2.x-1, this_v2.y +1f) ,
                                       new Vector2(this_v2.x -1, this_v2.y),
                                       new Vector2(this_v2.x, this_v2.y-1f),
                                       new Vector2(this_v2.x+1f, this_v2.y -1f),
                                       new Vector2(this_v2.x+1f, this_v2.y)});
            for (int k = 0; k < arounds.Count; k++)
            {
                if (_listObjOnLand.foodOnLand[i] == arounds[k])
                {
                    _rateProduce = _rateProduce + 1;
                }
            }

        }

        return _rateProduce;
    }

}
