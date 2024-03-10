using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;

public class UIHelpKey : MonoBehaviour
{
    [SerializeField] private RectTransform m_Panel;

    [SerializeField] private TextMeshProUGUI m_TextKey;

    private static UIHelpKey s_Instance;

    private void Awake()
    {
        s_Instance = this;
    }

    private void Start()
    {
        gameObject.SetActive(false);
    }

    public static void Show(string key)
    {
        s_Instance.m_TextKey.text = key;
        s_Instance.m_Panel.gameObject.SetActive(true);
    }

    public static void Hide()
    {
        s_Instance.m_Panel.gameObject.SetActive(false);
    }
}
