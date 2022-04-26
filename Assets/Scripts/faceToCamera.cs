using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class faceToCamera : MonoBehaviour
{
    public GameObject camera2;
    
    
    void Start()
    {
        camera2 = GameObject.Find("Camera1");
        transform.DOLookAt(camera2.transform.position, 0.001f);

        //  transform.DOLocalRotate(new Vector3(0,-45f,0),0.1f);
        // transform.DOLocalRotate(camera1.transform.position, 0.1f);
    }



    /*        void OnCollisionEnter(Collision collision)
            {
    *//*            if (collision.gameObject.tag == "land")
                {*//*

                    Debug.Log("ibis arrive land: " + collision.gameObject.name);
              //  }
            }*/
    public void faceToCamera2()
    {
        transform.DOLookAt(camera2.transform.position, 0.001f);
    }
}
