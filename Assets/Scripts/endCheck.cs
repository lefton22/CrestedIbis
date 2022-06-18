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

/*        //如果那个月什么都没有做，在空白的组里面加一句话
        for (int i = 0; i < narrative.Count; i++)
        {
            if (narrative[i] == " ")
            {
                int e_turn;
                if (narrative.IndexOf(narrative[i]) <= 12)
                {
                    e_turn = (narrative.IndexOf(narrative[i]) - 1) / 2 + 7;
                    narrative[i] += "在" + e_turn.ToString() + "月，什么也没有做成。";
                }
                if (narrative.IndexOf(narrative[i]) > 12)
                {
                    e_turn = (narrative.IndexOf(narrative[i]) - 1) / 2 + 7 - 12;
                    narrative[i] += "在" + e_turn.ToString() + "月，什么也没有做成。";
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
