using DG.Tweening;

using UnityEngine;


[RequireComponent(typeof(SpriteRenderer))]
public class DropRenderer : MonoBehaviour, IAction, ITickeble
{
    [SerializeField] private ItemData m_Item;
    [SerializeField] private SpriteRenderer m_Sprite;

    private Sequence m_Seq;
    public Ease ease { get; set; }

    public ItemData item
    {
        get => m_Item; set
        {
            m_Item = value;
            m_Sprite.sprite = m_Item.icon;
        }
    }

    public KeyCode keyEnter => DataKeys.Enter;

    private void Start()
    {
        m_Sprite.sprite = item.icon;
    }

    public void Tick()
    {
        if (Input.GetKeyDown(keyEnter))
        {
            bool isDrop = UIInventory.TryAdd(m_Item);

            if (isDrop)
            {
                m_Seq.Kill();
                Destroy(gameObject);
            }
        }
    }

    public void Exit()
    {

    }

    public void OnDrop(Ease ease)
    {
        Vector3 endPosition = transform.position + (Vector3)Random.insideUnitCircle * 2;
        m_Seq = DOTween.Sequence();
        m_Seq.Append(transform.DOJump(endPosition, 0.5f, 2, 1).SetEase(ease));
    }
}
