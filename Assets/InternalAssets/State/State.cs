using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    public abstract void Enter();

    public virtual void Stay() { }

    public abstract void Exit();
}
