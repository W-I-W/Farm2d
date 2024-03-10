using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAction
{
    public KeyCode keyEnter { get; }

    public void Exit();
}
