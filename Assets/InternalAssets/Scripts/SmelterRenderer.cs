
using UnityEngine;

public class SmelterRenderer : MonoBehaviour, IAction, ITickeble
{
    public KeyCode keyEnter { get => DataKeys.Enter; }


    public void Tick()
    {
        if (Input.GetKeyDown(keyEnter))
        {
            bool isSmelter = !UIGame.smelterSelf;
            UIGame.SmelterActive(isSmelter);
        }
    }

    public void Exit()
    {
        UIGame.SmelterActive(false);
    }
}
