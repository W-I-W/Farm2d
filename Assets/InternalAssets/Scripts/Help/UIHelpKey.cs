using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;
using UnityEngine.UI;

public class UIHelpKey : MonoBehaviour
{
    [SerializeField] private RectTransform m_Panel;

    [SerializeField] private TextMeshProUGUI m_TextKey;
    [SerializeField] private Image m_ImageIcon;
    [SerializeField] private List<Sprite> m_Sprites;
    [SerializeField] private Sprite m_IconDefault;

    private static UIHelpKey s_Instance;

    private void Awake()
    {
        s_Instance = this;
    }

    private void Start()
    {
        gameObject.SetActive(false);
    }

    public static void Show(KeyCode key)
    {
        Sprite icon = null;
        string text = "";

        switch (key)
        {
            case KeyCode.Mouse0:
                icon = s_Instance.m_Sprites[0];
                break;
            case KeyCode.Mouse1:
                icon = s_Instance.m_Sprites[0];
                break;
            default:
                text = key.ToString();
                icon = s_Instance.m_IconDefault;
                break;
        }

        s_Instance.m_Panel.gameObject.SetActive(true);
        s_Instance.m_TextKey.text = text;
        s_Instance.m_ImageIcon.sprite = icon;
    }

    public static void Hide()
    {
        if (s_Instance != null && s_Instance.m_Panel.gameObject.activeSelf==true)
            s_Instance.m_Panel.gameObject.SetActive(false);
    }
}
