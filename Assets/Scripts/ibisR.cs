using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ibisR : MonoBehaviour
{
    Animator ani;
    void Start()
    {
        ani=GetComponent<Animator>();
    }


    void Update()
    {
        
    }

    public void setHasBreakTrap()
    {
        ani.SetBool("hasBreakTrap", true);
    }
}
