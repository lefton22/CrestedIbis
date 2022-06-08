using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class story : MonoBehaviour
{
    public List<string> allStory;
    void Start()
    {
        for (int i = 0; i < 24; i++)
        {
            allStory.Add(" ");
        }
    }

    
    void Update()
    {
        
    }

    public void addTurnStory(int turn, string thisStory)
    {
        if (turn > 0)
        {
            allStory[turn - 1] += " _ " + thisStory;
        }
      
    }
}
