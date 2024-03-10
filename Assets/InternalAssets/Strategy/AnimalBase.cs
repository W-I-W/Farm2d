using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class AnimalBase : MonoBehaviour
{
    private ISleep m_Sleep;
    private ISpeak m_Speak;
    private IMove m_Move;
    private IEat m_Eat;


    public void SetSleep(ISleep sleep) => m_Sleep = sleep;

    public void SetSpeak(ISpeak speak) => m_Speak = speak;

    public void SetMove(IMove move) => m_Move = move;

    public void SetEat(IEat eat) => m_Eat = eat;

    public void Sleep() => m_Sleep.Sleep();

    public void Speak() => m_Speak.Speak();

    public void Move() => m_Move.Move();

    public void Eat() => m_Eat.Eat();


}
