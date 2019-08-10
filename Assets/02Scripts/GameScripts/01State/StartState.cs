/******************************************
 *	Title:
 *	Description:
 *	Date:
 *	Version:
 *	Modify Recoder:
 *****************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartState : ISceneState
{
    public StartState(SceneStateController controller) : base(controller)
    {
        StateName = "StartState";
    }

    /// <summary>
    /// 开始
    /// </summary>
    public override void StateBegin()
    {
        //可以在此进行游戏数据加载和初始化等
    }

    /// <summary>
    /// 更新
    /// </summary>
    public override void StateUpdate()
    {
        //更新状态
        m_Controller.SetState(new MainMenuState(m_Controller), "MainMenuScene");
    }
}
