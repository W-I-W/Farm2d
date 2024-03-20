using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class UIGame : MonoBehaviour
{
    [SerializeField] private SmelterUISettings m_Smelter;

    private static UIGame s_Instance;

    public static bool smelterSelf { get => s_Instance.m_Smelter.gameObject.activeSelf; }

    private void Awake()
    {
        s_Instance = this;
    }

    private void Start()
    {
        s_Instance.m_Smelter.gameObject.SetActive(false);
    }

    public static void SmelterActive(bool active)
    {
        if (s_Instance != null)
            s_Instance.m_Smelter.gameObject.SetActive(active);
    }


}
