using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class square : MonoBehaviour
{
    float _y;
    Vector3 v3;
   GFRectGrid _grid;

    public Vector3 v3_grid;
    void Start()
    {
        _y = transform.position.y + 100f;
        transform.DOLookAt(new Vector3(transform.position.x, _y, transform.position.z), 0.1f);

        _grid = GameObject.Find("Rectangular Grid").GetComponent<GFRectGrid>();

        transform.position = _grid.GridToWorld(v3_grid);
      //  transform.DOMoveY(0.001f, 1f);
        transform.DOLocalRotate(new Vector3(-88.73f,15.598f,-16.674f),0.1f);
    }

   
    void Update()
    {
        
       
    }
}
