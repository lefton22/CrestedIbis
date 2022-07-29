using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Pathfinding;

public class MoveNPC : MonoBehaviour
{
    Transform targetPos;
    Seeker seeker;
    void Start()
    {
/*        seeker = GetComponent<Seeker>();
        targetPos = GameObject.Find("Target2").transform;*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Move1()
    {
        seeker.StartPath(transform.position, targetPos.position);
        // Debug.Log("ibis move.");
    }

    public void Move2(Vector3 des_v3) // when there are multiple moves at the same time
    {

            seeker.StartPath(transform.position, des_v3);

    }
}
