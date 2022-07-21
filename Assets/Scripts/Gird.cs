using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// 构成地图的格子元素
/// </summary>
public class Gird : MonoBehaviour
{
    public GirdState state;

    public void SetColor(Color color)
    {
        GetComponent<MeshRenderer>().material.color = color;
    }

}
/// <summary>
/// 格子状态
/// </summary>
public enum GirdState
{
    /// <summary>
    /// 空格子
    /// </summary>
    Null,
    /// <summary>
    /// 墙/障碍物
    /// </summary>
    Wall,
    /// <summary>
    /// 其他状态 例如有导航代理在格子上
    /// </summary>
    Other
}
[System.Serializable]
public class State
{
    //是否有物品 /是否有A  /是否有B
    public bool Has;
}