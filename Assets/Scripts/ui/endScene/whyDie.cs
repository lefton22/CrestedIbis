using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whyDie : MonoBehaviour
{
    
    void Start()
    {
        if (endCheck.isEndByCheck)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "Ŀǰ�汾��Ϸ������ʱ���ˡ�";
            
        }
        if (!endCheck.isEndByCheck)
        {
            GetComponent<TMPro.TextMeshProUGUI>().text = "��ֻ�������ڼ�����";

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
