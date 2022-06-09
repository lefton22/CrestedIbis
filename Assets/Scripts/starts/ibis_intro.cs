using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ibis_intro : MonoBehaviour
{
    List <string> intro;
    public string scenename;

    float t;
    void Start()
    {
        intro = new List<string>();
        intro.Add ( "“对于我而言，朱鹮不仅仅是一种鸟。它是一个生命，生命是无可替代的，和我们人类的生命一样。” ");
        intro.Add(" “人都有一死。人生并不因为会死就失去意义。”");
        intro.Add(" “我不在乎最终能 否改变它们的命运，只希望它们能在明治初期那样好的自然环境里，走完余生。” ");
        //放一页朱鹮挤眼泪的动画？
    }

    
    void Update()
    {
        // print("time: " + Time.deltaTime);;
/*        t = t + Time.deltaTime;
        // print("time: " + t);

        if ()*/
    }

    void switchToMainScene()
    {
        SceneManager.LoadScene(scenename);
    }
}
