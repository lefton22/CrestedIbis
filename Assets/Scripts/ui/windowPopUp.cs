using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class windowPopUp : MonoBehaviour
{

    void Start()
    {
        transform.DOPunchScale(new Vector3(1.01f,1f,1f), 0.5f, 1,0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
