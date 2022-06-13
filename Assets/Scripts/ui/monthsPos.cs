using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using DG.Tweening;

public class monthsPos : MonoBehaviour
{
    // 6: -460, 490    897
    // 7: -370        -2
    // 8: -295     75
    // 9: -215      155
    // 10:  -135     230
    // 11:  -55      310
    // 12: 25         388
    // 01:  110       470
    // 02£º 200        552
    // 03: 290        635
    // 04:  365        730
    // 05: 455          816
    public List<float> monthXs;
    //public float month7X, month8X, month9X, month10X, month11X, month12X, month1X, month2X, month3X, month4X, month5X, month6X;

    public GameObject _1p;
    public GameObject _2p;
    public GameObject _3p;
    public GameObject _4p;
    public GameObject _5p;
    public GameObject _6p;
    public GameObject _7p;
    public GameObject _8p;
    public GameObject _9p;
    public GameObject _10p;
    public GameObject _11p;
    public GameObject _12p;

    void Start()
    {
        //gameObject.transform.localPosition = new Vector3(10f, 10f, 0f);
        // month7X = 
        monthXs.Add(_1p.GetComponent<RectTransform>().anchoredPosition.x);
        monthXs.Add(_2p.GetComponent<RectTransform>().anchoredPosition.x);
        monthXs.Add(_3p.GetComponent<RectTransform>().anchoredPosition.x);
        monthXs.Add(_4p.GetComponent<RectTransform>().anchoredPosition.x);
        monthXs.Add(_5p.GetComponent<RectTransform>().anchoredPosition.x);
        monthXs.Add(_6p.GetComponent<RectTransform>().anchoredPosition.x);
        monthXs.Add(_7p.GetComponent<RectTransform>().anchoredPosition.x);
        monthXs.Add(_8p.GetComponent<RectTransform>().anchoredPosition.x);
        monthXs.Add(_9p.GetComponent<RectTransform>().anchoredPosition.x);
        monthXs.Add(_10p.GetComponent<RectTransform>().anchoredPosition.x);
        monthXs.Add(_11p.GetComponent<RectTransform>().anchoredPosition.x);
        monthXs.Add(_12p.GetComponent<RectTransform>().anchoredPosition.x);

 /*       float x;
        x = transform.parent.gameObject.GetComponent<monthsPos>().monthXs[6];
        transform.DOLocalMoveX(x, 1f);*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
