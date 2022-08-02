using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//      寻路必要1： 添加这个 Nav.cs
//121// 寻路必要2: 将需要寻路的物体加入这个list   ?!
//116// 寻路必要3：设置包含Nav的物体所在格子的地方    !?
//58//  寻路必要4(1/2)：是当下的selectnav
//128// 寻路必要4(2/2)：是当下的selectnav

public class GameManager : MonoBehaviour
{
    /*  public Nav A;//A代理
        public Nav B1;//B1代理
        public Nav B2;//B2代理
        //A点位置
        public int Apos;
        //B1点位置
        public int B1pos;
        //B2点位置
        public int B2pos;*/
    

    public List<Nav> foodsNav; // add when putting on lands, remove when being eaten
    public List<Nav> materialsNav; // add when putting on lands, remove when being taken
    public List<Nav> nestsNav; //add when putting on lands, remove when being ???
    public List<Nav> NPCsNav;  //add when putting on lands, remove when being ???
    public List<Nav> trapsNav; // add when trapman put it on  (NPCact()), remove when being touched

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

    GameObject _ibisA;


    /// </summary>
    private void Awake()
    {
        istance = this;

        for (int i = 0; i < 19; i++)
        {
            foodsNav.Add(null);
            materialsNav.Add(null);
            nestsNav.Add(null);
            NPCsNav.Add(null);
            trapsNav.Add(null); 
        }
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

/*        A.transform.position = Map.instance.girds[Apos].transform.position;   //根据格子的序号找到格子然后定位置
        B1.transform.position= Map.instance.girds[B1pos].transform.position;
        B2.transform.position = Map.instance.girds[B2pos].transform.position;*/

        /// <summary>
        /// // self adding content
        /// 
        _ibisA = GameObject.Find("ibisA");
        selectNav = _ibisA.GetComponent<Nav>();  // 寻路必要4(1/2)：是当下的selectnav


        allObjsNav = new List<Nav>();
        // add all Navs
         allObjsNav.Add(GameObject.Find("ibisA").GetComponent<Nav>());

        addInAllObjsNav("ibisA");
        //addInAllObjsNav("trap");

        // set all Navs pos 暂时的

        for (int i = 0; i < allObjsNav.Count; i++)
        {
            setNavPos(allObjsNav[i], i + 2); // pos?

        }

        /// </summary>

    }

    private void Update()
    {
/*        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray=Camera.main.ScreenPointToRay(Input.mousePosition); //摄像头到鼠标位置
            if(Physics.Raycast(ray,out hit, 1000))
            {
                if (hit.collider.CompareTag("Respawn")) 
                {
                    Gird gird = hit.collider.GetComponent<Gird>();
                    selectNav.SetMoveGird(gird);
                }
            }
        }*/
/*
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
                selectNav = B2;
            }
        }*/


        //////addd
        ///
        //Map.instance.girds[Apos]
        /// 
        ///addd


    }

    public void setNavPos(Nav objOnLand, int pos) // 寻路必要3：设置包含Nav的物体所在格子的地方
    {
        objOnLand.transform.position = Map.instance.girds[pos].transform.position;
    }

    void addInAllObjsNav(string GojHasNav) // 寻路必要2: 将需要寻路的物体加入这个list
    {
        if (!allObjsNav.Contains(GameObject.Find(GojHasNav).GetComponent<Nav>()))
        { allObjsNav.Add(GameObject.Find(GojHasNav).GetComponent<Nav>()); }
    }


    public void setSelectNav(Nav pointedObj)
    {
        selectNav = pointedObj;

        print("setSelectNav() : " + pointedObj);
        
    }
    public void setMovingGoal(int goalIndex)   //寻路必要4(2/2)：移动到指定点
                                               //游戏中默认selectNav是ibisA
                                               //NPC 回合时是对应的NPC
    {
        print("setMovingGoal 0");

        if (goalIndex >= 0 && goalIndex <= 18)
        {
     //       print("setMovingGoal 1");

/*            Vector3 goalPos = new Vector3( Map.instance.girds[goalIndex].transform.position.x,
                                           Map.instance.girds[goalIndex].transform.position.y,
                                           Map.instance.girds[goalIndex].transform.position.z + 0.7f);*/
            /*            RaycastHit hit;
                        Ray ray = Camera.main.ScreenPointToRay(goalPos); // Vector3 设置成要去的格子的位置*/
            //  Map.instance.girds[Apos].transform.position;  
            // Apos是格子的序号

            Gird gird = Map.instance.girds[goalIndex];
            selectNav.SetMoveGird(gird);

    //        print("setMovingGoal 3");

        }
    }
}
