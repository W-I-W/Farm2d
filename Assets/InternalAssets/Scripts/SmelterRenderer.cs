
using UnityEngine;

public class SmelterRenderer : MonoBehaviour, IAction, ITickeble
{
    public KeyCode keyEnter { get => DataKeys.Enter; }


    public void Tick()
    {
        if (Input.GetKeyDown(keyEnter))
        {
            UIGame.BakeActive(!UIGame.bakeSelf);
        }
    }

    public void Exit()
    {
        UIGame.BakeActive(false);
    }
}
