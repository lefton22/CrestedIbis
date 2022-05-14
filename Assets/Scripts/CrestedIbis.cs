using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class CrestedIbis : MonoBehaviour
{
    public Transform targetPos;
    Seeker seeker;
    void Start()
    {
        seeker = GetComponent<Seeker>();

        GetComponent<CapsuleCollider>().enabled = false;

    }
    // Update is called once per frame
    void Update()
    {
        //��Ŀ����ı�������°�һ��Q��Ѱһ��·��������;�ı�·��
        if (Input.GetKeyDown(KeyCode.W))
        { ibisMove1(); }

        if (Input.GetKeyDown(KeyCode.C))
        { targetPos = GameObject.Find("Target2").transform; }

        if (Input.GetKeyDown(KeyCode.Q))// move to target
        {
            seeker.StartPath(transform.position, targetPos.position);
            Debug.Log("move.");
        }
    }

    public void ibisMove1()
    {
        seeker.StartPath(transform.position, targetPos.position);
       // Debug.Log("ibis move 1:" + targetPos.position);
    }

    public void OnPathComplete(Path p)
    {
        Debug.Log("Yay, we got a path back. Did it have an error? " + p.error);
    }

}
