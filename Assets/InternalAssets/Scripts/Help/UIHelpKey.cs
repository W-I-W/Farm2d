using System.Collections;
using System.Collections.Generic;

using TMPro;

using UnityEngine;
using UnityEngine.UI;

public class UIHelpKey : MonoBehaviour
{
    [SerializeField] private RectTransform m_Panel;

    [SerializeField] private TextMeshProUGUI m_TextKey;
    [SerializeField] private Image m_ButtonIcon;
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

        switch (key)
        {
            case KeyCode.Mouse0:
                icon = s_Instance.m_Sprites[1];
                break;
            default:
                icon = s_Instance.m_Sprites[0];
                break;
        }
        s_Instance.m_Panel.gameObject.SetActive(true);

        if (icon == null)
        {
            s_Instance.m_TextKey.text = key.ToString();
            s_Instance.m_ButtonIcon.sprite = icon;
            return;
        }
        s_Instance.m_TextKey.text = "";
        s_Instance.m_ButtonIcon.sprite = icon;

    }

    public static void Hide()
    {
        s_Instance.m_Panel.gameObject.SetActive(false);
    }
}
