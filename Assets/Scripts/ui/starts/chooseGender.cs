using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chooseGender : MonoBehaviour
{
    static public int cGender; //1= female, 2 = male
    GameObject _EnterIntoMainScene;

    AudioSource as_click;
    void Start()
    {
        cGender = 0;
        _EnterIntoMainScene = GameObject.Find("EnterIntoMainScene");

        as_click = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void cFemale()
    {
        cGender = 1;
        _EnterIntoMainScene.GetComponent<clickToNext>().goToNextScene();
    }
    public void cMale()
    {
        cGender = 2;
        _EnterIntoMainScene.GetComponent<clickToNext>().goToNextScene();
    }

    public void ClickB()
        {
        as_click.Play();
        }
}
