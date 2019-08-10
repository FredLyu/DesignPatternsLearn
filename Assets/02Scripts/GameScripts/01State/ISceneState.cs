/******************************************
 *	Title: 场景状态类的基
 *	Description:
 *	Date:
 *	Version:
 *	Modify Recoder:
 *****************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ISceneState
{
    /// <summary>
    /// 状态名称
    /// </summary>
    private string m_StateName = "ISceneState";
    public string StateName
    {
        get
        {
            return m_StateName;
        }
        set
        {
            m_StateName = value;
        }
    }

    /// <summary>
    /// 状态控制者
    /// </summary>
    protected SceneStateController m_Controller = null;

    public ISceneState(SceneStateController controller)
    {
        m_Controller = controller;
    }

    /// <summary>
    /// 状态开始，可初始化一些数据
    /// </summary>
    public virtual void StateBegin() { }

    /// <summary>
    /// 状态更新，可以做游戏定时更新输入等
    /// </summary>
    public virtual void StateUpdate() { }

    /// <summary>
    /// 状态结束，可做资源释放
    /// </summary>
    public virtual void StateEnd() { }
}
