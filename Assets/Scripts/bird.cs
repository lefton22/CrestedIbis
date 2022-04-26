using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class bird : MonoBehaviour
{
    GFRectGrid _grid;
    public Vector3 v3_grid;

    Vector3 current_grid_v3;
    void Start()
    {
        _grid = GameObject.Find("Rectangular Grid").GetComponent<GFRectGrid>();

        transform.position = _grid.GridToWorld(v3_grid);
        transform.DOMoveY(-1.87f, 1f);

       // Debug.Log();
        
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.W)) // x+1
        {
            current_grid_v3.x = current_grid_v3.x +1;
           transform.DOMoveX(_grid.WorldToGrid(current_grid_v3).x, 1f);
        }
    }
}
