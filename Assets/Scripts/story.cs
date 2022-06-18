using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class story : MonoBehaviour
{
    public List<string> allStory;

    GameObject _plots;
    void Start()
    {
        for (int i = 0; i < 24; i++)
        {
            allStory.Add(" ");
        }

        _plots = GameObject.Find("plots");

        GameObject[] nests;
        nests = GameObject.FindGameObjectsWithTag("nest");
        print("nests " +nests.Length);
    }

    
    void Update()
    {
        
    }

    public void addTurnStory(int turn, string thisStory)
    {
        if (turn > 0)
        {
            allStory[turn - 1].Remove(0, 1);
            allStory[turn - 1] +=  thisStory;
        }
      
    }

    public void showPlotsThisTurn(string thisTurnPlot) // called from MyIbis.cs
    {
        //_plots.GetComponent<TMPro.TextMeshProUGUI>().text ="¶î";
        _plots.GetComponent<TMPro.TextMeshProUGUI>().text = thisTurnPlot;
    }
}
