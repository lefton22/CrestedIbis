using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class highHill : MonoBehaviour
{
    GameObject _child;
    void Start()
    {
        _child = transform.GetChild(0).gameObject;
        _child.transform.SetParent(transform.parent);
        _child.transform.position = transform.parent.gameObject.transform.position;

    }


}
