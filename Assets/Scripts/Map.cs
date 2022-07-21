using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 地图
/// </summary>
public class Map : MonoBehaviour
{
    //格子宽度 
    public float girdScale=1;
    //*    -1    0    1   *
    // -1.5   -0.5  0.5  1.5
    // -2    -1    0    1     2
    //  -1.5   -0.5  0.5  1.5
    //     -1    0     1
    //格子位置配置             
    public Vector3[] girdPos;
    /// <summary>
    /// 格子间距 这里指的是格子位置配置的间距
    /// </summary>
    public float girdSpacing = 1.5f;
    //格子元素
    public List<Gird> girds;
    //格子预设
    public GameObject girdPrefab;
    public static Map instance;

    //实时更新标记19个⼆维坐标上有没有所有物品（A和B）；
    public List<State> allItemList = new List<State>();
    //实时更新标记19个⼆维坐标上有没有A
    public List<State> itemAList = new List<State>();
    //实时更新标记19个⼆维坐标上有没有B
    public List<State> itemBList = new List<State>();
    private void Awake()
    {
        instance = this;

        Init();
    }
    public void Init()
    {
        for (int i = 0; i < girdPos.Length; i++)
        {
            GameObject gird = Instantiate(girdPrefab, transform);           
            gird.transform.localScale = Vector3.one * girdScale;  
            gird.transform.position = girdPos[i];
            girds.Add(gird.GetComponent<Gird>());

            allItemList.Add(new State());
            itemAList.Add(new State());
            itemBList.Add(new State());
        }
    }
    /// <summary>
    /// 获取到目标位置的一条路径
    /// </summary>
    /// <param name="startGird"></param>
    /// <param name="endGird"></param>
    public List<Gird> GetPath(Gird startGird,Gird endGird)
    {
        List<Gird> path = new List<Gird>();
        path.Add(startGird);
        DepthFind(startGird, endGird, path,0);     
        return path;
    }
    /// <summary>
    /// 广度优先搜索
    /// </summary>
    /// <param name="startGird"></param>
    /// <param name="endGird"></param>
    /// <param name="girds"></param>
    /// <returns></returns>
    public bool DepthFind(Gird startGird, Gird endGird,List<Gird> results,int pos)
    {
        List<Gird> nextGirds = GetNextGird(startGird);

        SortGird(nextGirds, endGird);

        Gird next = null;
        if (nextGirds == null) //无路可走，回退
        {
            if (results == null || results.Count <= 0) return false;//查找结束
            results.RemoveAt(results.Count - 1);
            if (results == null || results.Count <= 0) return false;//查找结束
            next = results[results.Count - 1];

            DepthFind(next,endGird,results,pos+1); //回退到上一步再继续向下递归查找
        }
        else
        {
            if (nextGirds.Contains(endGird)) //查找到
            {
                next = endGird;
                results.Add(next);
                return true;
            }
            else
            {
                if (pos >= nextGirds.Count)  //全部找过了
                {
                    if (results == null || results.Count <= 0) return false;//查找结束
                    results.RemoveAt(results.Count - 1);
                    if (results == null || results.Count <= 0) return false;//查找结束
                    next = results[results.Count - 1];
                    DepthFind(next, endGird, results, pos + 1);
                    //回退到上一步再继续向下递归查找
                }
                else
                {
                    next = nextGirds[pos];
                    if (results.Contains(next))
                    {
                        DepthFind(startGird, endGird, results, pos+1); //继续递归查找
                    }
                    else
                    {
                        results.Add(next);
                        DepthFind(next, endGird, results, 0); //继续向下递归查找
                    }
                    
                }
            }
        }
       
        return true;
    }
    /// <summary>
    /// 冒泡排序 按照距离targetGird远近排序
    /// </summary>
    private void SortGird(List<Gird> sortGirds,Gird targetGird)
    {
        if (sortGirds == null || targetGird == null) return;

        for (int i = 0; i < sortGirds.Count-1; i++)
        {
            for (int j = i+1; j < sortGirds.Count; j++)
            {
                float len1 = Vector3.Distance(sortGirds[i].transform.position, targetGird.transform.position);
                float len2 = Vector3.Distance(sortGirds[j].transform.position, targetGird.transform.position);

                if (len1 > len2)
                {
                    Gird temp = sortGirds[i];
                    sortGirds[i] = sortGirds[j];
                    sortGirds[j] = temp;
                }
            }
        }
    }
    /// <summary>
    /// 是否能移动到目标格子
    /// </summary>
    /// <param name="start"></param>
    /// <param name="target"></param>
    /// <returns></returns>
    public bool CanMove(Gird start,Gird end)
    {
        if (start.state == GirdState.Wall||end.state==GirdState.Wall) return false;

        return Vector3.Distance(start.transform.position, end.transform.position)<=girdSpacing;
    }
    /// <summary>
    /// 获取附近可移动的格子
    /// </summary>
    /// <param name="gird"></param>
    /// <returns></returns>
    public List<Gird> GetNextGird(Gird gird)
    {
        List<Gird> result = null;
        for (int i = 0; i < girds.Count; i++)
        {
            Gird target = girds[i];
            if (target == gird) continue;
            if (CanMove(gird, target))
            {
                if (result == null) result = new List<Gird>();
                result.Add(target);
            }
        }
        return result;
    }
    /// <summary>
    /// 获取下一个可移动的格子
    /// </summary>
    /// <param name="gird"></param>
    /// <returns></returns>
    public Gird GetSigleNextGird(Gird gird)
    {
        for (int i = 0; i < girds.Count; i++)
        {
            Gird target = girds[i];
            if (target == gird) continue;
            if (CanMove(gird, target))
            {
                return gird;
            }
        }
        return null;
    }
    /// <summary>
    /// 获取离目标最近的格子
    /// </summary>
    /// <param name="target"></param>
    /// <returns></returns>
    public Gird GetNearGird(Transform target)
    {
        if (girds == null || girds.Count <= 0) return null;
        Gird result = girds[0];
        for (int i = 1; i < girds.Count; i++)
        {
            Gird gird = girds[i];
            if (Vector3.Distance(target.position, gird.transform.position) < Vector3.Distance(target.position, result.transform.position))
            {
                result = gird;
            }
        }
        return result;
    }

    private void Update()
    {
        Nav[] navs=GameObject.FindObjectsOfType<Nav>();

        if (navs == null) return;

        for (int i = 0; i < navs.Length-1; i++)
        {
            Nav navA = navs[i];
            for (int j= i+1;j < navs.Length; j++)
            {
                Nav navB = navs[j];
                
                if (Vector3.Distance(navA.transform.position, navB.transform.position) < 0.1f) //相遇 A事件触发
                {
                    if (!(navA.isTriggerA))
                    {
                        navA.EventA();
                    }

                    if (!(navB.isTriggerA))
                    {
                        navB.EventA();
                    }

                    if (navA.BeArrive&&!navA.isTriggerB)  //A即将到达
                    {
                          navA.EventB();
                    }

                    if (navB.BeArrive&&!navB.isTriggerB)  //B即将到达
                    {
                        navB.EventB();
                    }
                }
            }
        }

        for (int i = 0; i < girds.Count; i++)
        {
            Gird gird = girds[i];

            State allState = allItemList[i];
            State aState = itemAList[i];
            State bState = itemBList[i];

            aState.Has= false;
            bState.Has = false;
            allState.Has = false;

            int aSte = 0,bSte=0;
            for (int j= 0; j < navs.Length; j++)
            {
                Nav nav = navs[j];

                if (Vector3.Distance(nav.transform.position, gird.transform.position)<0.1f) //在这个格子上
                {
                    if(nav.navType== NavType.NavA)
                    {
                        aState.Has = true;
                        aSte=1;
                    }
                    else if(nav.navType== NavType.NavB)
                    {
                        bState.Has= true;
                        bSte=1;
                    }
                }
            }

            if (aSte+bSte >= 2)
            {
                allState.Has = true;
            }
        }
    }
}
