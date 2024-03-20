using System;
using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.Events;

[Serializable]
public class Range
{
    [SerializeField] private int m_Min = 0;
    [SerializeField] private int m_Max = 2;
    [SerializeField] private int m_Value = 2;
    public int min { get => m_Min; }

    public int max { get => m_Max; set => m_Max = (value > m_Min) ? value : m_Min; }

    public int value
    {
        get => m_Value; set
        {
            m_Value = Math.Clamp(value, min, max);
            if (m_Value == min)
                onValueMin?.Invoke();
            else if (m_Value == max)
                onValueMax?.Invoke();

            onValueChanged?.Invoke();
        }
    }

    public UnityAction onValueChanged { get; set; }

    public UnityAction onValueMin { get; set; }

    public UnityAction onValueMax { get; set; }
}
