using UnityEngine;


[RequireComponent(typeof(SpriteRenderer))]
public class DropRenderer : MonoBehaviour, IAction, ITickeble
{
    [SerializeField] private ItemData m_Item;

    private SpriteRenderer m_Sprite;

    public ItemData item
    {
        get => m_Item; set
        {
            m_Item = value;
            m_Sprite.sprite = m_Item.icon;
        }
    }

    public KeyCode keyEnter => DataKeys.Enter;

    public void Tick()
    {
        if (Input.GetKeyDown(keyEnter))
        {
            bool isDrop = UIInventory.TryAdd(m_Item);
            if (isDrop)
            {
                Destroy(gameObject);
            }
        }
    }

    public void Exit()
    {

    }



    private void OnValidate()
    {
        m_Sprite = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        m_Sprite.sprite = item.icon;
    }
}
