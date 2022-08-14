using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class story : MonoBehaviour
{
    public List<string> allStory;

    public List<int> allStoryType;  // for gen an icon 
                                    // 0 = month, 1= small action, 2=big action, 3 = meet trap,
                                    // 4 = pick a twig( no need this)

    GameObject _plots;
    void Start()
    {
        /*        for (int i = 0; i < 24; i++)
                {
                    allStory.Add(" ");
                }*/
        allStory = new List<string>();

        _plots = GameObject.Find("plots");

        GameObject[] nests;
        nests = GameObject.FindGameObjectsWithTag("nest");
       // print("nests " +nests.Length);
    }


    public void addTurnStory(int turn, string thisStory, int type) // int turn is useless now
    {
        if (turn > 0)
        {
/*            allStory[turn - 1].Remove(0, 1);
            allStory[turn - 1] +=  thisStory; */

            allStory.Add(thisStory);

            allStoryType.Add(type);
        }
      
    }

    public void showPlotsThisTurn(string thisTurnPlot) // called from MyIbis.cs
    {

        // _plots.GetComponent<TMPro.TextMeshProUGUI>().text = thisTurnPlot;
        _plots.GetComponent<Text>().text = thisTurnPlot;
    }
}
