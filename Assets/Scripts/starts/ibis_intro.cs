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
        intro.Add ( "�������Ҷ��ԣ����q��������һ��������һ���������������޿�����ģ����������������һ������ ");
        intro.Add(" ���˶���һ��������������Ϊ������ʧȥ���塣��");
        intro.Add(" ���Ҳ��ں������� ��ı����ǵ����ˣ�ֻϣ�������������γ��������õ���Ȼ����������������� ");
        //��һҳ���q������Ķ�����
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
