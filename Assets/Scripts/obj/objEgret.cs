using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objEgret : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        print("egret has an collision");
        if (collision.gameObject.name == "trap")
        {
            print(collision.gameObject.name);
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
 }
