using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCIbis : MonoBehaviour
{
//properties of the bird
   public  int gender;//1Ϊ�ƣ�2Ϊ��
   public  int full;// 0��,1��
    public int sprite;//0 need to rest, 1 no need 
    public bool isSingle;
    public bool isMate;
    public GameObject mate;


    void Start()
    {
        // transform.localScale = new Vector3(0.9f, 0.9f, 1f);

    }

   void Update()
    {
        transform.localScale = new Vector3(0.9f, 0.9f, 1f);
    }
}
