using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class clickToNext : MonoBehaviour
{
    public string scenename;

    public AudioSource as_click;

    void Start()
    {
        if (GetComponent<AudioSource>())
        {
            as_click = GetComponent<AudioSource>();
        }
    }

    
    void Update()
    {
        
    }

    public void goToNextScene()
    {
        SceneManager.LoadScene(scenename);
    }

    public void ClickB()
    {
        if (as_click)
        {
            as_click.Play();
        }
    }
}
