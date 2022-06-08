using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class gameStart : MonoBehaviour
{
    public string scenename;
    void Start()
    {
        
    }

    void loadMainScene()
    {
        SceneManager.LoadScene(scenename);
    }
}
