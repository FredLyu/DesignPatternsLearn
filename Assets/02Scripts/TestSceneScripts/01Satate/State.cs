using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 状态接口类
/// </summary>
public abstract class State
{
    protected Context m_Context = null;
    public State(Context theContext)
    {
        m_Context = theContext;
    }

    public abstract void Handle(int value);
}
