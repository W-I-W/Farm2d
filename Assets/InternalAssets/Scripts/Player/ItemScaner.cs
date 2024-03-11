using System.Net.NetworkInformation;

using UnityEngine;
using UnityEngine.Windows;

public class ItemScaner : MonoBehaviour
{
    [SerializeField] private Transform m_TargetFocus;

    private Collider2D m_Collider;
    private ITickeble m_Tickeble;
    private IAction m_Action;

    private void FixedUpdate()
    {
        transform.position = m_TargetFocus.position;
    }

    private void Update()
    {
        if (m_Tickeble != null)
        {
            m_Tickeble.Tick();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        bool isEnter = collision.TryGetComponent(out IAction action);

        if (!isEnter) return;

        bool isItem = collision.TryGetComponent(out ITickeble item);

        if (isItem)
        {
            m_Tickeble = item;
        }

        m_Action = action;
        m_Collider = collision;

        Change(action);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        bool isEnter = collision.TryGetComponent(out IAction action);

        if (!isEnter) return;

        if (collision.GetInstanceID() == m_Collider.GetInstanceID())
        {
            m_Action.Exit();
            UIHelpKey.Hide();

            m_Action = null;
            m_Tickeble = null;
        }
    }


    public void Change(IAction input)
    {
        UIHelpKey.Hide();
        UIHelpKey.Show(input.keyEnter);
    }
}
