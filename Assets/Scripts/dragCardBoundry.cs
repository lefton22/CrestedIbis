using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragCardBoundry : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseUp() // 鼠标起来的时候
    {
        // delete the card object
        // set the env object on the grid 

        Debug.Log("Boundry: OnMouseUp");



        Destroy(gameObject);
    }
}
