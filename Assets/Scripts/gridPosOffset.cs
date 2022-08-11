using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class gridPosOffset : MonoBehaviour
{
    public bool isIbisA;
    float ibisA_y;

    public bool ibisACanOffset;
    void Start()
    {
        ibisACanOffset = false;

        if (isIbisA)
        {
            ibisA_y = transform.position.y-0.15f;
        }
    }
    
    void Update()
    {
        if (isIbisA && ibisACanOffset)
        {
            transform.DOLocalMoveY(ibisA_y, 0.0001f);
        }



    }

    public void AdjustOnGrid(Vector3 ori_v3, Vector3 add_v3)
    {
        if (ori_v3 != new Vector3(999f, 999f, 0))
        {
            transform.DOLocalMoveX(ori_v3.x + add_v3.x, 0.5f);
            transform.DOLocalMoveY(ori_v3.y + add_v3.y, 0.5f);
            transform.DOLocalMoveZ(ori_v3.z + add_v3.z, 0.5f);
        }

        /*        transform.position = new Vector3(ori_v3.x + add_v3.x,
                                                    ori_v3.y + add_v3.y,
                                                    ori_v3.z + add_v3.z);*/
    }
}
