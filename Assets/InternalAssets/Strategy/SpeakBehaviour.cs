using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeakBehaviour : ISpeak
{
    public void Speak()
    {
        Debug.Log("Speak");
    }
}
