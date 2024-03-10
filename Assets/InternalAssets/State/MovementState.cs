using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementState : State
{
    public override void Enter()
    {
        Debug.Log("Movement Enter");
    }

    public override void Exit()
    {
        Debug.Log("Movement Exit");
    }

    public override void Stay()
    {
        Debug.Log("Update");
    }
}
