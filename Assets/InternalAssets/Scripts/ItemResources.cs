using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ItemResources : MonoBehaviour, IAction, ITickeble
{
    public KeyCode keyEnter => KeyCode.Mouse0;

    public void Tick()
    {
        if(Input.GetKeyDown(keyEnter))
        {
            Debug.Log("ss");
        }
    }

    public void Exit()
    {
        
    }


}
