using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleState : State
{
    public override void Enter()
    {
        Debug.Log("Idle Enter");
    }

    public override void Exit()
    {
        Debug.Log("Idle Exit");
    }
}
