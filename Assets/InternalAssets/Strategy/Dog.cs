using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : AnimalBase
{

    private void Start()
    {
        SetSleep(new SleepBehaviour());
        SetSpeak(new SpeakBehaviour());
        SetMove(new MoveBehaviour());
        SetEat(new EatBehaviour());
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool isPlayer = collision.TryGetComponent(out PlayerRenderer player);

        if (isPlayer)
        {
            UIGame.instance.Reset();
            UIGame.instance.behaviours.Add(typeof(ISleep), Sleep);
            UIGame.instance.behaviours.Add(typeof(ISpeak), Move);
        }
    }
}
