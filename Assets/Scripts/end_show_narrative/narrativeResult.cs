using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class narrativeResult : MonoBehaviour
{
    public string allPlots;

    void Start()
    {
/*        foreach (string narr in endCheck.narrative)
        {
            allPlots += "<br>" +narr;
            print("end check scene: " + narr);
        }*/

        for (int i = 0; i < endCheck.narrative.Count; i++)
        {
            if (i / 2 != 0)
            { allPlots +=  endCheck.narrative[i]; }
            if (i / 2 == 0)
            { allPlots += "<br>" + endCheck.narrative[i]; }
        }

        showNarrRes();
       // showNarrResT();
    }

    void Update()
    {
        
    }

    void showNarrRes()
    { 
        GameObject.Find("narResults").GetComponent<TMPro.TextMeshProUGUI>().text = allPlots;
    }
/*    void showNarrResT()
    {
        GameObject.Find("narResults").GetComponent<TMPro.TextMeshProUGUI>().text = "lll<br> ooo";
    }*/

}
