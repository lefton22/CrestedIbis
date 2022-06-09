using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class clickToNext : MonoBehaviour
{
    public string scenename;

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }

    public void goToNextScene()
    {
        SceneManager.LoadScene(scenename);
    }
}
