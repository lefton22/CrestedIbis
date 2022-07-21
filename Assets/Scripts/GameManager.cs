using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Nav A;//A代理
    public Nav B1;//B1代理
    public Nav B2;//B2代理
    //A点位置
    public int Apos;
    //B1点位置
    public int B1pos;
    //B2点位置
    public int B2pos;
    //设置格子的状态
    public GirdState[] girdStates;
    //格子的颜色，对应格子的状态
    public Color[] colors;
    /// <summary>
    /// 当前选中操作的代理
    /// </summary>
    private Nav selectNav;
    private int navIndex;
    public static GameManager istance;


    /// <summary>
    /// // self adding content
    public List<Nav> allObjsNav; // includes all elements on the lands

    /// </summary>
    private void Awake()
    {
        istance = this;
    }
    private void Start()
    {
        for (int i = 0; i < Map.instance.girds.Count; i++)
        {
            if (i >= girdStates.Length) break;
            Gird gird = Map.instance.girds[i];
            gird.state = girdStates[i];

            gird.SetColor(colors[(int)gird.state]);
        }

        A.transform.position = Map.instance.girds[Apos].transform.position;
        B1.transform.position= Map.instance.girds[B1pos].transform.position;
        B2.transform.position = Map.instance.girds[B2pos].transform.position;

        selectNav = A;

        /// <summary>
        /// // self adding content
        allObjsNav = new List<Nav>();
        // add all Navs
       // allObjsNav.Add(GameObject.Find("ibisA").GetComponent<Nav>());

       
        addInAllObjsNav("ibisA");
        addInAllObjsNav("trap");




        // set all Navs pos

        for (int i =0; i < allObjsNav.Count; i++)
        {
            setNavPos(allObjsNav[i], i+2); // pos?
            
        }

        /// </summary>

    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(ray,out hit, 1000))
            {
                if (hit.collider.CompareTag("Respawn")) 
                {
                    Gird gird = hit.collider.GetComponent<Gird>();
                    selectNav.SetMoveGird(gird);
                }
            }
        }

        if (Input.GetMouseButtonDown(1)) //鼠标右键切换代理
        {
            navIndex++;

            if (navIndex % 3 == 0)
            {
                selectNav = A;
            }
            else if (navIndex % 3 == 1)
            {
                selectNav =GameObject.Find("ibisA").GetComponent<Nav>();
            }
            else if (navIndex % 3 == 2)
            {
                selectNav = GameObject.Find("trap").GetComponent<Nav>(); ;
            }
        }
    }

    public void setNavPos(Nav objOnLand, int pos)
    {
        objOnLand.transform.position = Map.instance.girds[pos].transform.position;
    }

    void addInAllObjsNav(string GojHasNav)
    {
        if (!allObjsNav.Contains(GameObject.Find(GojHasNav).GetComponent<Nav>()))
        { allObjsNav.Add(GameObject.Find(GojHasNav).GetComponent<Nav>()); }
    }
}
