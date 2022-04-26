using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class showV2 : MonoBehaviour
{
    LandGen2 _LandGen2;
    void Start()
    {
        show_V2();



    }

    public void show_V2()
    {
        _LandGen2 = GameObject.Find("LandGenerator").GetComponent<LandGen2>();

        for (int i = 0; i < _LandGen2.LandCos_GO.Count; i++)
        {
            GameObject _showV2 = Instantiate(Resources.Load("goj/showV2")) as GameObject;

            string s_v2;
            s_v2 = _LandGen2.LandCos_GO[i].GetComponent<genPos>().thisCo.ToString() ;
            _showV2.GetComponent<TMPro.TextMeshPro>().text = s_v2;

            _showV2.transform.position = _LandGen2.LandCos_GO[i].transform.position;
            _showV2.transform.SetParent(GameObject.Find("Chesses").transform);

            _showV2.name = "show v2_" + i.ToString();
          //  print("show v2. "  + i);

            _showV2.transform.DOLocalMoveZ(-0.7f, 0.1f);
        }

       // print("show v2.");
    }
    
}
