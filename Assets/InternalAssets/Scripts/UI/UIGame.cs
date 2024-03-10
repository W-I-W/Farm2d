using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class UIGame : MonoBehaviour
{
    [SerializeField] private SmelterUISettings m_Bake;

    private static UIGame s_Instance;

    public static bool bakeSelf { get => s_Instance.m_Bake.gameObject.activeSelf; }

    private void Awake()
    {
        s_Instance = this;
    }

    public static void BakeActive(bool active) =>
        s_Instance.m_Bake.gameObject.SetActive(active);


}
