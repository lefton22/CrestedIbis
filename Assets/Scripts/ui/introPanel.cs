using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class introPanel : MonoBehaviour
{
    public GameObject pPanel;
    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void openPanel()
    {
        if (pPanel != null)
        {
            bool isActive = pPanel.activeSelf;
            pPanel.SetActive(!isActive);
        }
    }
}