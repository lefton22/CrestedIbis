using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objNest : MonoBehaviour
{


    public int turnFinished; //(��Ҫ�����غϲ�������)
    public int currentProgress;//Ŀǰ���˼����غ�
    public List<string> materials;


    void Start()
    {
        materials = new List<string>();

        //checkRateProduce();
    }

   public int rateProduce(Vector2 this_v2) //����ʳ�ظ�����λ�öԷ�ֳ����ֱ�ӹ�ϵ ,�� ��ͬ�ڳ���������
    {
        int _rateProduce;
        _rateProduce = 0;

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
