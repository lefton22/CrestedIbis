using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rayCastBoundry : MonoBehaviour
{
    public GameObject lastHit;
    public float offSetRayY;
    Vector3 v3_offSet;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        v3_offSet = new Vector3(transform.position.x, transform.position.y + offSetRayY, transform.position.z);

        Vector3 toCamera = (GameObject.Find("Camera1").transform.position - transform.position).normalized;

        Debug.DrawLine(v3_offSet, GameObject.Find("Camera1").transform.position);

        var ray = new Ray(v3_offSet, toCamera);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.gameObject.tag == "card")
            {
                lastHit = hit.transform.gameObject;

              //  turnBased.MouseUp_currentLand = null;

                turnBased.MouseOver_currentLand = null;

              //  Debug.Log("touching boundry： " + gameObject.name + " hits " + hit.transform.gameObject);
            }
            else 
            {
                //Debug.Log("touching boundry (no cards)： " + gameObject.name + " hits " + hit.transform.gameObject);
            }
           
        }
    }
}
