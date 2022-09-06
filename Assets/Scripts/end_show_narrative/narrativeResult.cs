using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class narrativeResult : MonoBehaviour
{
    //public string allPlots;

    public List<string> allPlots;
    public List<int> allPlostsType;

    float xStartFrame;

    GameObject _rightD;

    float posY1, posY2, posY3, posY4 ;
    float offsetMonthEventY;
    float offsetMonthEventX;

    GameObject _StrucFrame;

    //float xCurrent;


    void Start()
    {
        _StrucFrame = GameObject.Find("StrucFrame");

        posY1 = GameObject.Find("y1").transform.position.y;
        posY2 = GameObject.Find("y2").transform.position.y;
        posY3 = GameObject.Find("y3").transform.position.y;
        posY4 = GameObject.Find("y4").transform.position.y;

        _rightD = GameObject.Find("rightD");

        offsetMonthEventY = 1.11f;
        offsetMonthEventX = _rightD.transform.position.x - GameObject.Find("1月").transform.position.x;

    //!!!comment for test !!!
/*        for (int i = 0; i < endCheck.narrative.Count; i++)
        {
            allPlots.Add(endCheck.narrative[i]);
        }
        for (int i = 0; i < endCheck.narrativeType.Count; i++)
        {
            allPlostsType.Add(endCheck.narrativeType[i]);
        }*/

        showNarrRes();
        // showNarrResT();



        // get the distance
        float disSmallC = Vector3.Distance(GameObject.Find("leftD2").transform.position,
                                            GameObject.Find("rightD2").transform.position);
        float disMidC = Vector3.Distance(GameObject.Find("leftD3").transform.position,
                                    GameObject.Find("rightD3").transform.position);
        float disShortL = Vector3.Distance(GameObject.Find("leftD4").transform.position,
                            GameObject.Find("rightD4").transform.position);

        foreach (Transform child in GameObject.Find("StoryStructSample").transform)
        {
            child.gameObject.GetComponent<SpriteRenderer>().enabled = false;
        }

        xStartFrame = GameObject.Find("leftD").transform.position.x;

        // get the distance
        //

        //print("Distance to other: " + disSmallC);
    }


    void showNarrRes()
    {
        //!!!comment for test !!!
        // int indexMax = endCheck.narrative.Count;
        int indexMax = 5;
        int indexCurrent = 0;
        float xCurrent = -1f;
        GameObject currentFrame;

        while (indexCurrent < indexMax)
        {
            if (indexCurrent == 0)
            {
                xCurrent = GameObject.Find("leftD").transform.position.x;
                currentFrame = null;
            }
            if (indexCurrent > 0)
            { //xCurrent = }

                //check if the rest distance is enough  
 

            }

            if (allPlostsType[indexCurrent] == 0) //month
            {
                //check which circle/pattern
                GameObject month = Instantiate(Resources.Load("ui/narScene/1月")) as GameObject;
                string xMonth = allPlots[indexCurrent];
                month.GetComponent<Image>().sprite = Resources.Load<Sprite>("ui/formal/"+ xMonth); //change this to image
                month.transform.SetParent(_StrucFrame.transform);
                month.name = xMonth;
                float x = _rightD.transform.position.x + offsetMonthEventX;
                float y = posY1 + offsetMonthEventY;
                month.transform.position = new Vector3(x,y,0f);

                //get distance(x)
                //but dont need this step when it's the first.
            }
            if (allPlostsType[indexCurrent] == 1) //small action, includes eat, 
            { }
            if (allPlostsType[indexCurrent] == 2) //big action
            { }
            if (allPlostsType[indexCurrent] == 3) //meet a trap
            { }

            /*            float disCurrentRest = _rightD.transform.position.x - xCurrent;
                        if (disCurrentRest <)*/

            indexCurrent = indexCurrent + 1;
        }
        /*    void showNarrResT()
            {
                GameObject.Find("narResults").GetComponent<TMPro.TextMeshProUGUI>().text = "lll<br> ooo";
            }*/

    }
}