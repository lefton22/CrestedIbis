using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class raycastGrid : MonoBehaviour
{
    public GameObject lastHit;
    public float offSetRayY;
    Vector3 v3_offSet;

    bool isPunch;
    float t;

    bool hasGen;

    List<GameObject> allCans;
    public  GameObject _canRichFood;
    public GameObject _canAveFood;
    public GameObject _canPoorFood;
    public GameObject _canNPC;
    public GameObject _canNest;
    public GameObject _canHumanStuff;
    public GameObject _canBuildingMaterial;

    void Start()
    {
        isPunch = false;
        t =0f;

        hasGen = false;

        allCans = new List<GameObject>();
        allCans.Add(_canRichFood); allCans.Add(_canAveFood); allCans.Add(_canPoorFood); allCans.Add(_canNPC);
        allCans.Add(_canNest); allCans.Add(_canHumanStuff); allCans.Add(_canBuildingMaterial);
    }

    private void FixedUpdate()
    {

            v3_offSet = new Vector3(transform.position.x, transform.position.y + offSetRayY, transform.position.z);

            Vector3 toCamera = (GameObject.Find("Camera1").transform.position - transform.position).normalized;

             Debug.DrawLine(v3_offSet, GameObject.Find("Camera1").transform.position);

        /*        if (Physics.Raycast(transform.position, toCamera, 10))
                {
                    Debug.Log("There is something in front of the object!" +Time.time);
                    //Debug.DrawLine(transform.position, GameObject.Find("Camera1").transform.position);

                   //Debug.Log("hit name: " + hit.collider.gameObject.name);
                }*/


        var ray = new Ray(v3_offSet, toCamera);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
            if (hit.transform.gameObject.tag == "card")
            {
                lastHit = hit.transform.gameObject;
                turnBased.MouseUp_currentLand = gameObject;

                turnBased.MouseOver_currentLand = gameObject;  // when exit all grids, should be null

                // Debug.Log(gameObject.name + " is in the ray with... " + lastHit.name);

                //Debug.Log(gameObject.name + " hits " + hit.transform.gameObject.name);

                //Notification of Canput obj type

                /*                if (transform.GetChild(0).gameObject.GetComponent<grid>().canRichFood)
                                {
                                    GameObject canLand = Instantiate(Resources.Load("ui/canLand")) as GameObject;
                                    canLand.transform.localPosition = new Vector3(-680f, 150f, 455f);
                                }*/


                /*                        if (!hasGen)
                                        {
                                            genCanPutNotification(transform.GetChild(0).gameObject.GetComponent<grid>().canRichFood,
                                                                                  "ui/canLand", new Vector3(-680f, 150f, 455f));

                                            hasGen = true;
                                        }*/

                /*                if (transform.GetChild(0).gameObject.GetComponent<grid>().canRichFood)
                                {
                                    _canRichFood.SetActive(true);
                                }*/
/*                    showCanPutNotification(transform.GetChild(0).gameObject.GetComponent<grid>().canRichFood, _canRichFood);
                    showCanPutNotification(transform.GetChild(0).gameObject.GetComponent<grid>().canAveFood, _canAveFood);
                    showCanPutNotification(transform.GetChild(0).gameObject.GetComponent<grid>().canPoorFood, _canPoorFood);
                    showCanPutNotification(transform.GetChild(0).gameObject.GetComponent<grid>().canNPC, _canNPC);
                    showCanPutNotification(transform.GetChild(0).gameObject.GetComponent<grid>().canNest, _canNest);
                    showCanPutNotification(transform.GetChild(0).gameObject.GetComponent<grid>().canHumanMade, _canHumanStuff);
                    showCanPutNotification(transform.GetChild(0).gameObject.GetComponent<grid>().canBuildingMaterial, _canBuildingMaterial);*/

                if (lastHit.tag == "card" && !isPunch)
                {
                    transform.DOPunchScale(new Vector3(1.1f, 1.1f, 1.1f), 0.4f, 5, 1);
                    isPunch = true;
                }
                    }
/*                    else
                    {
                        for (int i = 0; i < allCans.Count; i++)
                        { allCans[i].SetActive(false);
                        }
                    }*/
            }
            else {
                        if (turnBased.MouseUp_currentLand == gameObject)
                        {
                           // print("out of ray: " + gameObject.name);
                            turnBased.MouseUp_currentLand = null;
                        }


                   }

            if (isPunch)
            {
                t = t + Time.deltaTime;
                //Debug.Log("t: " +t);
                if (t > 0.8f)
                {
                    isPunch = false;
                    t = 0f;
                }
            }
    }

    void genCanPutNotification(bool canWhat, string resLoad, Vector3 v3)
    {
        if (canWhat)
        {
            GameObject canLand = Instantiate(Resources.Load(resLoad)) as GameObject;
            canLand.transform.SetParent(GameObject.Find("Canvas"). transform);
            canLand.transform.localPosition = v3;
            canLand.transform.localScale = new Vector3(1f, 1f,1f);

        }
    }

    void showCanPutNotification(bool canWhat, GameObject goj )
    {
        if (canWhat)
        {
            goj.SetActive(true);
        }
    }
}
