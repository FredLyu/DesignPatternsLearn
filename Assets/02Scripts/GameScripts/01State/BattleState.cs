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

public class BattleState : ISceneState
{
    public BattleState(SceneStateController controller) : base(controller)
    {
        StateName = "BattleState";
    }

    public override void StateBegin()
    {
        //游戏数据加载或初始化等
    }

    public override void StateEnd()
    {
        //状态的释放或其他资源的释放
    }

    public override void StateUpdate()
    {
        //输入
        InputProcess();

        //游戏逻辑更新

        //游戏是否结束
    }

    /// <summary>
    /// 游戏输入
    /// </summary>
    private void InputProcess()
    {
        //玩家输入程序判断代码......
    }
}
