/******************************************
 *	Title: 具体状态类，继承自State
 *	Description:
 *	Date:
 *	Version:
 *	Modify Recoder:
 *****************************************/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteStateA : State
{
    public ConcreteStateA(Context theContext) : base(theContext)
    {
    }

    public override void Handle(int value)
    {
        Debug.Log("ConcreteStateA.Handle");
        if(value > 10)
        {
            m_Context.SetState(new ConcreteStateB(m_Context));
        }
    }
}

public class ConcreteStateB : State
{
    public ConcreteStateB(Context theContext) : base(theContext)
    {
    }

    public override void Handle(int value)
    {
        Debug.Log("ConcreteStateB.Handle");
        if (value > 20)
        {
            m_Context.SetState(new ConcreteStateC(m_Context));
        }
    }
}

public class ConcreteStateC : State
{
    public ConcreteStateC(Context theContext) : base(theContext)
    {
    }

    public override void Handle(int value)
    {
        Debug.Log("ConcreteStateC.Handle");
        if (value > 30)
        {
            m_Context.SetState(new ConcreteStateA(m_Context));
        }
    }
}
