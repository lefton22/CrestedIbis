using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aboutGirdIndex : MonoBehaviour
{
    Map _Map;


    void Start()
    {
        _Map = GameObject.Find("Map").GetComponent<Map>();
    }

    
    void Update()
    {
        Debug.DrawRay(GameObject.Find("A").transform.position, Camera.main.transform.position);
    }

    static public int getGirdIndex(GameObject thisObj)
    {

       // int _getGirdIndex =-1;

        int indexGirds = -1;

        Vector3 objPos = thisObj.transform.position;
        RaycastHit hit;
        //Ray ray = Camera.main.ScreenPointToRay(objPos);
        var ray = new Ray(thisObj.transform.position, Camera.main.transform.position);

        if (Physics.Raycast(ray, out hit))
        {
            print("1 ray");
            // A.transform.position = Map.instance.girds[Apos].transform.position; 
            if (hit.collider.gameObject.tag =="Respawn")
            {
                indexGirds = Map.instance.girds.IndexOf(hit.collider.gameObject.GetComponent<Gird>());

                print("2 get index.");
            }
        }

        return indexGirds;
    }
}
