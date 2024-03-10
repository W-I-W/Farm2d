using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class StateMachine
{
    private State m_State;

    public StateMachine(State state)
    {
        m_State = state;
        m_State.Enter();
    }

    public void Update()
    {
        m_State.Stay();
    }

    public void ChangeState(State state)
    {
        m_State.Exit();
        m_State = state;
        m_State.Enter();
    }
}
