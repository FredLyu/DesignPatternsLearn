/******************************************
 *	Title: 场景状态控制者
 *	Description:
 *	Date:
 *	Version:
 *	Modify Recoder:
 *****************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneStateController
{
    /// <summary>
    /// 状态
    /// </summary>
    private ISceneState m_State = null;

    /// <summary>
    /// 状态是不是刚启动
    /// </summary>
    private bool m_bRunBegin = false;

    /// <summary>
    /// 场景加载的进度
    /// </summary>
    private AsyncOperation asyncOperation;

    public SceneStateController() { }

    /// <summary>
    /// 设置状态
    /// </summary>
    /// <param name="state">具体状态的实例</param>
    /// <param name="loadSceneName">场景名称</param>
    public void SetState(ISceneState state,string loadSceneName)
    {
        m_bRunBegin = false;

        //加载场景
        LoadScene(loadSceneName);

        //释放前一个状态
        if (m_State != null)
            m_State.StateEnd();

        //更新状态
        m_State = state;
    }

    /// <summary>
    /// 载入场景
    /// </summary>
    /// <param name="sceneName">场景名称</param>
    private void LoadScene(string sceneName)
    {
        if (string.IsNullOrEmpty(sceneName))
            return;
        //异步加载场景
        asyncOperation = SceneManager.LoadSceneAsync(sceneName);
    }

    /// <summary>
    /// 更新
    /// </summary>
    public void StateUpdate()
    {
        //Debug.Log(asyncOperation.progress);
        //场景是否加载完成
        if (asyncOperation != null && !asyncOperation.isDone)
            return;

        //通知新的State开始
        if(m_State != null && m_bRunBegin == false)
        {
            m_bRunBegin = true;
            m_State.StateBegin();
        }

        //更新
        if (m_State != null)
            m_State.StateUpdate();
    }
}
