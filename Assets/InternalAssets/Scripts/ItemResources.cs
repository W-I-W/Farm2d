using DG.Tweening;

using System.Collections.Generic;

using UnityEngine;


public class ItemResources : MonoBehaviour, IAction, ITickeble
{
    [SerializeField] private DropRenderer m_ItemPrefab;
    [SerializeField] private List<ItemDrop> m_Items;
    [SerializeField] private Range m_Health;
    [SerializeField] private DoTweenDate m_DamageAnimation;

    Sequence m_Seq = null;
    public KeyCode keyEnter => KeyCode.Mouse0;

    private void OnEnable()
    {
        m_Health.onValueMin += OnCreate;
    }

    private void OnDisable()
    {
        m_Health.onValueMin -= OnCreate;
    }

    public void Tick()
    {
        if (Input.GetKeyDown(keyEnter) && m_Health.value > m_Health.min)
        {
            m_Seq = DOTween.Sequence();
            m_Seq.Append(transform.DOShakePosition(m_DamageAnimation.duration, m_DamageAnimation.strangth, m_DamageAnimation.vibrato).
               SetEase(m_DamageAnimation.ease));
            m_Health.value--;
        }
    }

    public void Exit()
    {

    }

    private void OnCreate()
    {
        m_Seq.AppendCallback(() =>
        {
            m_Items.ForEach(item =>
            {
                for (int i = 0; i < item.MaxDrop; i++)
                {
                    DropRenderer drop = Instantiate(m_ItemPrefab, transform.position, Quaternion.identity);
                    drop.item = item.Item;
                    Vector3 position = transform.position;
                    position.z = m_ItemPrefab.transform.position.z;
                    drop.transform.position = position;
                    drop.OnDrop(item.Ease);
                }
            });
            Destroy(gameObject);
        });

    }
}

[System.Serializable]
public struct ItemDrop
{
    public ItemData Item;
    public Ease Ease;
    public int MaxDrop;

}

