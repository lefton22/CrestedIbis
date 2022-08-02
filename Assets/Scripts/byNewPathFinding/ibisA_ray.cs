using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ibisA_ray : MonoBehaviour
{
    GameObject _ibisA;
    void Start()
    {
        _ibisA = GameObject.Find("ibisA");
    }

    
    void Update()
    {
        transform.position = new Vector3(_ibisA.transform.position.x,
                                            _ibisA.transform.position.y,
                                            _ibisA.transform.position.z+0.7f);
    }
}
