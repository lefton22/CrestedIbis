using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objFood : MonoBehaviour
{
    public int rich;
    public List<int> land; // suitable land

    public bool isToxic;

    void Start()
    {
        isToxic = false;
    }

    public void getPolluted()
    {
        isToxic = true;

        rich = rich - 1;
        if (rich < 0)
        { rich = 0; }
    }
}
