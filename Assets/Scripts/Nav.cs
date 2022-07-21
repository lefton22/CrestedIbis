using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
/// <summary>
/// 寻路代理
/// </summary>
public class Nav : MonoBehaviour
{
    //代理类型 A或B
    public NavType navType;
    //移动速度
    public float speed;
    //停止距离
    public float stopDistance=0.02f;
    /// <summary>
    /// 步长 每走一步 +1
    /// </summary>
    public int stepLength;
    public bool isStoped
    {
        get => isStop;
        set
        {
            isStop = value;

            for (int i = 0; i < path.Count; i++)  //上色
            {
                path[i].SetColor(GameManager.istance.colors[0]);
            }
        }
    }
    //是否暂停
    private bool isStop;
    //目标位置
    private Gird targetGird;
    /// <summary>
    /// 移动路径
    /// </summary>
    private List<Gird> path;
    /// <summary>
    /// 路径索引
    /// </summary>
    private int pathIndex;
    /// <summary>
    /// 到达目标位置触发事件
    /// </summary>
    public Action reachAction;
    /// <summary>
    /// 代理A和代理B在⾛动过程时相遇会发⽣事件A( eventA())，并且停⽌⾛动且停留在这⼀格。
    /// </summary>
    public Action eventA;
    /// <summary>
    /// 代理A在到达⽬的地格⼦后若与代理B相遇会发⽣事件B（eventB()）。
    /// </summary>
    public Action eventB;
    //标志是否触发了A事件
    public bool isTriggerA { get; set; }
    //标志是否触发了B事件
    public bool isTriggerB { get; set; }
    /// <summary>
    /// 是否到达目标点
    /// </summary>
    public bool isReach
    {
        get;
        private set;
    }
    /// <summary>
    /// 即将到达目标点
    /// </summary>
    public bool BeArrive
    {
        get
        {
            if (path == null || path.Count <= 0) return false;

            return Vector3.Distance(transform.position, path[path.Count - 1].transform.position) <=stopDistance;
        }
    }
    /// <summary>
    /// 设置导航位置 基于一个格子单位
    /// </summary>
    /// <param name="pos"></param>
    public void SetMoveGird(Gird gird)
    {
       

        Gird selfGird = Map.instance.GetNearGird(transform); //获取代理自身所在的格子位置

        if (selfGird == null)
        {
            path = null;
        }
        else
        {
            path = Map.instance.GetPath(selfGird,gird);
        }

     
        pathIndex = 0;
        isReach = false;

        isStop = false;

        targetGird = gird;

        Debug.Log("开始导航");
        if (path != null)
        {
            for (int i = 0; i < path.Count; i++)  //上色
            {
                path[i].SetColor(GameManager.istance.colors[2]);
            }
        }
    }


    private void Update()
    {
        if (isStop||targetGird==null||path==null||path.Count<=0) return;

        if (pathIndex>=path.Count)
        {
            transform.position= path[path.Count-1].transform.position;
            isStop = true;
            isReach = true;

            Reach();
            return;
        }

        Gird gird = path[pathIndex % path.Count];
        Vector3 dirc = gird.transform.position - transform.position;
        transform.position += dirc.normalized * Time.deltaTime * speed;
        if (Vector3.Distance(transform.position,gird.transform.position)<stopDistance)
        {
            if (pathIndex > 0)  //如果只想执行一次，就注释下面两段代码
            {
                isTriggerA = false;
                isTriggerB = false;
            }
            gird.SetColor(GameManager.istance.colors[0]);
            pathIndex++;
            stepLength++;
        }
    }
    /// <summary>
    /// 到达目标位置回调
    /// </summary>
    public void Reach()
    {
        reachAction?.Invoke();
        Debug.Log("到达目标点");

        isStoped = true;
    }
    /// <summary>
    /// 事件A
    /// </summary>
    public void EventA()
    {
       

        eventA?.Invoke();

        if (navType ==  NavType.NavA) //默认为A 触发事件暂停
        {
            isStoped = true;
            Adjust();
        }

        isTriggerA = true;
        Debug.Log("事件A触发  :触发"+gameObject.name);
    }
    /// <summary>
    /// 事件B
    /// </summary>
    public void EventB()
    {
        eventB?.Invoke();

        isTriggerB = true;
        Debug.Log("事件B触发   触发" + gameObject.name);
    }
    /// <summary>
    /// 校准位置
    /// </summary>
    public void Adjust()
    {
        if (path == null||path.Count<=0) return;
        transform.position = path[pathIndex % path.Count].transform.position;
    }
    public List<Gird> Getpath()
    {
        return path;
    }
}
public enum NavType
{
    NavA,
    NavB
}