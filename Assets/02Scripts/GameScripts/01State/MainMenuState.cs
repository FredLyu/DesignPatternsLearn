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
using UnityEngine.UI;

public class MainMenuState : ISceneState
{
    public MainMenuState(SceneStateController controller) : base(controller)
    {
        StateName = "MainMenuState";
    }

    /// <summary>
    /// 开始
    /// </summary>
    public override void StateBegin()
    {
        Button tempBtn = GameObject.Find("StartGameBtn").GetComponent<Button>();
        if (tempBtn)
            tempBtn.onClick.AddListener(() => OnStartGameBtnClick(tempBtn));
    }

    /// <summary>
    /// 开始游戏按键的响应事件
    /// </summary>
    /// <param name="button"></param>
    private void OnStartGameBtnClick(Button button)
    {
        m_Controller.SetState(new BattleState(m_Controller), "BattleScene");
    }
}
