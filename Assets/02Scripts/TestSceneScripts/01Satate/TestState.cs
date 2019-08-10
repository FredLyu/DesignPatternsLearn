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

public class TestState : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Context context = new Context();
        context.SetState(new ConcreteStateA(context));
        context.Request(5);
        context.Request(15);
        context.Request(25);
        context.Request(35);
    }
}
