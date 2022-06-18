using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class endCheck : MonoBehaviour
{
    turnBased _turnBased;

    static public List<string> narrative;

    static public bool isEndByCheck;

    public string scenename; 

    void Start()
    {
        _turnBased = GameObject.Find("TurnBased").GetComponent<turnBased>();

        isEndByCheck = false;
    }

    void Update()
    {
        
    }

    public void checkEnd() 
        // go to the end check scene
        // copy the narrative list
    {
        isEndByCheck = true;

        narrative = new List<string>(GameObject.Find("TurnBased").GetComponent<story>().allStory);

/*        //����Ǹ���ʲô��û�������ڿհ׵��������һ�仰
        for (int i = 0; i < narrative.Count; i++)
        {
            if (narrative[i] == " ")
            {
                int e_turn;
                if (narrative.IndexOf(narrative[i]) <= 12)
                {
                    e_turn = (narrative.IndexOf(narrative[i]) - 1) / 2 + 7;
                    narrative[i] += "��" + e_turn.ToString() + "�£�ʲôҲû�����ɡ�";
                }
                if (narrative.IndexOf(narrative[i]) > 12)
                {
                    e_turn = (narrative.IndexOf(narrative[i]) - 1) / 2 + 7 - 12;
                    narrative[i] += "��" + e_turn.ToString() + "�£�ʲôҲû�����ɡ�";
                }
            }
            print("0 narr: " + narrative[i]);
        }*/

        foreach (string narr in narrative)
        {
            print("narr: " +narr);
        }

        print("end check.");
        loadMainScene();

     }


    void loadMainScene()
    {
        SceneManager.LoadScene(scenename);
    }
}
