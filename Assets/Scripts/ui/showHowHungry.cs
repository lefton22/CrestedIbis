using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class showHowHungry : MonoBehaviour
{
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = Panda.Ibis.MyIbis.full.ToString();
    }
}
