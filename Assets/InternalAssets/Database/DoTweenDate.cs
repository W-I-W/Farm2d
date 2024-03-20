using DG.Tweening;

using System.Collections;
using System.Collections.Generic;

using UnityEngine;


[CreateAssetMenu(fileName = "DoTween", menuName = "Database/DoTween", order = 10)]
public class DoTweenDate : ScriptableObject
{
    [SerializeField] private Ease m_Ease;
    [SerializeField] private float m_Duration = 1;
    [SerializeField] private float m_Strangth = 1;
    [SerializeField] private int m_Vibrato = 10;

    public Ease ease => m_Ease;
    public float duration => m_Duration;
    public float strangth => m_Strangth;
    public int vibrato => m_Vibrato;
}
