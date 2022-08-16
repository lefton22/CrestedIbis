using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSoundEffect : MonoBehaviour
{
    AudioSource thisSoundEffect;
    void Start()
    {
        thisSoundEffect = GetComponent<AudioSource>();
    }



    public void playThisSF()
    {
        thisSoundEffect.Play();

       // print("play sf");
    }

    public void stopPlayThisSF()
    {
        thisSoundEffect.Stop();

      //  print("stop playing sf");
    }
}
