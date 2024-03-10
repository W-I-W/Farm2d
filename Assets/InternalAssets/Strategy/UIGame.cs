using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Events;

public class UIGame : MonoBehaviour
{
    public static UIGame instance;
    public Dictionary<Type, UnityAction> behaviours { get; set; }

    private void Awake()
    {
        instance = this;
    }

    public void Reset()
    {
        behaviours = new Dictionary<Type, UnityAction>();
    }

    public void OnSleep()
    {
        Type type = typeof(ISleep);
        behaviours[type].Invoke();
    }

    public void OnSpeak()
    {
        Type type = typeof(ISpeak);
        behaviours[type].Invoke();
    }
}
