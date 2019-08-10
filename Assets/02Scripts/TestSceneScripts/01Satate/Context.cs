using System.Collections;
using System.Collections.Generic;
using UnityEngine;


/// <summary>
/// 状态拥有者
/// </summary>
public class Context
{
    private State m_State = null;

    public void Request(int value)
    {
        m_State.Handle(value);
    }

    public void SetState(State theState)
    {
        Debug.Log("Context.SetState : " + theState);
        m_State = theState;
    }
}
