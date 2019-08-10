/******************************************
 *	Title: 游戏主循环，完成游戏的更新
 *	Description:
 *	Date:
 *	Version:
 *	Modify Recoder:
 *****************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    private SceneStateController sceneStateController = new SceneStateController();

    private void Awake()
    {
        //切换场景时不销毁
        DontDestroyOnLoad(this.gameObject);

        //随机数种子
        Random.InitState((int)System.DateTime.Now.Ticks);
    }

    private void Start()
    {
        //设置起始场景
        sceneStateController.SetState(new StartState(sceneStateController), "");
    }

    // Update is called once per frame
    void Update()
    {
        //更新
        sceneStateController.StateUpdate();
    }
}
